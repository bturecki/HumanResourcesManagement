using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace HumanResourcesManagement.Presenter
{
    internal class PresenterExportData
    {
        readonly IEngine engine;
        readonly IExportData view;

        public PresenterExportData(IExportData pView)
        {
            view = pView;
            engine = Factory.GetEngine();
            view.GeneratePdfBtnClick += View_GeneratePdfBtnClick;
        }

        private void View_GeneratePdfBtnClick()
        {
            if (!view.ExportPeopleChecked && !view.ExportDepartamentsChecked)
            {
                view.ShowMessageBox("There is no data to export!");
                return;
            }
            string _filePath = view.GetSaveFilePath("PDF Files (*.pdf)|*.pdf");
            if (string.IsNullOrEmpty(_filePath))
                return;
            Document document = new Document();
            using (FileStream outputStream = new FileStream(_filePath, FileMode.Create))
            {
                PdfWriter.GetInstance(document, outputStream);
                document.Open();
                if (view.ExportPeopleChecked)
                {
                    foreach (IPersonModel _person in engine.GetAllPeople())
                    {
                        Paragraph paragraph = new Paragraph($"{_person.FirstName} {_person.LastName} {_person.Email} {_person.DepartamentName} {_person.Salary}");
                        document.Add(paragraph);
                    }
                }
                if (view.ExportDepartamentsChecked)
                {
                    foreach (IDepartament _departament in engine.GetAllDepartaments())
                    {
                        Paragraph paragraph = new Paragraph($"{_departament.Name}");
                        document.Add(paragraph);
                    }
                }
                document.Close();
            }
            view.ShowMessageBox("Data has been successfully exported!");
            view.SetDialogResultOK();
        }
    }
}
