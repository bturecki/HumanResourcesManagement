using System;

namespace HumanResourcesManagement.Interface
{
    internal interface IExportData : IBaseForm
    {
        bool ExportPeopleChecked { get; }
        bool ExportDepartamentsChecked { get; }
        bool ExportVacationsChecked { get; }
        bool ExportWorkingHoursChecked { get; }
        event Action GeneratePdfBtnClick;
        string GetSaveFilePath(string pFileTypes, string pDefaultFileName = "HumanResourcesManagementData.pdf");
    }
}
