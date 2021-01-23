using System;

namespace HumanResourcesManagement.Interface
{
    interface IMain
    {
        event Action PeopleBtnClick;
        event Action DepartamentsBtnClick;

        string LabelCreator { set; }
        void OpenPeopleView();
        void OpenDepartamentsView();
    }
}
