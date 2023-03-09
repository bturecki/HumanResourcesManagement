using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterAddNewVacation
    {
        readonly IAddNewVacation view;
        readonly IEngine engine;
        public PresenterAddNewVacation(IAddNewVacation pView)
        {
            view = pView;
            engine = Factory.GetEngine();
            view.SaveBtnClick += View_SaveBtnClick;
            view.FrmShown += View_FrmShown;
        }

        private void View_FrmShown()
        {
            view.FillGridPeople(engine.GetAllPeople());
        }
        private void View_SaveBtnClick()
        {
            System.DateTime _dateFrom = view.DateFrom;
            System.DateTime _dateTo = view.DateTo;

            if (_dateTo < _dateFrom)
            {
                view.ShowMessageBox("Date to should be greater than date from.");
                return;
            }
            if (!engine.CanSaveVacation(view.Person, _dateFrom, _dateTo))
            {
                view.ShowMessageBox("Selected person already has a saved vacation within these dates.");
                return;
            }
            engine.AddPersonVacation(view.Person, _dateFrom, _dateTo);
            view.SetDialogResultOK();
        }
    }
}
