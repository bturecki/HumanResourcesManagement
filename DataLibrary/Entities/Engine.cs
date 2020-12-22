using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SQLite;
using DataLibrary.Abstract;

namespace DataLibrary.Entities
{
    class Engine : IEngine
    {
        public List<IPersonModel> GetAllPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("select * from Person p left join PersonDepartament pd on p.id = pd.personid", new DynamicParameters());
                return output.ToList<IPersonModel>();
            }
        }
        public void SavePerson(IPersonModel pPersonModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Person (FirstName, LastName, Salary) values (@FirstName, @LastName, @Salary)", pPersonModel);
            }
            /* SQLiteConnection sqConnection = new SQLiteConnection(LoadConnectionString());
             sqConnection.Open();

             SQLiteCommand sqCommand = new SQLiteCommand();
             sqCommand.Connection = sqConnection;
             SQLiteTransaction myTrans;

             myTrans = sqConnection.BeginTransaction();
             sqCommand.Transaction = myTrans;

             try
             {
                 sqCommand.CommandText = $"INSERT INTO Person(FirstName, LastName, Salary) Values('{pPersonModel.FirstName}', '{pPersonModel.LastName}', {pPersonModel.Salary})";
                 sqCommand.ExecuteNonQuery();

                 sqCommand.CommandText = "select seq from sqlite_sequence where name='Person'; ";
                 pPersonModel.ID = Convert.ToInt32(sqCommand.ExecuteScalar());

                 sqCommand.CommandText = $"INSERT INTO PersonDepartament(PersonID, DepartamentID) Values({pPersonModel.ID}, {pPersonModel.DepartamentID})";

                 myTrans.Commit();
             }
             catch (Exception e)
             {
                 myTrans.Rollback();
             }
             finally
             {
                 sqConnection.Close();
             }*/
        }
        public List<IDepartament> GetAllDepartaments()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Departament>("select * from Departament", new DynamicParameters());
                return output.ToList<IDepartament>();
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
