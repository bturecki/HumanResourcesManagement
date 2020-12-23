using DataLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
