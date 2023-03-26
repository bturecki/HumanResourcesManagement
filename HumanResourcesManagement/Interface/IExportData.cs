using System;

namespace HumanResourcesManagement.Interface
{
    internal interface IExportData
    {
        bool ExportPeopleChecked { get; }
        bool ExportDepartamentsChecked { get; }
        event Action GeneratePdfBtnClick;
        string GetSaveFilePath(string pFileTypes, string pDefaultFileName = "HumanResourcesManagementData.pdf");
        void ShowMessageBox(string pMessage);
        void SetDialogResultOK();
    }
}
