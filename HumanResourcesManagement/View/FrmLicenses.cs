using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResourcesManagement.View
{
    public partial class FrmLicenses : BaseForm, ILicenses
    {

        public FrmLicenses()
        {
            InitializeComponent();
            new PresenterLicenses(this);
        }
        public ICustomCredintials SelectedRow => (ICustomCredintials)gridLicenses.CurrentRow.DataBoundItem;
        public string Login { get => teLogin.Text; set => teLogin.Text = value; }
        public string Password { get => tePassword.Text; set => tePassword.Text = value; }
        public bool IsAdmin { get => cbIsAdmin.Checked; set => cbIsAdmin.Checked = value; }

        public event Action SaveBtnClick;
        public event Action FrmShown;
        public event Action DeleteBtnClick;

        public void FillLogins(List<ICustomCredintials> pList)
        {
            iCustomCredintialsBindingSource.DataSource = pList;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveBtnClick();
        }
        private void FrmLicenses_Shown(object sender, EventArgs e)
        {
            FrmShown();
        }
        private void gridLicenses_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] == colDelete && e.RowIndex >= 0)
                DeleteBtnClick();
        }
    }
}
