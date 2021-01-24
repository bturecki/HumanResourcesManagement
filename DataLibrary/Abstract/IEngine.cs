using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Abstract
{
    public interface IEngine
    {
        List<IPersonModel> GetAllPeople();
        List<IDepartament> GetAllDepartaments();
        List<IPersonVacation> GetAllVacations();
        void SavePerson(IPersonModel pPersonModel);
        void UpdatePerson(IPersonModel pPersonModel);
        void SaveDepartament(IDepartament pDepartament);
        void UpdateDepartament(IDepartament pDepartament);
        void AddPersonVacation(IPersonModel pPersonModel, DateTime pDateFrom, DateTime pDateTo);
    }
}
