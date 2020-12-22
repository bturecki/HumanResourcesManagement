using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourcesManagement.View
{
    public partial class FrmAddEditPerson : Form, IAddEditPerson
    {
        public string FirstName { get => tbFirstName.Text; set => tbFirstName.Text = value; }
        public string LastName { get => tbLastName.Text; set => tbLastName.Text = value; }
        public decimal Salary { get => numSalary.Value; set => numSalary.Value = value; }

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
            ((ListBox)listBoxDepartaments).DataSource = pDepartaments;
            ((ListBox)listBoxDepartaments).DisplayMember = "Name";
            ((ListBox)listBoxDepartaments).ValueMember = "ID";
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
