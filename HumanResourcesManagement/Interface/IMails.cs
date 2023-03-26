using DataLibrary.Abstract;
using System;
using System.Collections.Generic;

namespace HumanResourcesManagement.Interface
{
    interface IMails : IBaseForm
    {
        string EmailSubject { get; set; }
        string EmailContent { get; set; }
        List<IPersonModel> SelectedPeople { get; }

        event Action SendBtnClick;
        event Action FrmShown;

        void FillGridPeople(List<IPersonModel> pList);
        void ClearGridSelection();
    }
}
