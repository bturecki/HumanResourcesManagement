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
            View.VacationAdded += View_VacationAdded;
            View.DeleteRecordBtnClick += View_DeleteRecordBtnClick;
        }

        private void View_DeleteRecordBtnClick(IPersonVacation pPersonVacation)
        {
            Engine.DeleteVacation(pPersonVacation);
            ReloadGrid();
        }
        private void View_VacationAdded()
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
