using HumanResourcesManagement.Interface;
using System.Windows.Forms;

namespace HumanResourcesManagement.View
{
    public partial class BaseForm : Form, IBaseForm
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public void ShowMessageBox(string pMessage, string pCaption = "Info")
        {
            MessageBox.Show(pMessage, pCaption);
        }
        public void SetDialogResultOK()
        {
            this.DialogResult = DialogResult.OK;
        }
        public bool AskForConfirm(string pMessage, string pCaption = "Confirm")
        {
            return MessageBox.Show(pMessage, pCaption, MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}
