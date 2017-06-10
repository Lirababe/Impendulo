using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impendulo.Email
{
    public class OutlookEmailMessage : EmailMessage
    {
        public OutlookEmailMessage() { }
        public OutlookEmailMessage(string strFromAddress)
        {
            this.addFromAddress(strFromAddress);
        }
        public OutlookEmailMessage(string fromAddress,enumMessagePriority setMessagePriority)
        {
            this.addFromAddress(fromAddress);
        }

        public override void sendMessage()
        {
            throw new NotImplementedException();
        }
    }
}