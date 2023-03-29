using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using HumanResourcesManagement.View;
using System;

namespace HumanResourcesManagement
{
    public partial class FrmLogin : BaseForm, ILogin
    {

        public FrmLogin()
        {
            InitializeComponent();
            new PresenterLogin(this);
        }

        public string Username => tbUsername.Text;

        public string Password => tbPassword.Text;

        public event Action LoginBtnClick;

        public void Login()
        {
            this.Hide();
            new FrmMain().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginBtnClick();
        }
    }
}
