using System;

namespace DataLibrary.Abstract
{
    public interface IPersonVacation
    {
        int PersonID { get; set; }
        DateTime DateFrom { get; }
        DateTime DateTo { get; }
        string PersonName { get; set; }
        string PersonLastname { get; set; }
        int RowId { get; set; }
    }
}
