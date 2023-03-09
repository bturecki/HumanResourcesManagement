using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterDepartaments
    {
        readonly IDepartaments view;
        readonly IEngine engine;

        public PresenterDepartaments(IDepartaments pView)
        {
            view = pView;
            engine = Factory.GetEngine();
            view.FrmShown += View_FrmShown;
            view.AddNewDepartamentBtnClick += View_AddNewDepartamentBtnClick;
            view.DepartamentEdited += View_DepartamentEdited;
            view.EditBtnClick += View_EditBtnClick;
            view.DeleteBtnClick += View_DeleteBtnClick;
        }

        private void View_DeleteBtnClick()
        {
            IDepartament _selectedDepartament = view.SelectedRow;
            if (!view.AskForConfirm($"Are you sure you want to delete {_selectedDepartament.Name}?"))
                return;
            engine.DeleteDepartament(_selectedDepartament);
            FillAllDepartaments();
        }
        private void View_EditBtnClick()
        {
            view.OpenAddingNewDepartament(view.SelectedRow);
        }
        private void View_AddNewDepartamentBtnClick()
        {
            view.OpenAddingNewDepartament(null);
        }
        private void View_DepartamentEdited()
        {
            FillAllDepartaments();
        }
        private void View_FrmShown()
        {
            FillAllDepartaments();
        }
        private void FillAllDepartaments()
        {
            view.FillGridDepartaments(engine.GetAllDepartaments());
        }
    }
}
