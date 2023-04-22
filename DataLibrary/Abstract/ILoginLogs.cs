using System;

namespace DataLibrary.Abstract
{
    public interface ILoginLogs
    {
        string Login { get; }
        DateTime DateTime { get; }
        Enums.EnumLoginLogType LogType { get; }
    }
}
