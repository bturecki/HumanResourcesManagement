using System;

namespace HumanResourcesManagement.Interface
{
    interface IAddEditDepartament
    {
        string DepartamentName { get; set; }

        event Action SaveBtnClick;

        void ShowMessageBox(string pMessage);
        void SetDialogResultOK();
    }
}
