using Dapper;
using DataLibrary.Abstract;
using DataLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Net.Mail;
using static DataLibrary.Tools.DateHelper;

namespace DataLibrary.Entities
{
    class Engine : IEngine
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        public List<IPersonModel> GetAllPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                IEnumerable<PersonModel> output = cnn.Query<PersonModel>("select p.id, p.firstname, p.lastname, p.salary, pd.departamentid, d.name DepartamentName from Person p inner join PersonDepartament pd on p.id = pd.personid inner join Departament d on pd.DepartamentID = d.ID", new DynamicParameters());
                return output.ToList<IPersonModel>();
            }
        }
        public void SavePerson(IPersonModel pPersonModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Person (FirstName, LastName, Salary) values (@FirstName, @LastName, @Salary)", pPersonModel);
                pPersonModel.ID = cnn.Query<int>("select max(id) from Person").Single();
                cnn.Execute("insert into PersonDepartament (PersonID, DepartamentID) values (@ID, @DepartamentID)", pPersonModel);
            }
        }
        public List<IDepartament> GetAllDepartaments()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                IEnumerable<Departament> output = cnn.Query<Departament>("select * from Departament");
                return output.ToList<IDepartament>();
            }
        }
        public void SaveDepartament(IDepartament pDepartament)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                cnn.Execute("insert into Departament (Name) values (@Name)", pDepartament);
        }
        public void UpdatePerson(IPersonModel pPersonModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Person set FirstName = @FirstName, LastName = @LastName, Salary = @Salary where ID = @ID", pPersonModel);
                cnn.Execute("update PersonDepartament set DepartamentID = @DepartamentID where PersonID = @ID", pPersonModel);
            }
        }
        public void UpdateDepartament(IDepartament pDepartament)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                cnn.Execute("update Departament set Name = @Name where ID = @ID", pDepartament);
        }
        public void AddPersonVacation(IPersonModel pPersonModel, DateTime pDateFrom, DateTime pDateTo)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Vacation(PersonID, DateFrom, DateTo) values (@PersonID, @DateFrom, @DateTo)",
                    new { PersonID = pPersonModel.ID, DateFrom = ConvertToUnixTimestamp(pDateFrom), DateTo = ConvertToUnixTimestamp(pDateTo) });
            }
        }
        public void AddLoginLog(string pLogin, DateTime pDateTime, EnumLoginLogType pType)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new
                {
                    Login = pLogin,
                    DateTime = ConvertToUnixTimestamp(pDateTime),
                    Type = (int)pType
                };
                cnn.Execute("insert into LoginLogs(login, date_time, type) values (@Login, @DateTime, @Type)", parameters);
            }
        }
        public List<ILoginLogs> GetAllLoginLogs()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                IEnumerable<LoginLogs> output = cnn.Query<LoginLogs>("select t.login, t.date_time DateSec, t.type LogType from LoginLogs t order by t.date_time desc;");
                return output.ToList<ILoginLogs>();
            }
        }
        public List<IPersonVacation> GetAllVacations()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                IEnumerable<PersonVacation> output = cnn.Query<PersonVacation>("select t.id rowid, t.PersonID, t.DateFrom DateFromSec, t.DateTo DateToSec, p.FirstName PersonName, p.LastName PersonLastName from Vacation t inner join Person p on t.PersonID = p.ID;");
                return output.ToList<IPersonVacation>();
            }
        }
        public bool CanSaveVacation(IPersonModel pPersonModel, DateTime pDateFrom, DateTime pDateTo)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select t.id rowid, t.PersonID, t.DateFrom DateFromSec, t.DateTo DateToSec, p.FirstName PersonName, p.LastName PersonLastName " +
                               "from Vacation t inner join Person p on t.PersonID = p.ID " +
                               "where t.PersonID = @PersonID and ((t.DateFrom between @DateFrom and @DateTo) or (t.DateTo between @DateFrom and @DateTo));";
                var parameters = new DynamicParameters();
                parameters.Add("@PersonID", pPersonModel.ID);
                parameters.Add("@DateFrom", ConvertToUnixTimestamp(pDateFrom));
                parameters.Add("@DateTo", ConvertToUnixTimestamp(pDateTo));
                IEnumerable<PersonVacation> output = cnn.Query<PersonVacation>(query, parameters);
                return output.ToList<IPersonVacation>().Count() == 0;
            }
        }
        public void DeleteVacation(IPersonVacation pPersonVacation)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from Vacation where ID = @id", new { id = pPersonVacation.RowId });
            }
        }
        public List<IPersonWorkingHours> GetAllWorkingHours()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                IEnumerable<PersonWorkingHours> output = cnn.Query<PersonWorkingHours>("select p.id, p.firstname, p.lastname, p.salary, pd.departamentid, d.name DepartamentName, wh.HoursFrom FromTicks, wh.HoursTo ToTicks from Person p inner join PersonDepartament pd on p.id = pd.personid inner join Departament d on pd.DepartamentID = d.ID left join WorkingHours wh on wh.PersonID = p.id");
                return output.ToList<IPersonWorkingHours>();
            }
        }
        public void SavePersonWorkingHours(IPersonWorkingHours pPersonWorkingHours, TimeSpan pTimeFrom, TimeSpan pTimeTo)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                IEnumerable<PersonWorkingHours> output = cnn.Query<PersonWorkingHours>("select p.id, p.firstname, p.lastname, p.salary, pd.departamentid, d.name DepartamentName, wh.HoursFrom FromTicks, wh.HoursTo ToTicks from Person p inner join PersonDepartament pd on p.id = pd.personid inner join Departament d on pd.DepartamentID = d.ID left join WorkingHours wh on wh.PersonID = p.id where wh.PersonID = @PersonID", new { PersonID = pPersonWorkingHours.ID });
                if (output.Count() == 0)
                    cnn.Execute("insert into WorkingHours(PersonID, HoursFrom, HoursTo) values(@PersonID, @HoursFromTicks, @HoursToTicks);", new { PersonID = pPersonWorkingHours.ID, HoursFromTicks = pTimeFrom.Ticks, HoursToTicks = pTimeTo.Ticks });
                else
                    cnn.Execute("update WorkingHours set HoursFrom = @HoursFromTicks, HoursTo = @HoursToTicks where PersonID = @PersonID;", new { PersonID = pPersonWorkingHours.ID, HoursFromTicks = pTimeFrom.Ticks, HoursToTicks = pTimeTo.Ticks });
            }
        }
        public void SendMailAsync(IMailToSend pMailToSend)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                CustomCredintials credintials = cnn.Query<CustomCredintials>("select t.email login, t.pass password from EmailCredintial t;").Single();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(credintials.Login, credintials.Password),
                    EnableSsl = true,
                };
                foreach (IPersonModel _person in pMailToSend.PeopleList)
                    smtpClient.Send(credintials.Login, _person.Email, pMailToSend.Subject, $"{_person.FirstName} {_person.LastName}, you have a new message: {pMailToSend.Content}");
            }
        }
        public void DeletePerson(IPersonModel pPersonModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "delete from Person where ID = @PersonID";
                cnn.Execute(query, new { PersonID = pPersonModel.ID });
            }
        }
        public void DeleteDepartament(IDepartament pDepartament)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "delete from Departament where ID = @Id";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", pDepartament.ID);
                cnn.Execute(query, parameters);
            }
        }
        public bool CheckIfLoginCredintialsAreValid(string pLogin, string pPassword)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Query<CustomCredintials>("select t.login, t.password from LoginCredintials t;").FirstOrDefault(x => x.Login == pLogin && x.Password == pPassword) != default;
            }
        }
        public bool CheckIfLicenseLoginArleadyExists(string pLogin)
        {
            return GetAllCredintialsLogins().FirstOrDefault(x => x.Login == pLogin) != default;
        }
        public bool CheckIfIsAdmin(string pLogin)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Query<CustomCredintials>("select t.login, t.password from LoginCredintials t where t.is_admin = 1;").FirstOrDefault(x => x.Login == pLogin) != default;
            }
        }
        public bool InsertNewLicence(string pLogin, string pPassword, bool pIsAdmin, out string pErrorText)
        {
            if (!CurrentUser.IsAdmin) // just to be sure
                throw new Exception("The user has insufficient rights to perform this operation!");
            if (string.IsNullOrEmpty(pLogin) || string.IsNullOrEmpty(pPassword))
            {
                pErrorText = "Login and password can not be null!";
                return false;
            }
            if (CheckIfLicenseLoginArleadyExists(pLogin))
            {
                pErrorText = "License with given login already exists!";
                return false;
            }
            else
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("insert into LoginCredintials (Login, Password, is_admin) values (@Login, @Password, @IsAdmin)",
                        new { Login = pLogin, Password = pPassword, IsAdmin = pIsAdmin });
                }
                pErrorText = string.Empty;
                return true;
            }
        }
        public List<ICustomCredintials> GetAllCredintialsLogins()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Query<CustomCredintials>("select t.login, t.is_admin IsAdmin from LoginCredintials t;").ToList<ICustomCredintials>();
            }
        }
        public void DeleteLicense(ICustomCredintials pCustomCredintials)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@login", pCustomCredintials.Login);
                cnn.Execute("delete from LoginCredintials where login = @login;", parameters);
            }
        }
    }
}
