using DataLibrary.Abstract;
using System;
using System.Collections.Generic;

namespace HumanResourcesManagement.Interface
{
    interface IAddNewVacation
    {
        DateTime DateFrom { get; }
        DateTime DateTo { get; }
        IPersonModel Person { get; }

        event Action SaveBtnClick;
        event Action FrmShown;

        void FillGridPeople(List<IPersonModel> pList);
        void SetDialogResultOK();
        void ShowMessageBox(string pMessage);
    }
}
