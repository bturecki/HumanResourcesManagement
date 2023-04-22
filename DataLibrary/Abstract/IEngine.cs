using System;
using System.Collections.Generic;

namespace DataLibrary.Abstract
{
    public interface IEngine
    {
        List<IPersonModel> GetAllPeople();
        List<IDepartament> GetAllDepartaments();
        List<IPersonVacation> GetAllVacations();
        List<IPersonWorkingHours> GetAllWorkingHours();
        List<ICustomCredintials> GetAllCredintialsLogins();
        bool CheckIfLoginCredintialsAreValid(string pLogin, string pPassword);
        bool CheckIfIsAdmin(string pLogin);
        void SavePerson(IPersonModel pPersonModel);
        void DeletePerson(IPersonModel pPersonModel);
        void SendMailAsync(IMailToSend pMailToSend);
        void DeleteVacation(IPersonVacation pPersonVacation);
        void UpdatePerson(IPersonModel pPersonModel);
        void SaveDepartament(IDepartament pDepartament);
        void DeleteDepartament(IDepartament pDepartament);
        void UpdateDepartament(IDepartament pDepartament);
        void AddPersonVacation(IPersonModel pPersonModel, DateTime pDateFrom, DateTime pDateTo);
        bool CanSaveVacation(IPersonModel pPersonModel, DateTime pDateFrom, DateTime pDateTo);
        void SavePersonWorkingHours(IPersonWorkingHours pPersonWorkingHours, TimeSpan pTimeFrom, TimeSpan pTimeTo);
        bool InsertNewLicence(string pLogin, string pPassword, bool pIsAdmin, out string pErrorText);
        void DeleteLicense(ICustomCredintials pCustomCredintials);
    }
}
