namespace HumanResourcesManagement.Interface
{
    internal interface IBaseForm
    {
        void ShowMessageBox(string pMessage, string pCaption = "Info");
        void SetDialogResultOK();
        bool AskForConfirm(string pMessage, string pCaption = "Confirm");
    }
}
