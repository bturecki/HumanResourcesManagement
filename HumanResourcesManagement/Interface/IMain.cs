using System;

namespace HumanResourcesManagement.Interface
{
    interface IMain
    {
        event Action PeopleBtnClick;
        event Action DepartamentsBtnClick;

        void OpenPeopleView();
        void OpenDepartamentsView();
    }
}
