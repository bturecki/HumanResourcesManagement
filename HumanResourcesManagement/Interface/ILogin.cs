using System;

namespace HumanResourcesManagement.Interface
{
    internal interface ILogin : IBaseForm
    {
        string Username { get; }
        string Password { get; }
        event Action LoginBtnClick;
        void Login();
    }
}
