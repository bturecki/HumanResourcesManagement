using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    internal class PresenterLogin
    {
        readonly IEngine engine;
        readonly ILogin view;
        public PresenterLogin(ILogin pView)
        {
            view = pView;
            engine = Factory.GetEngine();
            view.LoginBtnClick += View_LoginBtnClick;
        }

        private void View_LoginBtnClick()
        {
            if (engine.CheckIfLoginCredintialsAreValid(view.Username, view.Password))
            {
                CurrentUser.IsAdmin = engine.CheckIfIsAdmin(view.Username);
                view.Login();
            }
            else
                view.ShowMessageBox("Incorrect username or password.", "Error");
        }
    }
}
