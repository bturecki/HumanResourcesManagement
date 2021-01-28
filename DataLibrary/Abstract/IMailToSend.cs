using System.Collections.Generic;

namespace DataLibrary.Abstract
{
    public interface IMailToSend
    {
        string Content { get; }
        string Subject { get; }
        List<IPersonModel> PeopleList { get; }
        bool Validate(out string pErrMsg);
    }
}
