using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResourcesManagement.View
{
    public partial class FrmPeople : BaseForm, IPeople
    {
        public IPersonModel SelectedRow => (IPersonModel)gridPeople.CurrentRow.DataBoundItem;

        public bool AddNewPersonButtonVisible { set => btnAddNewPerson.Visible = value; }
        public bool AdminGridColumnsVisible { set => colEdit.Visible = colDelete.Visible = value; }

        public FrmPeople()
        {
            InitializeComponent();
            new PresenterPeople(this);
        }

        public event Action FrmShown;
        public event Action AddNewPersonBtnClick;
        public event Action PersonEdited;
        public event Action EditBtnClick;
        public event Action DeleteBtnClick;

        public void FillGridPeople(List<IPersonModel> pPeople)
        {
            iPersonModelBindingSource.DataSource = pPeople;
        }
        private void FrmPeople_Shown(object sender, EventArgs e)
        {
            FrmShown();
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            AddNewPersonBtnClick();
        }
        public void OpenAddingNewPerson(IPersonModel pPersonModel)
        {
            using (FrmAddEditPerson _frmAddEditPerson = new FrmAddEditPerson(pPersonModel))
            {
                if (_frmAddEditPerson.ShowDialog() == DialogResult.OK)
                    PersonEdited();
            }
        }
        private void gridPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] == colEdit && e.RowIndex >= 0)
                EditBtnClick();
            else if (((DataGridView)sender).Columns[e.ColumnIndex] == colDelete && e.RowIndex >= 0)
                DeleteBtnClick();
        }

    }
}
