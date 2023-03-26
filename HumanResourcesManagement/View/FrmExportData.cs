using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using System;
using System.Windows.Forms;

namespace HumanResourcesManagement.View
{
    public partial class FrmExportData : BaseForm, IExportData
    {

        public FrmExportData()
        {
            InitializeComponent();
            new PresenterExportData(this);
        }

        public bool ExportPeopleChecked => cePeople.Checked;
        public bool ExportDepartamentsChecked => ceDepartaments.Checked;
        public event Action GeneratePdfBtnClick;

        public string GetSaveFilePath(string pFileTypes, string pDefaultFileName = "HumanResourcesManagementData.pdf")
        {
            string filePath = string.Empty;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = pFileTypes;
                saveFileDialog.FileName = pDefaultFileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    filePath = saveFileDialog.FileName;
            }
            return filePath;
        }
        private void btnGeneratePdf_Click(object sender, EventArgs e)
        {
            GeneratePdfBtnClick();
        }
    }
}
