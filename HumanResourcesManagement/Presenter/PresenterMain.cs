using DataLibrary;
using HumanResourcesManagement.Interface;
using System;

namespace HumanResourcesManagement.Presenter
{
    class PresenterMain
    {
        readonly IMain view;

        public PresenterMain(IMain pView)
        {
            view = pView;
            view.LabelCreator = $"Bartosz Turecki {DateTime.Now.Year}";
            view.PeopleBtnClick += View_PeopleBtnClick;
            view.DepartamentsBtnClick += View_DepartamentsBtnClick;
            view.VacationsBtnClick += View_VacationsBtnClick;
            view.WorkingHoursBtnClick += View_WorkingHoursBtnClick;
            view.EmailsBtnClick += View_EmailsBtnClick;
            view.ExportDataBtnClick += View_ExportDataBtnClick;
            view.BtnEmailsVisible = CurrentUser.IsAdmin;
        }

        private void View_ExportDataBtnClick()
        {
            view.OpenExportDataView();
        }
        private void View_EmailsBtnClick()
        {
            view.OpenEmailsView();
        }
        private void View_WorkingHoursBtnClick()
        {
            view.OpenWorkingHoursView();
        }
        private void View_VacationsBtnClick()
        {
            view.OpenVacationsView();
        }
        private void View_DepartamentsBtnClick()
        {
            view.OpenDepartamentsView();
        }
        private void View_PeopleBtnClick()
        {
            view.OpenPeopleView();
        }
    }
}
