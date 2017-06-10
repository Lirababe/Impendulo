using Impendulo.Common;
using Impendulo.Common.Enum;
using Impendulo.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Impendulo.Email
{
    public class StandardEmailMessage: EmailMessage, IDisposable
    {
        private static Boolean _mailSent = false;
        private static string _CanceledMmessage = "";
        private static string _ErrorMessage = "";
        private SmtpClient client = null;

        private int _Port = 25;
        private string _Host = "";
        private Boolean _RequireAuthentication = false;
        private Boolean _RequiresSSL = false;

        public StandardEmailMessage() { }
        public StandardEmailMessage(string strFromAddress)
        {
            this.addFromAddress(strFromAddress);
        }
        public StandardEmailMessage(string fromAddress, enumMessagePriority setMessagePriority)
        {
            this.addFromAddress(fromAddress);
        }


        public void Dispose()
        {
            this.Dispose();
        }

        public override void SendMessage()
        {

            MailMessage mail = new MailMessage();
            SmtpClient = new SmtpClient(this.Host, this.PortNumber);
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);

            if (this.DisplayName.Length > 0)
            {
                mail.From = new MailAddress(this.FromAddress, this.DisplayName);
            }
            else
            {
                mail.From = new MailAddress(this.FromAddress);
            }


            string[] items = this.ToAddress.Split(';');
            if (items.Length > 0)
            {
                foreach (string EAddress in items)
                {
                    if (EAddress.Length > 0)
                    {
                        mail.To.Add(EAddress.Trim());
                    }
                }
            }
            else
            {
                mail.To.Add(this.ToAddress.Trim());
            }



            mail.Subject = this.Subject;
            mail.Body = this.Body;

            ////Depreciated will be remove soon - 10 April 2017
            //if (_Attachments != null)
            //{
            //    foreach (Attachment myAttachment in _Attachments)
            //    { mail.Attachments.Add(myAttachment); }
            //}

            if (EmailAttachments != null)
            {
                List<int> AddFileID = new List<int>();
                foreach (EmailAttachmentMetaData myAttachment in EmailAttachments)
                {
                    if (myAttachment.CurrentAttachmentType == AttachmentType.PathBasedAttachment)
                    {
                        mail.Attachments.Add(new Attachment(myAttachment.AttachmentPath));
                    }
                    if (myAttachment.CurrentAttachmentType == AttachmentType.DatabaseImageAttachment)
                    {
                        try
                        {
                            using (var Dbconnection = new MCDEntities())
                            {
                                Data.Models.File FileImage = (from a in Dbconnection.Files
                                                              where a.ImageID == myAttachment.DatabaseFileID
                                                              select a).FirstOrDefault();

                                MemoryStream ms = new MemoryStream(FileImage.FileImage);
                                string sFileName = FileImage.FileName + "." + FileImage.FileExtension;
                                mail.Attachments.Add(new Attachment(ms, sFileName));
                            };
                        }
                        catch (Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show("Error getting attachment from database : " + ex.Message);
                        }
                    }
                }
            }


            if (RequireAuthentication)
            { client.Credentials = new System.Net.NetworkCredential(UserName, Password); }
            if (this.RequireSSL)
            { client.EnableSsl = true; }

            int retryCount = 0; ;
            try
            {
                // string userState = "test message1";

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
                        //System.Threading.Thread.Sleep(1);
                        if (retryCount < 2)
                        {
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
            ////////using (var Dbconnection = new MCDEntities())
            ////////{
            ////////    string ToAddress = "";
            ////////    //foreach (this.ToAddesses)
            ////////    //{

            ////////    //}

            ////////    SMTPSetting EmailSettings = (from a in Dbconnection.SMTPSettings
            ////////                                 select a).FirstOrDefault<SMTPSetting>();
            ////////    CustomMailMessage NewMessage = new CustomMailMessage(
            ////////        EmailSettings.FromAddress,
            ////////        this.txtTestingToAddress.Text,
            ////////        this.Subject,
            ////////        this.MessageBody);

            ////////    NewMessage.DisplayName = EmailSettings.DisplayName;
            ////////    NewMessage.PortNumber = EmailSettings.PortNumber;
            ////////    NewMessage.Host = EmailSettings.SMTPHost;
            ////////    NewMessage.UserName = EmailSettings.UserName;
            ////////    NewMessage.Password = EmailSettings.Password;
            ////////    NewMessage.RequireAuthentication = EmailSettings.RequireAuthentication;
            ////////    NewMessage.RequireSSL = EmailSettings.RequiresSSL;

            ////////    foreach (string path in AttachmentsUsingFilePaths)
            ////////    {
            ////////        NewMessage.AddAttachment(new EmailAttachmentMetaData(path));
            ////////        // NewMessage.AddAttachment(new System.Net.Mail.Attachment(path));
            ////////    }
            ////////    NewMessage.sendMessage();

            ////////};
        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            String token = (string)e.UserState;

            if (e.Cancelled)
            {
                _CanceledMmessage = "[" + token + "] Send canceled.";
            }
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
        public void CancelMessageSend()
        {
            if (_mailSent == false && client != null)
            {
                client.SendAsyncCancel();
            }
        }
    }
}