using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Impendulo.Common.EmailSending
{
    public class OutlookEmailMessage : EmailMessage, IDisposable
    {
        private Outlook.Application oApp = new Outlook.Application();
        private Outlook.MailItem eMail;

        public OutlookEmailMessage()
        {
            eMail = (Outlook.MailItem)this.oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
        }
        public OutlookEmailMessage(string strFromAddress)
        {
            eMail = (Outlook.MailItem)this.oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
            this.addFromAddress(strFromAddress);
        }
        public OutlookEmailMessage(string fromAddress, enumMessagePriority MessagePriority)
        {
            eMail = (Outlook.MailItem)this.oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
            this.addFromAddress(fromAddress);
            this.MessagePriority = MessagePriority;
        }

        public override void SendMessage()
        {
            Outlook.MailItem mail = oApp.CreateItem(Outlook.OlItemType.olMailItem) as Outlook.MailItem;
            try
            {
                mail.Subject = this.Subject;
                
                //mail.Body = this.MessageBody;
                // Add recipient using display name, alias, or smtp address
                AddRecipients(mail);
                //Add All Attachments to the Message
                foreach (IAttachment attachment in this.Attachments)
                {
                    Outlook.Attachment oAttach =
                    mail.Attachments.Add(attachment.AttachemntPath, Outlook.OlAttachmentType.olByValue, Type.Missing, Type.Missing);
                    oAttach = null;
                }
                //If There Are Recipient to send the message to then send the message.
                if (mail.Recipients.Count > 0)
                {
                    Outlook.Inspector myInspector = mail.GetInspector;
                    String text;
                    text = this.MessageBody + mail.HTMLBody;
                    mail.HTMLBody = text;

                    if (this.MessagePriority == enumMessagePriority.Low)
                    {
                        mail.Importance = Microsoft.Office.Interop.Outlook.OlImportance.olImportanceLow;
                    }
                    if (this.MessagePriority == enumMessagePriority.Medium)
                    {
                        mail.Importance = Microsoft.Office.Interop.Outlook.OlImportance.olImportanceNormal;
                    }
                    if (this.MessagePriority == enumMessagePriority.High)
                    {
                        mail.Importance = Microsoft.Office.Interop.Outlook.OlImportance.olImportanceHigh;
                    }

                    mail.Save();
                    mail.Send();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error Send email Via Oultook - Error : " + ex.Message);
            }
            finally
            {
                //Explicitly release objects.
                mail = null;
            }
        }



        /// <summary>
        ///Refere to where the code was taken from
        ///https://www.add-in-express.com/creating-addins-blog/2011/09/08/outlook-fill-recipients-programmatically/
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        private bool AddRecipients(Outlook.MailItem mail)
        {
            bool retValue = false;
            Outlook.Recipients recipients = null;
            Outlook.Recipient recipientTo = null;
            Outlook.Recipient recipientCC = null;
            Outlook.Recipient recipientBCC = null;
            try
            {
                recipients = mail.Recipients;
                // first, we remove all the recipients of the e-mail
                while (recipients.Count != 0)
                {
                    recipients.Remove(1);
                }
                // now we add new recipietns to the e-mail
                foreach (IEmailAddress address in this.ToAddesses)
                {
                    recipientTo = recipients.Add((((EmailAddress)address).Address));
                    recipientTo.Type = (int)Outlook.OlMailRecipientType.olTo;
                    
                }
                foreach (IEmailAddress address in this.CcAddresses)
                {
                    recipientTo = recipients.Add((((EmailAddress)address).Address));
                    recipientTo.Type = (int)Outlook.OlMailRecipientType.olCC;
                }
                foreach (IEmailAddress address in this.BccAddress)
                {
                    recipientTo = recipients.Add((((EmailAddress)address).Address));
                    recipientTo.Type = (int)Outlook.OlMailRecipientType.olBCC;
                }
                retValue = recipients.ResolveAll();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (recipientBCC != null) Marshal.ReleaseComObject(recipientBCC);
                if (recipientCC != null) Marshal.ReleaseComObject(recipientCC);
                if (recipientTo != null) Marshal.ReleaseComObject(recipientTo);
                if (recipients != null) Marshal.ReleaseComObject(recipients);
            }
            return retValue;
        }

        public void Dispose()
        {
            oApp = null;
        }
    }
}


