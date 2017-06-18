using Impendulo.Common.EmailSending;
using Impendulo.Common.Enum;
using Impendulo.Data.Models;
using Impendulo.Email.Select_Contacts;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Impendulo.Email.Email_Message_Version_2
{
    public partial class frmEmailMessageV2 : MetroFramework.Forms.MetroForm
    {

        public List<string> AttachmentsUsingFilePaths { get; set; }

        public OutlookEmailMessage NewMessage { get; set; }
        public Employee CurrentEmployeeLoggedIn { get; set; }

        public Boolean IsSent { get; set; }

        public frmEmailMessageV2()
        {
            InitializeComponent();
            NewMessage = new OutlookEmailMessage();

        }

        private void frmEmailMessageV2_Load(object sender, EventArgs e)
        {
            this.IsSent = false;
            if (CurrentEmployeeLoggedIn == null)
            {

                NewMessage.addFromAddress("info@mcdtraining.co.za");
            }
            else
            {
                List<ContactDetail> EmailAddress = (from a in CurrentEmployeeLoggedIn.Individual.ContactDetails
                                                    where a.ContactTypeID == (int)EnumContactTypes.Email_Address
                                                    select a).ToList<ContactDetail>();
                if (EmailAddress.Count > 0)
                {
                    foreach (ContactDetail CD in EmailAddress)
                    {
                        NewMessage.addFromAddress(CD.ContactDetailValue);
                    }

                    NewMessage.MessagePriority = enumMessagePriority.Medium;
                }
                else
                {
                    NewMessage.addFromAddress("info@mcdtraining.co.za");
                    NewMessage.MessagePriority = enumMessagePriority.High;
                }

            }
            //this.refreshAttachemntListUsingDatabaseFileID();
            //this.refreshTheAttachmentList();
        }

        #region Inner Classes
        public enum AttachmentType
        {
            SystemGenerated,
            UserSelected
        }
        private class AttachmentDetails
        {
            public string AttachmentFileName { get; set; }
            public string AttachmentFileExtension { get; set; }
            public AttachmentType AttachmentClssification { get; set; }

        }
        #endregion
        #region Refresh Methods

        private void refreshAttachments()
        {
            //List<AttachmentDetails> MessageAttachments
            List<AttachmentDetails> CurrentAttachmentDetails = new List<AttachmentDetails>();
            foreach (IAttachment objMessageAttachment in NewMessage.Attachments)
            {
                if (objMessageAttachment is FileBasedEmailAttachment)
                {
                    CurrentAttachmentDetails.Add(new AttachmentDetails
                    {
                        AttachmentFileName = objMessageAttachment.AttachmentFileName,
                        AttachmentFileExtension = objMessageAttachment.AttachmentFileExtension,
                        AttachmentClssification = AttachmentType.UserSelected
                    });
                }
                if (objMessageAttachment is FileImageBasedEmailAttachment)
                {
                    CurrentAttachmentDetails.Add(new AttachmentDetails
                    {
                        AttachmentFileName = objMessageAttachment.AttachmentFileName,
                        AttachmentFileExtension = objMessageAttachment.AttachmentFileExtension,
                        AttachmentClssification = AttachmentType.SystemGenerated
                    });
                }
            }
            fileAttachmentsBindingSource.DataSource = CurrentAttachmentDetails;
        }
        #endregion
        #region Form Methods
        private Boolean verfiyIfAddressAlreadyAdded(AddressType CurrentAddressType, string EmailAddress)
        {
            Boolean Rtn = false;

            if (CurrentAddressType == AddressType.ToAddress)
            {
                foreach (EmailAddress x in NewMessage.ToAddesses)
                {
                    if (x.Address == EmailAddress)
                    {
                        Rtn = true;
                    }
                }
            }
            if (CurrentAddressType == AddressType.BccAddress)
            {
                foreach (EmailAddress x in NewMessage.BccAddress)
                {
                    if (x.Address == EmailAddress)
                    {
                        Rtn = true;
                    }
                }
            }
            if (CurrentAddressType == AddressType.CcAddress)
            {
                foreach (EmailAddress x in NewMessage.CcAddresses)
                {
                    if (x.Address == EmailAddress)
                    {
                        Rtn = true;
                    }
                }
            }

            return Rtn;
        }

        /// <summary>
        /// Adds an attachemnt retrieved from the database based of the FileID Provided.
        /// </summary>
        /// <param name="FileID"></param>
        /// <returns>True if successfully attached the file from the database, else return False.</returns>
        public Boolean addDatabaseAttachment(int FileID)
        {
            Boolean Rtn = false;
            IAttachment newAttachment;
            if (NewMessage.Attachments.Count == 0)
            {
                newAttachment = new FileImageBasedEmailAttachment(FileID, true);

            }
            else
            {
                newAttachment = new FileImageBasedEmailAttachment(FileID, false);
            }
            if (newAttachment.AttachmentFileName.Length > 0)
            {
                NewMessage.addAttachment(newAttachment);
                Rtn = true;
            }
            else
            {
                MetroMessageBox.Show(this, "Unable to add attachment from database.", "Attachment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return Rtn;

        }
        private void populateToAddresses()
        {
            this.txtMessageToAddress.Clear();
            foreach (EmailAddress add in NewMessage.ToAddesses)
            {
                if (txtMessageToAddress.Text.Length > 0)
                {
                    this.txtMessageToAddress.Text += ";";
                }
                this.txtMessageToAddress.Text += add.Address;
            }
        }
        private void populateBccAddresses()
        {
            this.txtMessageBccAddress.Clear();
            foreach (EmailAddress add in NewMessage.BccAddress)
            {
                if (txtMessageBccAddress.Text.Length > 0)
                {
                    this.txtMessageBccAddress.Text += ";";
                }
                this.txtMessageBccAddress.Text += add.Address;
            }
        }
        private void populateCcAddresses()
        {
            this.txtMessageCcAddress.Clear();
            foreach (EmailAddress add in NewMessage.CcAddresses)
            {
                if (txtMessageCcAddress.Text.Length > 0)
                {
                    this.txtMessageCcAddress.Text += ";";
                }
                this.txtMessageCcAddress.Text += add.Address;
            }
        }
        #endregion
        #region Enum Classes
        private enum AddressType
        {
            ToAddress,
            BccAddress,
            CcAddress
        }
        #endregion
        #region Control Click Events
        private void btnToAddress_Click(object sender, EventArgs e)
        {
            using (frmSelectEmailContsV2 frm = new frmSelectEmailContsV2())
            {
                frm.ShowDialog();
                frm.LoadExistingContacts(NewMessage.ToAddesses);
                List<string> EmailAddresses = (from a in frm.SelectedContacts
                                               from b in a.ContactDetails
                                               where b.ContactTypeID == (int)Common.Enum.EnumContactTypes.Email_Address
                                               select b.ContactDetailValue).ToList<string>();
                foreach (string _EmailAddress in EmailAddresses)
                {
                    if (!verfiyIfAddressAlreadyAdded(AddressType.ToAddress, _EmailAddress))
                    {
                        NewMessage.addToAddress(_EmailAddress);
                    }
                }
            }
            populateToAddresses();
        }
        private void btnCCAddress_Click(object sender, EventArgs e)
        {
            using (frmSelectEmailContsV2 frm = new frmSelectEmailContsV2())
            {
                frm.ShowDialog();
            }
        }

        private void btnBCCddress_Click(object sender, EventArgs e)
        {
            using (frmSelectEmailContsV2 frm = new frmSelectEmailContsV2())
            {
                frm.ShowDialog();
            }
        }

        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
            FileBasedEmailAttachment NewAttachment = new FileBasedEmailAttachment();
            if (NewAttachment.AttachmentFileName.Length > 0)
            {
                NewMessage.addAttachment(NewAttachment);
            }
            refreshAttachments();
        }

        private void btnRemoveAttachemnt_Click(object sender, EventArgs e)
        {
            if (fileAttachmentsBindingSource.Count > 0)
            {
                if (((AttachmentDetails)fileAttachmentsBindingSource.Current).AttachmentClssification == AttachmentType.UserSelected)
                {
                    NewMessage.Attachments.RemoveAt(fileAttachmentsBindingSource.Position);
                }
                else
                {
                    //MetroMessageBox.Show(this, "Unable to remove this attachment as it is generated by the system.", "Attachment Removal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult Rtn = MetroMessageBox.Show(this, "This is a SYSTEM Generated Attachment, are you sure that wish to remove this attachment?", "System Attachment Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Rtn == DialogResult.Yes)
                    {
                        NewMessage.Attachments.RemoveAt(fileAttachmentsBindingSource.Position);
                    }
                }

            }
            refreshAttachments();
        }
        private void btnSendEmailMessage_Click(object sender, EventArgs e)
        {
            if (txtMessageToAddress.Text.Length > 0)
            {
                foreach (string sAddress in txtMessageToAddress.Text.Split(';'))
                {
                    NewMessage.addToAddress(sAddress);
                }
            }
            if (txtMessageBccAddress.Text.Length > 0)
            {
                foreach (string sAddress in txtMessageBccAddress.Text.Split(';'))
                {
                    NewMessage.addBccAddress(sAddress);
                }
            }
            if (txtMessageCcAddress.Text.Length > 0)
            {
                foreach (string sAddress in txtMessageCcAddress.Text.Split(';'))
                {
                    NewMessage.addCcAddress(sAddress);
                }
            }

            NewMessage.MessageBody = txtMessageBody.Text;

            if (txtMessageSubject.Text.Length == 0)
            {
                DialogResult Rtn = MetroMessageBox.Show(this, "The Subject Field is blank do you to send the message with this field blank?", "Message Subject Blank", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Rtn == DialogResult.Yes)
                {
                    NewMessage.SendMessage();
                    this.Close();
                }
            }
            else
            {
                NewMessage.SendMessage();
                this.Close();
            }
        }

        private void btnManualAddedEmailAddess_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAddressFromOutlookContacts_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}


