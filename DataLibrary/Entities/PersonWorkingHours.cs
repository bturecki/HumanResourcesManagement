using DataLibrary.Abstract;
using System;

namespace DataLibrary.Entities
{
    class PersonWorkingHours : IPersonWorkingHours
    {
        public TimeSpan HourFrom { get => FromTicks.HasValue ? TimeSpan.FromTicks(FromTicks.Value) : new TimeSpan(9, 0, 0); }
        public TimeSpan HourTo { get => ToTicks.HasValue ? TimeSpan.FromTicks(ToTicks.Value) : new TimeSpan(17, 0, 0); }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartamentName { get; set; }
        public int? ID { get; set; }
        public int DepartamentID { get; set; }
        public decimal Salary { get; set; }
        private long? FromTicks { get; set; }
        private long? ToTicks { get; set; }
        public string Email { get => "bartosz.turecki@gmail.com"; }

        public bool Validate(out string pResult)
        {
            throw new NotImplementedException();
        }
    }
}
