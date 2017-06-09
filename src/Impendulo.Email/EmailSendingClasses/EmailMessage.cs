using Impendulo.Email.EmailSendingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impendulo.Email
{
    public abstract class EmailMessage : IEmailMessage
    {
        List<string> _BCCAddress = new List<string>();

        public List<IEmailAddress> BccAddress
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<IEmailAddress> CcAddresses
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IEmailAddress FromAddress
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string MessageBody
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public enumMessagePriority MessagePriority
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<IEmailAddress> ToAddesses
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void sendMessage()
        {
            throw new NotImplementedException();
        }


    }
}