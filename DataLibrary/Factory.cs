using DataLibrary.Abstract;
using DataLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public static class Factory
    {
        public static IEngine GetEngine()
        {
            return new Engine();
        }
        public static IPersonModel GetPersonModel(string pFirstName, string pLastName, decimal pSalary, int pDepartamentID)
        {
            return new PersonModel(pFirstName, pLastName, pSalary, pDepartamentID);
        }
        public static IDepartament GetDepartament(string pName)
        {
            return new Departament(pName);
        }
    }
}
