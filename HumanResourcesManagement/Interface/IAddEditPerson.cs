using DataLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesManagement.Interface
{
    interface IAddEditPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }

        event Action SaveBtnClick;
        event Action FrmShown;

        void ShowMessageBox(string pMessage);
        void SetDialogResultOK();
        void FillDepartaments(List<IDepartament> pDepartaments);
    }
}
