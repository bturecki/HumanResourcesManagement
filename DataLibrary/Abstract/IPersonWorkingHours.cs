using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Abstract
{
    public interface IPersonWorkingHours : IPersonModel
    {
        TimeSpan HourFrom { get; }
        TimeSpan HourTo { get; }
        new string FirstName { get; set; }
        new string LastName { get; set; }
        new string DepartamentName { get; set; }
    }
}
