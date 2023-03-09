using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterMails
    {
        readonly IEngine engine;
        readonly IMails view;
        public PresenterMails(IMails pView)
        {
            view = pView;
            engine = Factory.GetEngine();
            view.FrmShown += View_FrmShown;
            view.SendBtnClick += View_SendBtnClick;
        }

        private void View_FrmShown()
        {
            view.FillGridPeople(engine.GetAllPeople());
            view.ClearGridSelection();
        }
        private void View_SendBtnClick()
        {
            IMailToSend _mail = Factory.GetMailModel(view.EmailContent, view.EmailSubject, view.SelectedPeople);
            string _errMsg;
            if (!_mail.Validate(out _errMsg))
            {
                view.ShowMessageBox(_errMsg);
                return;
            }
            engine.SendMailAsync(_mail);
            view.EmailContent = string.Empty;
            view.EmailSubject = string.Empty;
            view.ClearGridSelection();
            view.ShowMessageBox(_mail.PeopleList.Count == 1 ? "1 mail was sent" : $"{_mail.PeopleList.Count} mails were sent");
        }
    }
}
