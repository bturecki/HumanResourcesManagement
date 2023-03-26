using System;

namespace HumanResourcesManagement.Interface
{
    internal interface IExportData : IBaseForm
    {
        bool ExportPeopleChecked { get; }
        bool ExportDepartamentsChecked { get; }
        event Action GeneratePdfBtnClick;
        string GetSaveFilePath(string pFileTypes, string pDefaultFileName = "HumanResourcesManagementData.pdf");
    }
}
