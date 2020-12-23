using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using HumanResourcesManagement.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourcesManagement
{
    public partial class FrmMain : Form, IMain
    {
        public FrmMain()
        {
            InitializeComponent();
            new PresenterMain(this);
        }

        public event Action PeopleBtnClick;
        public event Action DepartamentsBtnClick;

        private void btnPeople_Click(object sender, EventArgs e)
        {
            PeopleBtnClick();
        }

        public void OpenPeopleView()
        {
            using (var _frmPeople = new FrmPeople())
            {
                _frmPeople.ShowDialog();
            }
        }

        private void btnShowDepartaments_Click(object sender, EventArgs e)
        {
            DepartamentsBtnClick();
        }
        public void OpenDepartamentsView()
        {
            using (var _frmDepartaments = new FrmDepartaments())
            {
                _frmDepartaments.ShowDialog();
            }
        }
    }
}
