using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResourcesManagement.View
{
    public partial class FrmAddNewVacation : Form, IAddNewVacation
    {
        public DateTime DateFrom => dateFrom.Value;
        public DateTime DateTo => dateTo.Value;
        public IPersonModel Person => (IPersonModel)gridPeople.CurrentRow.DataBoundItem;

        public event Action SaveBtnClick;
        public event Action FrmShown;

        public FrmAddNewVacation()
        {
            InitializeComponent();
            new PresenterAddNewVacation(this);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveBtnClick();
        }
        public void SetDialogResultOK()
        {
            this.DialogResult = DialogResult.OK;
        }
        public void ShowMessageBox(string pMessage)
        {
            MessageBox.Show(pMessage);
        }
        private void FrmAddNewVacation_Shown(object sender, EventArgs e)
        {
            FrmShown();
        }
        public void FillGridPeople(List<IPersonModel> pList)
        {
            iPersonModelBindingSource.DataSource = pList;
        }
    }
}
