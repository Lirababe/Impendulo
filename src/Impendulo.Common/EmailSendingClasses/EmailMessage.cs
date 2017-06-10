using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impendulo.Common.EmailSending
{
    public abstract class EmailMessage : IEmailMessage
    {
        private List<IEmailAddress> _ToAddesses = new List<IEmailAddress>();
        private List<IEmailAddress> _BCCAddress = new List<IEmailAddress>();
        private List<IEmailAddress> _CcAddresses = new List<IEmailAddress>();
        private List<IAttachment> _Attachments = new List<IAttachment>();
        private enumMessagePriority _MessagePriority = enumMessagePriority.Low;
        private string _FromAddress = "";
        private string _MessageBody = "";
        private string _Subject = "";
        private string _DisplayName = "";

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

        public List<IAttachment> Attachments
        {
            get
            {
                return _Attachments;
            }
        }

        public string Subject
        {
            get
            {
                return _Subject;
            }

            set
            {
                _Subject = value;
            }
        }

        public string DisplayName
        {
            get
            {
                return _DisplayName;
            }

            set
            {
                _DisplayName = value;
            }
        }

        public abstract void SendMessage();

        public void addAttachment(IAttachment newAttachment)
        {
            _Attachments.Add(newAttachment);
        }
        public void addToAddress(string strEmailAddress)
        {
            try
            {
                EmailAddress newEmailAddress = new EmailAddress(strEmailAddress);
                this._ToAddesses.Add(newEmailAddress);
            }
            catch (InvalidEmailAddressException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Adding ToAddress Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
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
                System.Windows.Forms.MessageBox.Show(ex.Message, "Adding Bcc Address Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
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
                System.Windows.Forms.MessageBox.Show(ex.Message, "Adding Cc Address Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public void addFromAddress(string strEmailAddress)
        {
            try
            {
                EmailAddress newEmailAddress = new EmailAddress(strEmailAddress);
                this._FromAddress = newEmailAddress.Address;
            }
            catch (InvalidEmailAddressException ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    ex.Message, "Adding From Address Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public void clearToAddress()
        {
            this._ToAddesses.Clear();
        }
        public void clearCcAddress()
        {
            this._CcAddresses.Clear();
        }
        public void clearBccAddress()
        {
            this._ToAddesses.Clear();
        }

    }
}