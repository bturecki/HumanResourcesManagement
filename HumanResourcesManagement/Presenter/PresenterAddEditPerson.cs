using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

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
            IPersonModel _person = Factory.GetPersonModel(View.FirstName, View.LastName, View.Salary, 2);

            string output;

            bool result = _person.Validate(out output);
            if (!result)
            {
                View.ShowMessageBox(output);
                return;
            }

            Engine.SavePerson(_person);
            View.SetDialogResultOK();
        }

        private void View_FrmShown()
        {
            System.Collections.Generic.List<IDepartament> _departaments = Engine.GetAllDepartaments();
            View.FillDepartaments(_departaments);
        }
    }
}
