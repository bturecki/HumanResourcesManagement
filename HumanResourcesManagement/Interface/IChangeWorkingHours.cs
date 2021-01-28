using System;

namespace HumanResourcesManagement.Interface
{
    interface IChangeWorkingHours
    {
        TimeSpan TimeFrom { get; set; }
        TimeSpan TimeTo { get; set; }
        string FrmText { set; }

        event Action SaveBtnClick;

        void SetDialogResultOK();
    }
}
