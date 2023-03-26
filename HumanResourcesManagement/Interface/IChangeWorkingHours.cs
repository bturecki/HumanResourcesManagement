using System;

namespace HumanResourcesManagement.Interface
{
    interface IChangeWorkingHours : IBaseForm
    {
        TimeSpan TimeFrom { get; set; }
        TimeSpan TimeTo { get; set; }
        string FrmText { set; }

        event Action SaveBtnClick;
    }
}
