using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterDepartaments
    {
        IDepartaments View { get; set; }
        IEngine Engine { get; set; }

        public PresenterDepartaments(IDepartaments pView)
        {
            View = pView;
            Engine = Factory.GetEngine();
            View.FrmShown += View_FrmShown;
            View.AddNewDepartamentBtnClick += View_AddNewDepartamentBtnClick;
            View.DepartamentEdited += View_DepartamentEdited;
            View.EditBtnClick += View_EditBtnClick;
        }

        private void View_EditBtnClick()
        {
            View.OpenAddingNewDepartament(View.SelectedRow);
        }
        private void View_AddNewDepartamentBtnClick()
        {
            View.OpenAddingNewDepartament(null);
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
            View.FillGridDepartaments(Engine.GetAllDepartaments());
        }
    }
}
