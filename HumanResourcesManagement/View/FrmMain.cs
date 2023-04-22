using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using HumanResourcesManagement.View;
using System;

namespace HumanResourcesManagement
{
    public partial class FrmMain : BaseForm, IMain
    {
        public string LabelCreator { set => lblCreator.Text = value; }
        public bool BtnEmailsVisible { set => btnEmails.Visible = value; }
        public bool BtnLicensesVisible { set => btnLicenses.Visible = value; }

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
        public event Action ExportDataBtnClick;
        public event Action AddLicensesBtnClick;
        public event Action FrmClosing;

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
        public void OpenExportDataView()
        {
            using (FrmExportData _frmExportData = new FrmExportData())
                _frmExportData.ShowDialog();
        }
        public void OpenLicensesView()
        {
            using (FrmLicenses _frmAddNewLicense = new FrmLicenses())
                _frmAddNewLicense.ShowDialog();
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
        private void btnExportData_Click(object sender, EventArgs e)
        {
            ExportDataBtnClick();
        }
        private void btnAddNewLicense_Click(object sender, EventArgs e)
        {
            AddLicensesBtnClick();
        }
        private void FrmMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            FrmClosing();
        }
    }
}
