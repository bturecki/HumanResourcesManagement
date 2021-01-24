using DataLibrary.Abstract;
using System;
using System.Collections.Generic;

namespace HumanResourcesManagement.Interface
{
    interface IAddNewVacation
    {
        event Action SaveBtnClick;
        event Action FrmShown;
        DateTime DateFrom { get; }
        DateTime DateTo { get; }
        IPersonModel Person { get; }
        void FillGridPeople(List<IPersonModel> pList);
        void SetDialogResultOK();
        void ShowMessageBox(string pMessage);
    }
}
