using DataLibrary.Abstract;
using System;
using System.Collections.Generic;

namespace HumanResourcesManagement.Interface
{
    internal interface ILicenses : IBaseForm
    {
        string Login { get; set; }
        string Password { get; set; }
        bool IsAdmin { get; set; }
        ICustomCredintials SelectedRow { get; }

        event Action SaveBtnClick;
        event Action FrmShown;
        event Action DeleteBtnClick;

        void FillLogins(List<ICustomCredintials> pList);
    }
}
