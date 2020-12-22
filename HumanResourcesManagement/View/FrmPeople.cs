using DataLibrary;
using DataLibrary.Abstract;
using DataLibrary.Entities;
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
            using (var _frmAddEditPerson = new FrmAddEditPerson(pPersonModel))
            {
                if(_frmAddEditPerson.ShowDialog()==DialogResult.OK)
                    PersonEdited();
            }
        }
    }
}
