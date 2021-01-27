using DataLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesManagement.Interface
{
    interface IMails
    {
        string EmailSubject { get; set; }
        string EmailContent { get; set; }
        List<IPersonModel> SelectedPeople { get; }
        event Action SendBtnClick;
        event Action FrmShown;
        void FillGridPeople(List<IPersonModel> pList);
        void ClearGridSelection();
        void ShowMessageBox(string pMessage);
    }
}
