using DataLibrary.Abstract;
using System;
using System.Collections.Generic;

namespace HumanResourcesManagement.Interface
{
    interface IWorkingHours : IBaseForm
    {
        event Action FrmShown;
        event Action<IPersonWorkingHours> EditBtnClick;

        void FillGrid(List<IPersonWorkingHours> pList);
        void OpenChangeWorkingHours(IPersonWorkingHours pWorkingHours);
    }
}
