using DataLibrary.Abstract;
using System;
using System.Collections.Generic;

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
