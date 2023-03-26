using System;

namespace HumanResourcesManagement.Interface
{
    interface IAddEditDepartament : IBaseForm
    {
        string DepartamentName { get; set; }
        string FrmText { set; }

        event Action SaveBtnClick;
    }
}
