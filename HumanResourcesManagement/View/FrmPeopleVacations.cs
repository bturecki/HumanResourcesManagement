using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResourcesManagement.View
{
    public partial class FrmPeopleVacations : BaseForm, IPeopleVacations
    {
        public FrmPeopleVacations()
        {
            InitializeComponent();
            new PresenterPeopleVacations(this);
        }

        public event Action FrmShown;
        public event Action AddNewVacationBtnClick;
        public event Action VacationAdded;
        public event Action<IPersonVacation> DeleteRecordBtnClick;

        public void FillGrid(List<IPersonVacation> pList)
        {
            iPersonVacationBindingSource.DataSource = pList;
        }
        private void FrmPeopleVacations_Shown(object sender, EventArgs e)
        {
            FrmShown();
        }
        private void btnAddNewVacation_Click(object sender, EventArgs e)
        {
            AddNewVacationBtnClick();
        }
        public void OpenNewVacation()
        {
            using (FrmAddNewVacation _frmAddNewVacation = new FrmAddNewVacation())
                if (_frmAddNewVacation.ShowDialog() == DialogResult.OK)
                    VacationAdded();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                DeleteRecordBtnClick((IPersonVacation)gridVacations.CurrentRow.DataBoundItem);
        }
    }
}
