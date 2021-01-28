using System;

namespace DataLibrary.Abstract
{
    public interface IPersonVacation
    {
        int PersonID { get; }
        DateTime DateFrom { get; }
        DateTime DateTo { get; }
        string PersonName { get; }
        string PersonLastname { get;  }
        int RowId { get; }
    }
}
