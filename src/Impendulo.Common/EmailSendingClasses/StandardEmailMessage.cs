using Impendulo.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Impendulo.Common.EmailSending
{
    public class StandardEmailMessage : EmailMessage, IDisposable
    {
        private static Boolean _mailSent = false;
        private static string _CanceledMmessage = "";
        private static string _ErrorMessage = "";
        private SmtpClient client = null;

        private int _Port = 25;
        private string _Host = "";
        private bool _RequireAuthentication = false;
        private bool _RequiresSSL = false;
        private string _UserName = "";
        private string _Password = "";
        private string _DisplayName = "";

        public bool RequireAuthentication
        {
            get
            {
                return _RequireAuthentication;
            }
            set
            {
                _RequireAuthentication = value;
            }
        }

        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        public string Password { get; set; }
        public bool RequireSSL
        {
            get
            {
                return _RequiresSSL;
            }
            set { _RequiresSSL = value; }
        }

        public string Host
        {
            get
            {
                return _Host;
            }
            set { _Host = value; }
        }
        public int PortNumber
        {
            get
            {
                return _Port;
            }
            set
            {
                _Port = value;
            }
        }

        public StandardEmailMessage()
        {
            using (var Dbconnection = new MCDEntities())
            {
                SMTPSetting EmailSettings = (from a in Dbconnection.SMTPSettings
                                             select a).FirstOrDefault<SMTPSetting>();

                this.DisplayName = EmailSettings.DisplayName;
                this.PortNumber = EmailSettings.PortNumber;
                this.Host = EmailSettings.SMTPHost;
                this.UserName = EmailSettings.UserName;
                this.Password = EmailSettings.Password;
                this.RequireAuthentication = EmailSettings.RequireAuthentication;
                this.RequireSSL = EmailSettings.RequiresSSL;
            };
        }
        public StandardEmailMessage(string strFromAddress) : this()
        {
            this.addFromAddress(strFromAddress);
        }
        public StandardEmailMessage(string fromAddress, enumMessagePriority MessagePriority) : this()
        {
            this.addFromAddress(fromAddress);
            this.MessagePriority = MessagePriority;
        }

        public void Dispose()
        {
            this.Dispose();
        }

        public override void SendMessage()
        {
            MailMessage mail = new MailMessage();
            client = new SmtpClient(this.Host, this.PortNumber);
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);

            if (this.DisplayName.Length > 0)
            { mail.From = new MailAddress(this.FromAddress, this.DisplayName); }
            else
            { mail.From = new MailAddress(this.FromAddress); }

            foreach (IEmailAddress toAddress in this.ToAddesses) { mail.To.Add(((EmailAddress)toAddress).Address.Trim()); }
            foreach (IEmailAddress toAddress in this.BccAddress) { mail.Bcc.Add(((EmailAddress)toAddress).Address.Trim()); }
            foreach (IEmailAddress toAddress in this.CcAddresses) { mail.CC.Add(((EmailAddress)toAddress).Address.Trim()); }

            mail.Subject = this.Subject;
            mail.Body = this.MessageBody;

            if (this.MessagePriority == enumMessagePriority.Low) { mail.Priority = MailPriority.Low; }
            if (this.MessagePriority == enumMessagePriority.Medium) { mail.Priority = MailPriority.Normal; }
            if (this.MessagePriority == enumMessagePriority.High) { mail.Priority = MailPriority.High; }

            foreach (IAttachment attachment in this.Attachments)
            { mail.Attachments.Add(new Attachment(attachment.AttachemntPath)); }


            if (RequireAuthentication) { client.Credentials = new System.Net.NetworkCredential(UserName, Password); }

            if (this.RequireSSL) { client.EnableSsl = true; }

            int retryCount = 0; ;
            try
            {
                client.SendAsync(mail, "Start");
            }
            catch (SmtpFailedRecipientsException ex)
            {
                for (int i = 0; i < ex.InnerExceptions.Length; i++)
                {
                    SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;
                    if (status == SmtpStatusCode.MailboxBusy || status == SmtpStatusCode.MailboxUnavailable)
                    {
                        System.Windows.Forms.MessageBox.Show("Delivery failed - retrying in 5 seconds. Retry Attempt " + retryCount + 1 + "of 3.", "Connection Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error, System.Windows.Forms.MessageBoxDefaultButton.Button1);
                        if (retryCount < 2)
                        {
                            retryCount++;
                            string userState = "test message1";
                            client.SendAsync(mail, userState);
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Failed to deliver message to {0}",
                            ex.InnerExceptions[i].FailedRecipient, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Exception caught in RetryIfBusy(): {0}",
                        ex.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            String token = (string)e.UserState;

            if (e.Cancelled)
            {
                _CanceledMmessage = "[" + token + "] Send canceled.";
            }
            else
            {
                if (e.Error != null)
                {
                    _ErrorMessage = token.ToString() + " - " + e.Error.ToString();
                    System.Windows.Forms.MessageBox.Show(_ErrorMessage);
                }
                else
                {
                    _mailSent = true;
                    //prefrom action here
                    System.Windows.Forms.MessageBox.Show("Email Sent...!!");
                }
            }
        }
        public void CancelMessageSend()
        {
            if (_mailSent == false && client != null)
            {
                client.SendAsyncCancel();
            }
        }
    }
}