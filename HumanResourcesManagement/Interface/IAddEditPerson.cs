using DataLibrary.Abstract;
using System;
using System.Collections.Generic;

namespace HumanResourcesManagement.Interface
{
    interface IAddEditPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
        IDepartament SelectedDepartament { get; set; }

        event Action SaveBtnClick;
        event Action FrmShown;

        void ShowMessageBox(string pMessage);
        void SetDialogResultOK();
        void FillDepartaments(List<IDepartament> pDepartaments);
    }
}
