using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Impendulo.Email
{
    public class OutlookEmailMessage : EmailMessage
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
            mail.Subject = this.Subject;
            // Add recipient using display name, alias, or smtp address
            AddRecipients(mail);
            //Add All Attachments to the Message
            foreach(IAttachment attachment in this.Attachments)
            {
                mail.Attachments.Add("@" + attachment.AttachemntPath + "\\" + attachment.AttachmentFullFileName, 
                    Outlook.OlAttachmentType.olByValue, Type.Missing,
                    Type.Missing);
            }
           
            mail.Save();
            mail.Send();
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
    }
}


