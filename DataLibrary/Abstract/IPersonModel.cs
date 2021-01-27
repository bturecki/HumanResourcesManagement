using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Abstract
{
    public interface IPersonModel
    {
        int? ID { get; set; }
        int DepartamentID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
        string DepartamentName { get; set; }
        string Email { get; }
        bool Validate(out string pResult);
    }
}
