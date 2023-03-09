using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using System.Collections.Generic;
using System.Linq;

namespace HumanResourcesManagement.Presenter
{
    class PresenterAddEditPerson
    {
        readonly IEngine engine;
        readonly IPersonModel personModel;
        readonly IAddEditPerson view;

        public PresenterAddEditPerson(IAddEditPerson pView, IPersonModel pPersonModel)
        {
            personModel = pPersonModel;
            view = pView;
            engine = Factory.GetEngine();

            if (pPersonModel != null)
            {
                view.FirstName = personModel.FirstName;
                view.LastName = personModel.LastName;
                view.Salary = personModel.Salary;
                view.FrmText = "Person edit";
            }
            else
                view.FrmText = "Adding new person";

            view.FrmShown += View_FrmShown;
            view.SaveBtnClick += View_SaveBtnClick;
        }

        private void View_SaveBtnClick()
        {
            IPersonModel _person = Factory.GetPersonModel(view.FirstName, view.LastName, view.Salary, view.SelectedDepartament.ID);

            string output;

            bool result = _person.Validate(out output);
            if (!result)
            {
                view.ShowMessageBox(output);
                return;
            }

            if (personModel == null)
                engine.SavePerson(_person);
            else
            {
                personModel.FirstName = _person.FirstName;
                personModel.LastName = _person.LastName;
                personModel.Salary = _person.Salary;
                personModel.DepartamentID = _person.DepartamentID;
                engine.UpdatePerson(personModel);
            }

            view.SetDialogResultOK();
        }
        private void View_FrmShown()
        {
            List<IDepartament> _departaments = engine.GetAllDepartaments();
            view.FillDepartaments(_departaments);
            if (personModel != null)
                view.SelectedDepartament = _departaments.Where(x => x.ID == personModel.DepartamentID).Single();
        }
    }
}
