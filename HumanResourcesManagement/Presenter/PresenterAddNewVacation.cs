using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterAddNewVacation
    {
        IAddNewVacation View { get; set; }
        IEngine Engine { get; set; }
        public PresenterAddNewVacation(IAddNewVacation pView)
        {
            View = pView;
            Engine = Factory.GetEngine();
            View.SaveBtnClick += View_SaveBtnClick;
            View.FrmShown += View_FrmShown;
        }

        private void View_FrmShown()
        {
            View.FillGridPeople(Engine.GetAllPeople());
        }

        private void View_SaveBtnClick()
        {
            System.DateTime _dateFrom = View.DateFrom;
            System.DateTime _dateTo = View.DateTo;

            if (_dateTo < _dateFrom)
            {
                View.ShowMessageBox("Date to should be greater than date from.");
                return;
            }
            Engine.AddPersonVacation(View.Person, _dateFrom, _dateTo);
            View.SetDialogResultOK();
        }
    }
}
