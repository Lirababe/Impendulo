using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impendulo.Email
{
    public class StandardEmailMessage: EmailMessage
    {

        public StandardEmailMessage() { }
        public StandardEmailMessage(string strFromAddress)
        {
            this.addFromAddress(strFromAddress);
        }
        public StandardEmailMessage(string fromAddress, enumMessagePriority setMessagePriority)
        {
            this.addFromAddress(fromAddress);
        }

        public override void SendMessage()
        {
            throw new NotImplementedException();
        }
    }
}