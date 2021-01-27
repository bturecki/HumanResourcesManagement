using System.Collections.Generic;

namespace DataLibrary.Abstract
{
    public interface IMailToSend
    {
        string Content { get; set; }
        string Subject { get; set; }
        List<IPersonModel> PeopleList { get; set; }
        bool Validate(out string pErrMsg);
    }
}
