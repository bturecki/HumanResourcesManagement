using DataLibrary.Abstract;
using System;

namespace DataLibrary.Entities
{
    class PersonVacation : IPersonVacation
    {
        public int PersonID { get; set; }
        public DateTime DateFrom { get { return UnixTimeStampToDateTime(DateFromSec); } }
        public DateTime DateTo { get { return UnixTimeStampToDateTime(DateToSec); } }
        public string PersonName { get; set; }
        public string PersonLastname { get; set; }
        public int RowId { get; set; }
        int DateFromSec { get; set; }
        int DateToSec { get; set; }
        private static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
