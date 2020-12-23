using DataLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesManagement.Interface
{
    interface IDepartaments
    {
        event Action FrmShown;
        event Action AddNewDepartamentBtnClick;
        event Action DepartamentEdited;

        void FillGridDepartaments(List<IDepartament> pDepartaments);
        void OpenAddingNewDepartament(IDepartament pDepartament);
    }
}
