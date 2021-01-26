using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResourcesManagement.View
{
    public partial class FrmWorkingHours : Form, IWorkingHours
    {
        public FrmWorkingHours()
        {
            InitializeComponent();
            new PresenterWorkingHours(this);
        }

        public event Action FrmShown;
        public event Action<IPersonWorkingHours> EditBtnClick;

        public void FillGrid(List<IPersonWorkingHours> pList)
        {
            iPersonWorkingHoursBindingSource.DataSource = pList;
        }
        public void OpenChangeWorkingHours(IPersonWorkingHours pWorkingHours)
        {
            using (FrmChangeWorkingHours _frmChangeWorkingHours = new FrmChangeWorkingHours(pWorkingHours))
                if (_frmChangeWorkingHours.ShowDialog() == DialogResult.OK)
                    FrmShown();
        }
        private void FrmWorkingHours_Shown(object sender, EventArgs e)
        {
            FrmShown();
        }
        private void gvWorkingHours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                EditBtnClick((IPersonWorkingHours)gvWorkingHours.CurrentRow.DataBoundItem);
        }
    }
}
