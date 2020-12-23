using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using System;
using System.Windows.Forms;

namespace HumanResourcesManagement.View
{
    public partial class FrmAddEditDepartament : Form, IAddEditDepartament
    {
        public string DepartamentName { get => tbName.Text; set => tbName.Text = value; }

        public event Action SaveBtnClick;

        public FrmAddEditDepartament(IDepartament pDepartament)
        {
            InitializeComponent();
            new PresenterAddEditDepartament(this, pDepartament);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveBtnClick();
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
