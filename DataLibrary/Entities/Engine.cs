using Dapper;
using DataLibrary.Abstract;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace DataLibrary.Entities
{
    class Engine : IEngine
    {
        public List<IPersonModel> GetAllPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                IEnumerable<PersonModel> output = cnn.Query<PersonModel>("select p.id, p.firstname, p.lastname, p.salary, pd.departamentid from Person p inner join PersonDepartament pd on p.id = pd.personid", new DynamicParameters());
                return output.ToList<IPersonModel>();
            }
        }
        public void SavePerson(IPersonModel pPersonModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) // dodać tranzakcje https://www.youtube.com/watch?v=eKkh5Xm0OlU&ab_channel=IAmTimCorey
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
            {
                cnn.Execute("insert into Departament (Name) values (@Name)", pDepartament);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        public void UpdatePerson(IPersonModel pPersonModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) // dodać tranzakcje https://www.youtube.com/watch?v=eKkh5Xm0OlU&ab_channel=IAmTimCorey
            {
                cnn.Execute("update Person set FirstName = @FirstName, LastName = @LastName, Salary = @Salary where ID = @ID", pPersonModel);
                cnn.Execute("update PersonDepartament set DepartamentID = @DepartamentID where PersonID = @ID", pPersonModel);
            }
        }
        public void UpdateDepartament(IDepartament pDepartament)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Departament set Name = @Name where ID = @ID", pDepartament);
            }
        }
    }
}
