using System;

namespace HumanResourcesManagement.Interface
{
    interface IAddEditDepartament
    {
        string DepartamentName { get; set; }

        event Action SaveBtnClick;
        string FrmText { set; }

        void ShowMessageBox(string pMessage);
        void SetDialogResultOK();
    }
}
