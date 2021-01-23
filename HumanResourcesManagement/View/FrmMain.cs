﻿using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using HumanResourcesManagement.View;
using System;
using System.Windows.Forms;

namespace HumanResourcesManagement
{
    public partial class FrmMain : Form, IMain
    {
        public string LabelCreator { set => lblCreator.Text = value; }

        public FrmMain()
        {
            InitializeComponent();
            new PresenterMain(this);
        }

        public event Action PeopleBtnClick;
        public event Action DepartamentsBtnClick;

        public void OpenPeopleView()
        {
            using (FrmPeople _frmPeople = new FrmPeople())
            {
                _frmPeople.ShowDialog();
            }
        }
        public void OpenDepartamentsView()
        {
            using (FrmDepartaments _frmDepartaments = new FrmDepartaments())
            {
                _frmDepartaments.ShowDialog();
            }
        }
        private void btnShowDepartaments_Click_1(object sender, EventArgs e)
        {
            DepartamentsBtnClick();
        }
        private void btnPeople_Click_1(object sender, EventArgs e)
        {
            PeopleBtnClick();
        }
    }
}
