using DataLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesManagement.Interface
{
    interface IPeopleVacations
    {
        event Action FrmShown;
        event Action AddNewVacationBtnClick;
        event Action VacationAddedDeleted;
        void FillGrid(List<IPersonVacation> pList);
        void OpenNewVacation();
    }
}
