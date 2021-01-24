using DataLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Entities
{
    class PersonModel : IPersonModel
    {
        public PersonModel()
        {

        }

        public PersonModel(string pFirstName, string pLastName, decimal pSalary, int pDepartament)
        {
            FirstName = pFirstName;
            LastName = pLastName;
            Salary = pSalary;
            DepartamentID = pDepartament;
        }

        public int? ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public int DepartamentID { get; set; }
        public string DepartamentName { get; set; }

        public bool Validate(out string pResult)
        {
            var _result = new StringBuilder();

            if (string.IsNullOrEmpty(FirstName))
                _result.AppendLine("First name can not be null or empty.");

            if (string.IsNullOrEmpty(LastName))
                _result.AppendLine("Last name can not be null or empty.");

            if (Salary <= 0)
                _result.AppendLine("Salary must be greater than 0.");

            if (DepartamentID <= 0)
                _result.AppendLine("DepartamentID must be greater than 0.");

            pResult = _result.ToString();

            return _result.Length == 0;
        }
    }
}
