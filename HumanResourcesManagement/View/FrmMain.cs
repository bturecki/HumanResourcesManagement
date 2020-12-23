using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using HumanResourcesManagement.View;
using System;
using System.Windows.Forms;

namespace HumanResourcesManagement
{
    public partial class FrmMain : Form, IMain
    {
        public FrmMain()
        {
            InitializeComponent();
            new PresenterMain(this);
        }

        public event Action PeopleBtnClick;
        public event Action DepartamentsBtnClick;

        private void btnPeople_Click(object sender, EventArgs e)
        {
            PeopleBtnClick();
        }

        public void OpenPeopleView()
        {
            using (FrmPeople _frmPeople = new FrmPeople())
            {
                _frmPeople.ShowDialog();
            }
        }
        private void btnShowDepartaments_Click(object sender, EventArgs e)
        {
            DepartamentsBtnClick();
        }
        public void OpenDepartamentsView()
        {
            using (FrmDepartaments _frmDepartaments = new FrmDepartaments())
            {
                _frmDepartaments.ShowDialog();
            }
        }
    }
}
