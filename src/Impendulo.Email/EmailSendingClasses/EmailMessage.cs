using Impendulo.Email.EmailSendingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impendulo.Email
{
    public abstract class EmailMessage : IEmailMessage
    {
        List<IEmailAddress> _ToAddesses = new List<IEmailAddress>();
        List<IEmailAddress> _BCCAddress = new List<IEmailAddress>();
        List<IEmailAddress> _CcAddresses = new List<IEmailAddress>();
        enumMessagePriority _MessagePriority = enumMessagePriority.Low;
        string _FromAddress = "";
        string _MessageBody = "";

        public List<IEmailAddress> BccAddress
        {
            get
            {
                return _BCCAddress;
            }
        }

        public List<IEmailAddress> CcAddresses
        {
            get
            {
                return _CcAddresses;
            }
        }

        public string FromAddress
        {
            get
            {
                return _FromAddress;
            }
        }

        public string MessageBody
        {
            get
            {
                return _MessageBody;
            }

            set
            {
                _MessageBody = value;
            }
        }

        public enumMessagePriority MessagePriority
        {
            get
            {
                return _MessagePriority;
            }

            set
            {
                _MessagePriority = value;
            }
        }

        public List<IEmailAddress> ToAddesses
        {
            get
            {
                return _ToAddesses;
            }
        }

        public abstract void sendMessage();

        public void addToAddress(string strEmailAddress)
        {
            try
            {
                EmailAddress newEmailAddress = new EmailAddress(strEmailAddress);
                this._ToAddesses.Add(newEmailAddress);
            }
            catch (InvalidEmailAddressException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Adding Address Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public void addBccAddress(string strEmailAddress)
        {
            try
            {
                EmailAddress newEmailAddress = new EmailAddress(strEmailAddress);
                this._BCCAddress.Add(newEmailAddress);
            }
            catch (InvalidEmailAddressException ex)
            {
                throw ex;
            }
        }
        public void addCcAddress(string strEmailAddress)
        {
            try
            {
                EmailAddress newEmailAddress = new EmailAddress(strEmailAddress);
                this._CcAddresses.Add(newEmailAddress);
            }
            catch (InvalidEmailAddressException ex)
            {
                throw ex;
            }
        }
        public void clearToAddress()
        {
            this._ToAddesses.Clear();
        }

    }
}