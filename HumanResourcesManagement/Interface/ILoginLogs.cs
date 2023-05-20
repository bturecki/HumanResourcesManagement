using System;
using System.Collections.Generic;

namespace HumanResourcesManagement.Interface
{
    internal interface ILoginLogs : IBaseForm
    {
        event Action FrmShown;
        void FillLogs(List<DataLibrary.Abstract.ILoginLogs> pList);
    }
}
