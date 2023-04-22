using DataLibrary.Abstract;
using DataLibrary.Enums;
using System;
using static DataLibrary.Tools.DateHelper;

namespace DataLibrary.Entities
{
    internal class LoginLogs : ILoginLogs
    {
        public string Login { get; }
        public DateTime DateTime => UnixTimeStampToDateTime(DateSec);
        public EnumLoginLogType LogType { get; }
        int DateSec { get; }
    }
}
