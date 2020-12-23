using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HumanResourcesManagement.View
{
    public partial class FrmAddEditPerson : Form, IAddEditPerson
    {
        public string FirstName { get => tbFirstName.Text; set => tbFirstName.Text = value; }
        public string LastName { get => tbLastName.Text; set => tbLastName.Text = value; }
        public decimal Salary { get => numSalary.Value; set => numSalary.Value = value; }
        public IDepartament SelectedDepartament
        {
            get
            {
                return (IDepartament)gridDepartaments.CurrentRow.DataBoundItem;
            }
            set
            {
                gridDepartaments.ClearSelection();
                gridDepartaments.Rows.OfType<DataGridViewRow>().Where(x => (int)x.Cells["iDDataGridViewTextBoxColumn"].Value == value.ID).ToArray<DataGridViewRow>()[0].Selected = true;
            }
        }

        public event Action SaveBtnClick;
        public event Action FrmShown;

        public FrmAddEditPerson(IPersonModel pPersonModel)
        {
            InitializeComponent();
            new PresenterAddEditPerson(this, pPersonModel);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveBtnClick();
        }
        private void FrmAddEditPerson_Shown(object sender, EventArgs e)
        {
            FrmShown();
        }
        public void FillDepartaments(List<IDepartament> pDepartaments)
        {
            iDepartamentBindingSource.DataSource = pDepartaments;
        }
        public void ShowMessageBox(string pMessage)
        {
            MessageBox.Show(pMessage);
        }
        public void SetDialogResultOK()
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
