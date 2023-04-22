using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using System;
using System.Windows.Forms;

namespace HumanResourcesManagement.Presenter
{
    class PresenterMain
    {
        readonly IMain view;
        readonly IEngine engine;
        bool isLogoutDone;

        public PresenterMain(IMain pView)
        {
            view = pView;
            engine = Factory.GetEngine();
            isLogoutDone = false;
            view.LabelCreator = $"Bartosz Turecki {DateTime.Now.Year}";
            view.PeopleBtnClick += View_PeopleBtnClick;
            view.DepartamentsBtnClick += View_DepartamentsBtnClick;
            view.VacationsBtnClick += View_VacationsBtnClick;
            view.WorkingHoursBtnClick += View_WorkingHoursBtnClick;
            view.EmailsBtnClick += View_EmailsBtnClick;
            view.ExportDataBtnClick += View_ExportDataBtnClick;
            view.AddLicensesBtnClick += View_AddLicensesBtnClick;
            view.FrmClosing += View_FrmClosing;
            view.BtnEmailsVisible = view.BtnLicensesVisible = CurrentUser.IsAdmin;
        }

        private void View_FrmClosing()
        {
            if (!isLogoutDone)
            {
                engine.AddLoginLog(CurrentUser.Login, DateTime.Now, DataLibrary.Enums.EnumLoginLogType.Logout);
                isLogoutDone = true;
            }
            Application.Exit();
        }
        private void View_AddLicensesBtnClick()
        {
            view.OpenLicensesView();
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
