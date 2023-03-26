using DataLibrary.Abstract;
using System;
using System.Collections.Generic;

namespace HumanResourcesManagement.Interface
{
    interface IPeopleVacations : IBaseForm
    {
        event Action FrmShown;
        event Action AddNewVacationBtnClick;
        event Action VacationAdded;
        event Action<IPersonVacation> DeleteRecordBtnClick;

        void FillGrid(List<IPersonVacation> pList);
        void OpenNewVacation();
    }
}
