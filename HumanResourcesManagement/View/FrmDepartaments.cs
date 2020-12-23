﻿using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResourcesManagement.View
{
    public partial class FrmDepartaments : Form, IDepartaments
    {
        public IDepartament SelectedRow => (IDepartament)gridDepartaments.CurrentRow.DataBoundItem;

        public FrmDepartaments()
        {
            InitializeComponent();
            new PresenterDepartaments(this);
        }

        public event Action FrmShown;
        public event Action AddNewDepartamentBtnClick;
        public event Action DepartamentEdited;
        public event Action EditBtnClick;

        public void FillGridDepartaments(List<IDepartament> pDepartaments)
        {
            iDepartamentBindingSource.DataSource = pDepartaments;
        }
        private void FrmPeople_Shown(object sender, EventArgs e)
        {
            FrmShown();
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            AddNewDepartamentBtnClick();
        }
        public void OpenAddingNewDepartament(IDepartament pDepartament)
        {
            using (FrmAddEditDepartament _frmAddEditDepartament = new FrmAddEditDepartament(pDepartament))
            {
                if (_frmAddEditDepartament.ShowDialog() == DialogResult.OK)
                    DepartamentEdited();
            }
        }
        private void gridDepartaments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                EditBtnClick();
        }
    }
}
