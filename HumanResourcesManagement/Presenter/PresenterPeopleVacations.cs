using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterPeopleVacations
    {
        readonly IEngine engine;
        readonly IPeopleVacations view;
        public PresenterPeopleVacations(IPeopleVacations pView)
        {
            view = pView;
            engine = Factory.GetEngine();
            view.FrmShown += ReloadGrid;
            view.AddNewVacationBtnClick += View_AddNewVacationBtnClick;
            view.VacationAdded += View_VacationAdded;
            view.DeleteRecordBtnClick += View_DeleteRecordBtnClick;
        }

        private void View_DeleteRecordBtnClick(IPersonVacation pPersonVacation)
        {
            engine.DeleteVacation(pPersonVacation);
            ReloadGrid();
        }
        private void View_VacationAdded()
        {
            ReloadGrid();
        }
        private void View_AddNewVacationBtnClick()
        {
            view.OpenNewVacation();
        }
        private void ReloadGrid()
        {
            view.FillGrid(engine.GetAllVacations());
        }
    }
}
