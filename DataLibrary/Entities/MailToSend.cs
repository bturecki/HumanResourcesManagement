using DataLibrary.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLibrary.Entities
{
    class MailToSend : IMailToSend
    {
        public MailToSend(string pContent, string pSubject, List<IPersonModel> pPeopleList)
        {
            Content = pContent;
            Subject = pSubject;
            PeopleList = pPeopleList;
        }

        public string Content { get; }
        public string Subject { get; }
        public List<IPersonModel> PeopleList { get; }

        public bool Validate(out string pErrMsg)
        {
            StringBuilder _errMsg = new StringBuilder();

            if (PeopleList.Count() < 1)
                _errMsg.AppendLine("At least 1 person should be selected.");

            if (string.IsNullOrEmpty(Subject))
                _errMsg.AppendLine("Topic cannot be empty.");

            if (string.IsNullOrEmpty(Content))
                _errMsg.AppendLine("Content cannot be empty.");


            pErrMsg = _errMsg.ToString();

            return string.IsNullOrEmpty(_errMsg.ToString());
        }
    }
}
