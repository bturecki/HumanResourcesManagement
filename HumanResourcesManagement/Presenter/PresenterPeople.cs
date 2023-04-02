using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterPeople
    {
        readonly IPeople view;
        readonly IEngine engine;

        public PresenterPeople(IPeople pView)
        {
            view = pView;
            engine = Factory.GetEngine();
            view.FrmShown += View_FrmShown;
            view.AddNewPersonBtnClick += View_AddNewPersonBtnClick;
            view.PersonEdited += View_PersonEdited;
            view.EditBtnClick += View_EditBtnClick;
            view.DeleteBtnClick += View_DeleteBtnClick;
            view.AddNewPersonButtonVisible = view.AdminGridColumnsVisible = CurrentUser.IsAdmin;
        }

        private void View_DeleteBtnClick()
        {
            IPersonModel _selectedPerson = view.SelectedRow;
            if (!view.AskForConfirm($"Are you sure you want to delete {_selectedPerson.FirstName} {_selectedPerson.LastName}?"))
                return;
            engine.DeletePerson(_selectedPerson);
            FillAllPeople();
        }
        private void View_EditBtnClick()
        {
            view.OpenAddingNewPerson(view.SelectedRow);
        }
        private void View_PersonEdited()
        {
            FillAllPeople();
        }
        private void View_AddNewPersonBtnClick()
        {
            view.OpenAddingNewPerson(null);
        }
        private void View_FrmShown()
        {
            FillAllPeople();
        }
        private void FillAllPeople()
        {
            view.FillGridPeople(engine.GetAllPeople());
        }
    }
}
