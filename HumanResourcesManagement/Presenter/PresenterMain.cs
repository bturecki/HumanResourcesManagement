using HumanResourcesManagement.Interface;
using System;

namespace HumanResourcesManagement.Presenter
{
    class PresenterMain
    {
        IMain View { get; set; }

        public PresenterMain(IMain pView)
        {
            View = pView;
            View.LabelCreator = $"Bartosz Turecki {DateTime.Now.Year}";
            View.PeopleBtnClick += View_PeopleBtnClick;
            View.DepartamentsBtnClick += View_DepartamentsBtnClick;
            View.VacationsBtnClick += View_VacationsBtnClick;
            View.WorkingHoursBtnClick += View_WorkingHoursBtnClick;
            View.EmailsBtnClick += View_EmailsBtnClick;
        }

        private void View_EmailsBtnClick()
        {
            View.OpenEmailsView();
        }
        private void View_WorkingHoursBtnClick()
        {
            View.OpenWorkingHoursView();
        }
        private void View_VacationsBtnClick()
        {
            View.OpenVacationsView();
        }
        private void View_DepartamentsBtnClick()
        {
            View.OpenDepartamentsView();
        }
        private void View_PeopleBtnClick()
        {
            View.OpenPeopleView();
        }
    }
}
