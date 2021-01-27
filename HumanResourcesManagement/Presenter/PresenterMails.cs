using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterMails
    {
        IEngine Engine { get; set; }
        IMails View { get; set; }
        public PresenterMails(IMails pView)
        {
            View = pView;
            Engine = Factory.GetEngine();
            View.FrmShown += View_FrmShown;
            View.SendBtnClick += View_SendBtnClick;
        }

        private void View_FrmShown()
        {
            View.FillGridPeople(Engine.GetAllPeople());
            View.ClearGridSelection();
        }

        private void View_SendBtnClick()
        {
            IMailToSend _mail = Factory.GetMailModel(View.EmailContent, View.EmailSubject, View.SelectedPeople);
            string _errMsg;
            if (!_mail.Validate(out _errMsg))
            {
                View.ShowMessageBox(_errMsg);
                return;
            }
            Engine.SendMailAsync(_mail);
            View.EmailContent = string.Empty;
            View.EmailSubject = string.Empty;
            View.ClearGridSelection();
            View.ShowMessageBox(_mail.PeopleList.Count == 1 ? "1 mail was sent" : $"{_mail.PeopleList.Count} mails were sent");
        }
    }
}
