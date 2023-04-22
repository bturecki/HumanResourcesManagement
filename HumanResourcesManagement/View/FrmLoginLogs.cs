using HumanResourcesManagement.Presenter;
using System;
using System.Collections.Generic;

namespace HumanResourcesManagement.View
{
    public partial class FrmLoginLogs : BaseForm, Interface.ILoginLogs
    {
        public FrmLoginLogs()
        {
            InitializeComponent();
            new PresenterLoginLogs(this);
        }

        public event Action FrmShown;

        public void FillLogs(List<DataLibrary.Abstract.ILoginLogs> pList)
        {
            iLoginLogsBindingSource.DataSource = pList;
        }
        private void FrmLoginLogs_Shown(object sender, EventArgs e)
        {
            FrmShown();
        }
    }
}
