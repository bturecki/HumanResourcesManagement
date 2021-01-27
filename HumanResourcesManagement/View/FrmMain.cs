using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using HumanResourcesManagement.View;
using System;
using System.Windows.Forms;

namespace HumanResourcesManagement
{
    public partial class FrmMain : Form, IMain
    {
        public string LabelCreator { set => lblCreator.Text = value; }

        public FrmMain()
        {
            InitializeComponent();
            new PresenterMain(this);
        }

        public event Action PeopleBtnClick;
        public event Action DepartamentsBtnClick;
        public event Action VacationsBtnClick;
        public event Action WorkingHoursBtnClick;
        public event Action EmailsBtnClick;

        public void OpenPeopleView()
        {
            using (FrmPeople _frmPeople = new FrmPeople())
                _frmPeople.ShowDialog();
        }
        public void OpenDepartamentsView()
        {
            using (FrmDepartaments _frmDepartaments = new FrmDepartaments())
                _frmDepartaments.ShowDialog();
        }
        public void OpenVacationsView()
        {
            using (FrmPeopleVacations _frmVacations = new FrmPeopleVacations())
                _frmVacations.ShowDialog();
        }
        public void OpenWorkingHoursView()
        {
            using (FrmWorkingHours _frmWorkingHours = new FrmWorkingHours())
                _frmWorkingHours.ShowDialog();
        }
        public void OpenEmailsView()
        {
            using (FrmMails _frmMails = new FrmMails())
                _frmMails.ShowDialog();
        }
        private void btnShowDepartaments_Click_1(object sender, EventArgs e)
        {
            DepartamentsBtnClick();
        }
        private void btnPeople_Click_1(object sender, EventArgs e)
        {
            PeopleBtnClick();
        }
        private void btnManageVacations_Click(object sender, EventArgs e)
        {
            VacationsBtnClick();
        }
        private void btnWorkingHours_Click(object sender, EventArgs e)
        {
            WorkingHoursBtnClick();
        }
        private void btnEmails_Click(object sender, EventArgs e)
        {
            EmailsBtnClick();
        }
        
    }
}
