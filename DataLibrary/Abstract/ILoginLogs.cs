using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Abstract
{
    public interface ILoginLogs
    {
        string Login { get; }
        DateTime DateTime { get; }
        Enums.EnumLoginLogType LogType { get; }
    }
}
