using DataLibrary.Abstract;
using System;
using System.Collections.Generic;

namespace HumanResourcesManagement.Interface
{
    interface IAddEditPerson : IBaseForm
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
        string FrmText { set; }
        IDepartament SelectedDepartament { get; set; }

        event Action SaveBtnClick;
        event Action FrmShown;

        void FillDepartaments(List<IDepartament> pDepartaments);
    }
}
