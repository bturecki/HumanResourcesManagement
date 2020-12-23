using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using System.Collections.Generic;
using System.Linq;

namespace HumanResourcesManagement.Presenter
{
    class PresenterAddEditPerson
    {
        IEngine Engine { get; set; }
        IPersonModel PersonModel { get; set; }
        IAddEditPerson View { get; set; }

        public PresenterAddEditPerson(IAddEditPerson pView, IPersonModel pPersonModel)
        {
            PersonModel = pPersonModel;
            View = pView;
            Engine = Factory.GetEngine();

            if (pPersonModel != null)
            {
                View.FirstName = PersonModel.FirstName;
                View.LastName = PersonModel.LastName;
                View.Salary = PersonModel.Salary;
            }

            View.FrmShown += View_FrmShown;
            View.SaveBtnClick += View_SaveBtnClick;
        }

        private void View_SaveBtnClick()
        {
            IPersonModel _person = Factory.GetPersonModel(View.FirstName, View.LastName, View.Salary, View.SelectedDepartament.ID);

            string output;

            bool result = _person.Validate(out output);
            if (!result)
            {
                View.ShowMessageBox(output);
                return;
            }

            if (PersonModel == null)
                Engine.SavePerson(_person);
            else
            {
                PersonModel.FirstName = _person.FirstName;
                PersonModel.LastName = _person.LastName;
                PersonModel.Salary = _person.Salary;
                PersonModel.DepartamentID = _person.DepartamentID;
                Engine.UpdatePerson(PersonModel);
            }

            View.SetDialogResultOK();
        }
        private void View_FrmShown()
        {
            List<IDepartament> _departaments = Engine.GetAllDepartaments();
            View.FillDepartaments(_departaments);
            if (PersonModel != null)
                View.SelectedDepartament = _departaments.Where(x => x.ID == PersonModel.DepartamentID).Single();
        }
    }
}
