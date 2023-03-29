using Dapper;
using DataLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace DataLibrary.Entities
{
    class Engine : IEngine
    {
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
                pPersonModel.ID = cnn.Query<int>("select max(id) from Person", new DynamicParameters()).Single();
                cnn.Execute("insert into PersonDepartament (PersonID, DepartamentID) values (@ID, @DepartamentID)", pPersonModel);
            }
        }
        public List<IDepartament> GetAllDepartaments()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                IEnumerable<Departament> output = cnn.Query<Departament>("select * from Departament", new DynamicParameters());
                return output.ToList<IDepartament>();
            }
        }
        public void SaveDepartament(IDepartament pDepartament)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                cnn.Execute("insert into Departament (Name) values (@Name)", pDepartament);
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
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
                cnn.Execute($"insert into Vacation(PersonID, DateFrom, DateTo) values ({pPersonModel.ID}, {ConvertToUnixTimestamp(pDateFrom)}, {ConvertToUnixTimestamp(pDateTo)})");
        }
        private static double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }
        public List<IPersonVacation> GetAllVacations()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                IEnumerable<PersonVacation> output = cnn.Query<PersonVacation>("select t.id rowid, t.PersonID, t.DateFrom DateFromSec, t.DateTo DateToSec, p.FirstName PersonName, p.LastName PersonLastName from Vacation t inner join Person p on t.PersonID = p.ID;", new DynamicParameters());
                return output.ToList<IPersonVacation>();
            }
        }
        public bool CanSaveVacation(IPersonModel pPersonModel, DateTime pDateFrom, DateTime pDateTo)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                IEnumerable<PersonVacation> output = cnn.Query<PersonVacation>($"select t.id rowid, t.PersonID, t.DateFrom DateFromSec, t.DateTo DateToSec, p.FirstName PersonName, p.LastName PersonLastName from Vacation t inner join Person p on t.PersonID = p.ID where t.PersonID = {pPersonModel.ID} and ((t.DateFrom between {ConvertToUnixTimestamp(pDateFrom)} and {ConvertToUnixTimestamp(pDateTo)}) or (t.DateTo between {ConvertToUnixTimestamp(pDateFrom)} and {ConvertToUnixTimestamp(pDateTo)}));", new DynamicParameters());
                return output.ToList<IPersonVacation>().Count() == 0;
            }
        }
        public void DeleteVacation(IPersonVacation pPersonVacation)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                cnn.Execute($"delete from Vacation where ID = {pPersonVacation.RowId};");
        }

        public List<IPersonWorkingHours> GetAllWorkingHours()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                IEnumerable<PersonWorkingHours> output = cnn.Query<PersonWorkingHours>("select p.id, p.firstname, p.lastname, p.salary, pd.departamentid, d.name DepartamentName, wh.HoursFrom FromTicks, wh.HoursTo ToTicks from Person p inner join PersonDepartament pd on p.id = pd.personid inner join Departament d on pd.DepartamentID = d.ID left join WorkingHours wh on wh.PersonID = p.id", new DynamicParameters());
                return output.ToList<IPersonWorkingHours>();
            }
        }
        public void SavePersonWorkingHours(IPersonWorkingHours pPersonWorkingHours, TimeSpan pTimeFrom, TimeSpan pTimeTo)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                IEnumerable<PersonWorkingHours> output = cnn.Query<PersonWorkingHours>($"select p.id, p.firstname, p.lastname, p.salary, pd.departamentid, d.name DepartamentName, wh.HoursFrom FromTicks, wh.HoursTo ToTicks from Person p inner join PersonDepartament pd on p.id = pd.personid inner join Departament d on pd.DepartamentID = d.ID left join WorkingHours wh on wh.PersonID = p.id where wh.PersonID = {pPersonWorkingHours.ID}", new DynamicParameters());
                if (output.Count() == 0)
                    cnn.Execute($"insert into WorkingHours(PersonID, HoursFrom, HoursTo) values({pPersonWorkingHours.ID}, {pTimeFrom.Ticks}, {pTimeTo.Ticks});");
                else
                    cnn.Execute($"update WorkingHours set HoursFrom = {pTimeFrom.Ticks}, HoursTo = {pTimeTo.Ticks} where PersonID = {pPersonWorkingHours.ID};");
            }
        }
        public void SendMailAsync(IMailToSend pMailToSend)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                Credintials credintials = cnn.Query<Credintials>("select t.email login, t.pass password from EmailCredintial t;", new DynamicParameters()).Single();
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
                cnn.Execute($"delete from Person where ID = {pPersonModel.ID.Value}");
        }
        public void DeleteDepartament(IDepartament pDepartament)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                cnn.Execute($"delete from Departament where ID = {pDepartament.ID}");
        }
        public bool CheckIfLoginCredintialsAreValid(string pLogin, string pPassword)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Query<Credintials>("select t.login, t.password from LoginCredintials t;", new DynamicParameters()).FirstOrDefault(x => x.Login == pLogin && x.Password == pPassword) != default;
            }
        }
    }
}
