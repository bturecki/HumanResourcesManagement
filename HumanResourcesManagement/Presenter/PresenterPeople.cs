using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterPeople
    {
        IPeople View { get; set; }
        IEngine Engine { get; set; }

        public PresenterPeople(IPeople pView)
        {
            View = pView;
            Engine = Factory.GetEngine();
            View.FrmShown += View_FrmShown;
            View.AddNewPersonBtnClick += View_AddNewPersonBtnClick;
            View.PersonEdited += View_PersonEdited;
            View.EditBtnClick += View_EditBtnClick;
            View.DeleteBtnClick += View_DeleteBtnClick;
        }

        private void View_DeleteBtnClick()
        {
            IPersonModel _selectedPerson = View.SelectedRow;
            if (!View.AskForConfirm($"Are you sure you want to delete {_selectedPerson.FirstName} {_selectedPerson.LastName}?"))
                return;
            Engine.DeletePerson(_selectedPerson);
            FillAllPeople();
        }
        private void View_EditBtnClick()
        {
            View.OpenAddingNewPerson(View.SelectedRow);
        }
        private void View_PersonEdited()
        {
            FillAllPeople();
        }
        private void View_AddNewPersonBtnClick()
        {
            View.OpenAddingNewPerson(null);
        }
        private void View_FrmShown()
        {
            FillAllPeople();
        }
        private void FillAllPeople()
        {
            View.FillGridPeople(Engine.GetAllPeople());
        }
    }
}
