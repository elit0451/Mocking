using System;
using System.Collections.Generic;

namespace Mocking
{
    public class MailBox
    {
        public int NumReceivedMessages { get; internal set; }
        List<string> mail = new List<string>();
        internal void Add(Mail o)
        {
            NumReceivedMessages++;
            mail.Add(o.Content);
        }

        internal string GetLatestMessageText()
        {
            return mail[(mail.Count) - 1];
        }
    }
}