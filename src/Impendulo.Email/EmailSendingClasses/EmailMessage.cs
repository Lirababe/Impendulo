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
        public List<string> BCCAddress
        {
            get
            {
                return _BCCAddress;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<string> CCAddress
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

        public string FromAddress
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

        public List<string> ToAddesses
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