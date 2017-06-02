using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Impendulo.Email.Reseach
{
    public partial class EmailTestONe : Form
    {

        Outlook.Application oApp = new Outlook.Application();
        Microsoft.Office.Interop.Outlook.MailItem eMail;
        public EmailTestONe()
        {
            InitializeComponent();
            eMail = (Outlook.MailItem)this.oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
        }

        private void EmailTestONe_Load(object sender, EventArgs e)
        {

        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            SendEmailtoContacts();
        }

        private void SendEmailtoContacts()
        {
            List<Outlook.Recipient> Recp = new List<Outlook.Recipient>();
            Recp.Add((Outlook.Recipient)eMail.Recipients.Add("Brendanw@mweb.co.za"));
            string subjectEmail = "Meeting has been rescheduled.";
            string bodyEmail = "Meeting is one hour later.";
            //Microsoft.Office.Interop.Outlook.MAPIFolder sentContacts = (Microsoft.Office.Interop.Outlook.MAPIFolder)
            //    this.oApp.ActiveExplorer().Session.GetDefaultFolder
            //    (Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderContacts);
            //foreach (Microsoft.Office.Interop.Outlook.ContactItem contact in sentContacts.Items)
            //{
            //    if (contact.Email1Address.Contains("example.com"))
            //    {
            //        this.CreateEmailItem(subjectEmail, contact.Email1Address, bodyEmail);
            //    }
            //}
            //Add a recipient.
            // TODO: Change the following recipient where appropriate.
            //Outlook.Recipient oRecip = (Outlook.Recipient)oMsg.Recipients.Add("Brendanw@mweb.co.za");
            //oRecip.Resolve();
            this.CreateEmailItem(Recp, subjectEmail, bodyEmail);
        }

        private void CreateEmailItem(List<Outlook.Recipient> RecipientsToSendEmail, string subjectEmail, string bodyEmail)
        {
            Microsoft.Office.Interop.Outlook.MailItem eMail = (Outlook.MailItem)this.oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

            Outlook.Recipient oRecip;
            // TODO: Change the following recipient where appropriate.
            foreach (Outlook.Recipient Recp in RecipientsToSendEmail)
            {
                //(Outlook.Recipient)eMail.Recipients.Add("Brendanw@mweb.co.za")
                oRecip = Recp;
                oRecip.Resolve();
            }
            //eMail.Recipients.ResolveAll();

            eMail.Subject = subjectEmail;
            eMail.To = toEmail;
            eMail.Body = bodyEmail;
            eMail.Importance = Microsoft.Office.Interop.Outlook.OlImportance.olImportanceLow;
            eMail.Attachments.Add(@"c:\Recovery.txt", Outlook.OlAttachmentType.olByValue, Type.Missing, Type.Missing);
            ((Microsoft.Office.Interop.Outlook._MailItem)eMail).Send();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendEmailtoContacts();
        }


        // Add recipient using display name, alias, or smtp address
        //mail.Recipients.Add(manager.PrimarySmtpAddress);
        //mail.Recipients.ResolveAll();
        //mail.Attachments.Add(@"c:\sales reports\fy06q4.xlsx", Outlook.OlAttachmentType.olByValue, Type.Missing,Type.Missing);
        //mail.Send();
    }
}
