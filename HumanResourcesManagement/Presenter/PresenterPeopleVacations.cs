using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterPeopleVacations
    {
        IEngine Engine { get; set; }
        IPeopleVacations View { get; set; }
        public PresenterPeopleVacations(IPeopleVacations pView)
        {
            View = pView;
            Engine = Factory.GetEngine();
            View.FrmShown += ReloadGrid;
            View.AddNewVacationBtnClick += View_AddNewVacationBtnClick;
            View.VacationAddedDeleted += View_VacationAddedDeleted;
        }

        private void View_VacationAddedDeleted()
        {
            ReloadGrid();
        }
        private void View_AddNewVacationBtnClick()
        {
            View.OpenNewVacation();
        }
        private void ReloadGrid()
        {
            View.FillGrid(Engine.GetAllVacations());
        }
    }
}
