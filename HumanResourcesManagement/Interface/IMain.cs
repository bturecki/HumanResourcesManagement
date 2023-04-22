using System;

namespace HumanResourcesManagement.Interface
{
    interface IMain : IBaseForm
    {
        string LabelCreator { set; }
        bool BtnEmailsVisible { set; }
        bool BtnLicensesVisible { set; }

        event Action PeopleBtnClick;
        event Action DepartamentsBtnClick;
        event Action VacationsBtnClick;
        event Action WorkingHoursBtnClick;
        event Action EmailsBtnClick;
        event Action ExportDataBtnClick;
        event Action AddLicensesBtnClick;

        void OpenPeopleView();
        void OpenVacationsView();
        void OpenDepartamentsView();
        void OpenWorkingHoursView();
        void OpenEmailsView();
        void OpenExportDataView();
        void OpenLicensesView();
    }
}
