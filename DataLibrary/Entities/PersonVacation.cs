using DataLibrary.Abstract;
using System;

namespace DataLibrary.Entities
{
    class PersonVacation : IPersonVacation
    {
        public int PersonID { get; }
        public DateTime DateFrom { get { return UnixTimeStampToDateTime(DateFromSec); } }
        public DateTime DateTo { get { return UnixTimeStampToDateTime(DateToSec); } }
        public string PersonName { get; }
        public string PersonLastname { get; }
        public int RowId { get; }
        int DateFromSec { get; }
        int DateToSec { get; }
        private static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
