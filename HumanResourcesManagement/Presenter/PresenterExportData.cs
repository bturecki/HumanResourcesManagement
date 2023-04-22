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
        const string FontName = @"C:/Windows/Fonts/cour.ttf";

        public PresenterExportData(IExportData pView)
        {
            view = pView;
            engine = Factory.GetEngine();
            view.GeneratePdfBtnClick += View_GeneratePdfBtnClick;
        }

        private void View_GeneratePdfBtnClick()
        {

            if (!view.ExportPeopleChecked && !view.ExportDepartamentsChecked && !view.ExportVacationsChecked && !view.ExportWorkingHoursChecked)
            {
                view.ShowMessageBox("There is no data to export!");
                return;
            }
            string _filePath = view.GetSaveFilePath("PDF Files (*.pdf)|*.pdf");
            if (string.IsNullOrEmpty(_filePath))
                return;

            Document document = new Document();
            Font _headersFont = new Font(BaseFont.CreateFont(FontName, BaseFont.CP1250, true), 20);
            Font _tablesFont = new Font(BaseFont.CreateFont(FontName, BaseFont.CP1250, true), 14);
            using (FileStream outputStream = new FileStream(_filePath, FileMode.Create))
            {
                PdfWriter.GetInstance(document, outputStream);
                document.Open();
                List<IPersonModel> _people = engine.GetAllPeople();
                string _fristNameCaption = "First name";
                string _lastNameCaption = "Last name";
                string _departamentCaption = "Departament";
                int _maxFirstNameLength = _people.Select(x => x.FirstName.Length).Max() > _fristNameCaption.Length ? _people.Select(x => x.FirstName.Length).Max() : _fristNameCaption.Length;
                int _maxLastNameLength = _people.Select(x => x.LastName.Length).Max() > _lastNameCaption.Length ? _people.Select(x => x.LastName.Length).Max() : _lastNameCaption.Length;
                if (view.ExportPeopleChecked)
                {
                    string _salaryCaption = "Salary";
                    int _maxDepartamentNameLength = _people.Select(x => x.DepartamentName.Length).Max() > _departamentCaption.Length ? _people.Select(x => x.DepartamentName.Length).Max() : _departamentCaption.Length;
                    int _maxSalaryLength = _people.Select(x => x.Salary.ToString().Length).Max() > _salaryCaption.Length ? _people.Select(x => x.Salary.ToString().Length).Max() : _salaryCaption.Length;
                    document.Add(new Paragraph("People", _headersFont));
                    document.Add(new Paragraph($"|{(new string('-', _maxFirstNameLength))}|{new string('-', _maxLastNameLength)}|{new string('-', _maxDepartamentNameLength)}|{new string('-', _maxSalaryLength)}|", _tablesFont));
                    document.Add(new Paragraph($"|{_fristNameCaption.PadRight(_maxFirstNameLength)}|{_lastNameCaption.PadRight(_maxLastNameLength)}|{_departamentCaption.PadRight(_maxDepartamentNameLength)}|{_salaryCaption.ToString().PadRight(_maxSalaryLength)}|", _tablesFont));
                    document.Add(new Paragraph($"|{(new string('-', _maxFirstNameLength))}|{new string('-', _maxLastNameLength)}|{new string('-', _maxDepartamentNameLength)}|{new string('-', _maxSalaryLength)}|", _tablesFont));

                    foreach (IPersonModel _person in _people)
                        document.Add(new Paragraph($"|{_person.FirstName.PadRight(_maxFirstNameLength)}|{_person.LastName.PadRight(_maxLastNameLength)}|{_person.DepartamentName.PadRight(_maxDepartamentNameLength)}|{_person.Salary.ToString().PadLeft(_maxSalaryLength)}|", _tablesFont));

                    document.Add(new Paragraph($"|{(new string('-', _maxFirstNameLength))}|{new string('-', _maxLastNameLength)}|{new string('-', _maxDepartamentNameLength)}|{new string('-', _maxSalaryLength)}|", _tablesFont));
                }

                if (view.ExportDepartamentsChecked)
                {
                    string _peopleCountCaption = "People count";
                    int _maxPeopleInDepartamentLength = _peopleCountCaption.Length;
                    List<IDepartament> _departaments = engine.GetAllDepartaments();
                    int _maxDepartamentNameLength = _departaments.Select(x => x.Name.Length).Max();
                    document.Add(new Paragraph("Departaments", _headersFont));
                    document.Add(new Paragraph($"|{(new string('-', _maxDepartamentNameLength))}|{(new string('-', _maxPeopleInDepartamentLength))}|", _tablesFont));
                    document.Add(new Paragraph($"|{_departamentCaption.PadRight(_maxDepartamentNameLength)}|{_peopleCountCaption}|", _tablesFont));
                    document.Add(new Paragraph($"|{(new string('-', _maxDepartamentNameLength))}|{(new string('-', _maxPeopleInDepartamentLength))}|", _tablesFont));

                    foreach (IDepartament _departament in _departaments)
                        document.Add(new Paragraph($"|{_departament.Name.PadRight(_maxDepartamentNameLength)}|{_people.Where(x => x.DepartamentID == _departament.ID).Count().ToString().PadLeft(_maxPeopleInDepartamentLength)}|", _tablesFont));

                    document.Add(new Paragraph($"|{(new string('-', _maxDepartamentNameLength))}|{(new string('-', _maxPeopleInDepartamentLength))}|", _tablesFont));
                }

                if (view.ExportVacationsChecked)
                {
                    string _dateFromCaption = "Date from";
                    string _dateToCaption = "Date to";
                    int _maxDateLength = 10;
                    document.Add(new Paragraph("Vacations", _headersFont));
                    document.Add(new Paragraph($"|{(new string('-', _maxFirstNameLength))}|{(new string('-', _maxLastNameLength))}|{(new string('-', _maxDateLength))}|{(new string('-', _maxDateLength))}|", _tablesFont));
                    document.Add(new Paragraph($"|{_fristNameCaption.PadRight(_maxFirstNameLength)}|{_lastNameCaption.PadRight(_maxLastNameLength)}|{_dateFromCaption.PadRight(_maxDateLength)}|{_dateToCaption.PadRight(_maxDateLength)}|", _tablesFont));
                    document.Add(new Paragraph($"|{(new string('-', _maxFirstNameLength))}|{(new string('-', _maxLastNameLength))}|{(new string('-', _maxDateLength))}|{(new string('-', _maxDateLength))}|", _tablesFont));

                    foreach (IPersonVacation _vacation in engine.GetAllVacations())
                        document.Add(new Paragraph($"|{_vacation.PersonName.PadRight(_maxFirstNameLength)}|{_vacation.PersonLastname.PadRight(_maxLastNameLength)}|{_vacation.DateFrom.Date.ToString("dd.MM.yyyy").PadRight(_maxDateLength)}|{_vacation.DateTo.Date.ToString("dd.MM.yyyy").PadRight(_maxDateLength)}|", _tablesFont));

                    document.Add(new Paragraph($"|{(new string('-', _maxFirstNameLength))}|{(new string('-', _maxLastNameLength))}|{(new string('-', _maxDateLength))}|{(new string('-', _maxDateLength))}|", _tablesFont));

                }

                if (view.ExportWorkingHoursChecked)
                {
                    string _hourFromCaption = "Hour from";
                    string _hourToCaption = "Hour to";
                    int _maxHourLength = _hourFromCaption.Length;
                    document.Add(new Paragraph("Working hours", _headersFont));
                    document.Add(new Paragraph($"|{(new string('-', _maxFirstNameLength))}|{(new string('-', _maxLastNameLength))}|{(new string('-', _maxHourLength))}|{(new string('-', _maxHourLength))}|", _tablesFont));
                    document.Add(new Paragraph($"|{_fristNameCaption.PadRight(_maxFirstNameLength)}|{_lastNameCaption.PadRight(_maxLastNameLength)}|{_hourFromCaption.PadRight(_maxHourLength)}|{_hourToCaption.PadRight(_maxHourLength)}|", _tablesFont));
                    document.Add(new Paragraph($"|{(new string('-', _maxFirstNameLength))}|{(new string('-', _maxLastNameLength))}|{(new string('-', _maxHourLength))}|{(new string('-', _maxHourLength))}|", _tablesFont));

                    foreach (IPersonWorkingHours _workingHours in engine.GetAllWorkingHours())
                        document.Add(new Paragraph($"|{_workingHours.LastName.PadRight(_maxFirstNameLength)}|{_workingHours.LastName.PadRight(_maxLastNameLength)}|{_workingHours.HourFrom.ToString().PadRight(_maxHourLength)}|{_workingHours.HourTo.ToString().PadRight(_maxHourLength)}|", _tablesFont));

                    document.Add(new Paragraph($"|{(new string('-', _maxFirstNameLength))}|{(new string('-', _maxLastNameLength))}|{(new string('-', _maxHourLength))}|{(new string('-', _maxHourLength))}|", _tablesFont));
                }

                document.Close();
            }
            view.ShowMessageBox("Data has been successfully exported!");
            view.SetDialogResultOK();
        }
    }
}
