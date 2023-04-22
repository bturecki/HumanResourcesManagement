using DataLibrary.Abstract;
using System;
using static DataLibrary.Tools.DateHelper;

namespace DataLibrary.Entities
{
    class PersonVacation : IPersonVacation
    {
        public int PersonID { get; }
        public DateTime DateFrom => UnixTimeStampToDateTime(DateFromSec);
        public DateTime DateTo => UnixTimeStampToDateTime(DateToSec);
        public string PersonName { get; }
        public string PersonLastname { get; }
        public int RowId { get; }
        int DateFromSec { get; }
        int DateToSec { get; }

    }
}
