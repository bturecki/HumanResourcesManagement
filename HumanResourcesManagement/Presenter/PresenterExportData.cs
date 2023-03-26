using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            Font _headersFont = new Font(BaseFont.CreateFont(@"C:/Windows/Fonts/cour.ttf", BaseFont.CP1250, true), 16);
            Font _tablesFont = new Font(BaseFont.CreateFont(@"C:/Windows/Fonts/cour.ttf", BaseFont.CP1250, true), 12);
            using (FileStream outputStream = new FileStream(_filePath, FileMode.Create))
            {
                PdfWriter.GetInstance(document, outputStream);
                document.Open();
                List<IPersonModel> _people = engine.GetAllPeople();
                if (view.ExportPeopleChecked)
                {
                    document.Add(new Paragraph("People", _headersFont));
                    string _fristNameCaption = "First name";
                    string _lastNameCaption = "Last name";
                    string _departamentCaption = "Departament";
                    string _salaryCaption = "Salary";
                    int _maxFirstNameLength = _people.Select(x => x.FirstName.Length).Max() > _fristNameCaption.Length ? _people.Select(x => x.FirstName.Length).Max() : _fristNameCaption.Length;
                    int _maxLastNameLength = _people.Select(x => x.LastName.Length).Max() > _lastNameCaption.Length ? _people.Select(x => x.LastName.Length).Max() : _lastNameCaption.Length;
                    int _maxDepartamentNameLength = _people.Select(x => x.DepartamentName.Length).Max() > _departamentCaption.Length ? _people.Select(x => x.DepartamentName.Length).Max() : _departamentCaption.Length;
                    int _maxSalaryLength = _people.Select(x => x.Salary.ToString().Length).Max() > _salaryCaption.Length ? _people.Select(x => x.Salary.ToString().Length).Max() : _salaryCaption.Length;
                    document.Add(new Paragraph($"|{(new string('-', _maxFirstNameLength))}|{new string('-', _maxLastNameLength)}|{new string('-', _maxDepartamentNameLength)}|{new string('-', _maxSalaryLength)}|", _tablesFont));
                    document.Add(new Paragraph($"|{_fristNameCaption.PadRight(_maxFirstNameLength)}|{_lastNameCaption.PadRight(_maxLastNameLength)}|{_departamentCaption.PadRight(_maxDepartamentNameLength)}|{_salaryCaption.ToString().PadRight(_maxSalaryLength)}|", _tablesFont));
                    document.Add(new Paragraph($"|{(new string('-', _maxFirstNameLength))}|{new string('-', _maxLastNameLength)}|{new string('-', _maxDepartamentNameLength)}|{new string('-', _maxSalaryLength)}|", _tablesFont));

                    foreach (IPersonModel _person in _people)
                        document.Add(new Paragraph($"|{_person.FirstName.PadRight(_maxFirstNameLength)}|{_person.LastName.PadRight(_maxLastNameLength)}|{_person.DepartamentName.PadRight(_maxDepartamentNameLength)}|{_person.Salary.ToString().PadLeft(_maxSalaryLength)}|", _tablesFont));

                    document.Add(new Paragraph($"|{(new string('-', _maxFirstNameLength))}|{new string('-', _maxLastNameLength)}|{new string('-', _maxDepartamentNameLength)}|{new string('-', _maxSalaryLength)}|", _tablesFont));
                }

                if (view.ExportDepartamentsChecked)
                {
                    string _departamentCaption = "Departaments";
                    string _peopleCountCaption = "People count";
                    int _maxPeopleInDepartamentLength = _peopleCountCaption.Length;
                    document.Add(new Paragraph("Departaments", _headersFont));
                    List<IDepartament> _departaments = engine.GetAllDepartaments();
                    int _maxDepartamentNameLength = _departaments.Select(x => x.Name.Length).Max();
                    document.Add(new Paragraph($"|{(new string('-', _maxDepartamentNameLength))}|{(new string('-', _maxPeopleInDepartamentLength))}|", _tablesFont));
                    document.Add(new Paragraph($"|{_departamentCaption.PadRight(_maxDepartamentNameLength)}|{_peopleCountCaption}|", _tablesFont));
                    document.Add(new Paragraph($"|{(new string('-', _maxDepartamentNameLength))}|{(new string('-', _maxPeopleInDepartamentLength))}|", _tablesFont));

                    foreach (IDepartament _departament in _departaments)
                        document.Add(new Paragraph($"|{_departament.Name.PadRight(_maxDepartamentNameLength)}|{_people.Where(x => x.DepartamentID == _departament.ID).Count().ToString().PadLeft(_maxPeopleInDepartamentLength)}|", _tablesFont));

                    document.Add(new Paragraph($"|{(new string('-', _maxDepartamentNameLength))}|{(new string('-', _maxPeopleInDepartamentLength))}|", _tablesFont));
                }

                document.Close();
            }
            view.ShowMessageBox("Data has been successfully exported!");
            view.SetDialogResultOK();
        }
    }
}
