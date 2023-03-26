using DataLibrary.Abstract;
using DataLibrary.Entities;
using System.Collections.Generic;

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
        public static IMailToSend GetMailModel(string pContent, string pSubject, List<IPersonModel> pPeopleList)
        {
            return new MailToSend(pContent, pSubject, pPeopleList);
        }
    }
}
