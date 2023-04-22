using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    internal class PresenterLicenses
    {

        readonly ILicenses view;
        readonly IEngine engine;
        public PresenterLicenses(ILicenses pView)
        {
            view = pView;
            engine = Factory.GetEngine();
            view.FrmShown += View_FrmShown;
            view.SaveBtnClick += View_SaveBtnClick;
            view.DeleteBtnClick += View_DeleteBtnClick;
        }

        private void View_DeleteBtnClick()
        {
            if (CurrentUser.Login == view.SelectedRow.Login)
            {
                view.ShowMessageBox("You can not delete yourself!");
                return;
            }
            if (!view.AskForConfirm($"Are you sure?"))
                return;
            engine.DeleteLicense(view.SelectedRow);
            FillData();
        }
        private void View_SaveBtnClick()
        {
            string _errText;
            bool _result = engine.InsertNewLicence(view.Login, view.Password, view.IsAdmin, out _errText);
            if (_result)
            {
                view.Login = string.Empty;
                view.Password = string.Empty;
                view.IsAdmin = false;
                FillData();
            }
            else
                view.ShowMessageBox(_errText);
        }
        private void View_FrmShown()
        {
            FillData();
        }
        void FillData()
        {
            view.FillLogins(engine.GetAllCredintialsLogins());
        }
    }
}
