using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using System;

namespace HumanResourcesManagement.View
{
    public partial class FrmAddEditDepartament : BaseForm, IAddEditDepartament
    {
        public string DepartamentName { get => tbName.Text; set => tbName.Text = value; }
        public string FrmText { set => this.Text = value; }

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
    }
}
