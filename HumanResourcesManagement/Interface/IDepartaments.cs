using DataLibrary.Abstract;
using System;
using System.Collections.Generic;

namespace HumanResourcesManagement.Interface
{
    interface IDepartaments
    {
        IDepartament SelectedRow { get; }

        event Action FrmShown;
        event Action AddNewDepartamentBtnClick;
        event Action DepartamentEdited;
        event Action EditBtnClick;

        void FillGridDepartaments(List<IDepartament> pDepartaments);
        void OpenAddingNewDepartament(IDepartament pDepartament);
    }
}
