using System;

namespace HumanResourcesManagement.Interface
{
    interface IMain
    {
        event Action PeopleBtnClick;
        event Action DepartamentsBtnClick;
        event Action VacationsBtnClick;
        event Action WorkingHoursBtnClick;
        event Action EmailsBtnClick;

        string LabelCreator { set; }
        void OpenPeopleView();
        void OpenVacationsView();
        void OpenDepartamentsView();
        void OpenWorkingHoursView();
        void OpenEmailsView();
    }
}
