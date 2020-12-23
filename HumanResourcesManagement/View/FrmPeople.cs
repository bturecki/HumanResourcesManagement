﻿using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResourcesManagement.View
{
    public partial class FrmPeople : Form, IPeople
    {
        public FrmPeople()
        {
            InitializeComponent();
            new PresenterPeople(this);
        }

        public event Action FrmShown;
        public event Action AddNewPersonBtnClick;
        public event Action PersonEdited;

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
    }
}