using Impendulo.Common.Enum;
using Impendulo.Data.Models;
using Impendulo.Email.Email_Message_Version_2;
using Impendulo.Enquiry.Development.InitialDocumentation.ApprenticeshipDocumentation;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.Enquiry.Development.InitaialConsultation
{
    public partial class frmEnquiryInitialConsultationV2 : MetroForm
    {
        public int EmployeeID { get; set; }
        public Data.Models.Enquiry CurrentEnquiry { get; set; }
        public Employee CurrentEmployeeLoggedIn { get; set; }
        public frmEnquiryInitialConsultationV2()
        {
            InitializeComponent();
        }

        private void frmEnquiryInitialConsultationV2_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {
                EquiryHistory hist = new EquiryHistory
                {
                    EnquiryID = CurrentEnquiry.EnquiryID,
                    EmployeeID = this.EmployeeID,
                    LookupEquiyHistoryTypeID = (int)EnumEquiryHistoryTypes.Enquiry_Initial_Consultation_Completed,
                    DateEnquiryUpdated = DateTime.Now,
                    EnquiryNotes = txtNotes.Text
                };
                Dbconnection.EquiryHistories.Add(hist);
                int IsSaved = Dbconnection.SaveChanges();
                if (IsSaved > 0)
                {
                    Dbconnection.Enquiries.Attach(CurrentEnquiry);
                    CurrentEnquiry.InitialConsultationComplete = true;
                    Dbconnection.Entry<Data.Models.Enquiry>(CurrentEnquiry).State = System.Data.Entity.EntityState.Modified;
                    Dbconnection.SaveChanges();
                }
            };
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcessDocumentation_Click(object sender, EventArgs e)
        {
            using (frmInitailDocumentation frm3 = new frmInitailDocumentation())
            {
                frm3.ShowDialog();
                if (!frm3.IsCanceled)
                {

                    if (frm3.UseEmail)
                    {
                        frmEmailMessageV2 frm1 = new frmEmailMessageV2();

                        //List<ContactDetail> you = (from a in CurrentEnquiryObj.Individuals
                        //                           from b in a.ContactDetails
                        //                           where b.ContactTypeID == (int)Common.Enum.EnumContactTypes.Email_Address
                        //                           select b).ToList<ContactDetail>();

                        ////Sets the Email Address For the Currently Selected Contact For this Enquiry
                        //foreach (ContactDetail ConDetObj in you)
                        //{
                        //    if (frm1.txtTestingToAddress.Text.Length > 0)
                        //    {
                        //        frm1.txtTestingToAddress.Text += ";";
                        //    }
                        //    frm1.txtTestingToAddress.Text += ConDetObj.ContactDetailValue;
                        //}

                        //frm1.txtTestSubject.Text = "Enquiry No: ( " + CurrentEnquiryObj.EnquiryID + "-" + CE.CurriculumEnquiryID + " ) Enquiry Feed Back";

                        //using (var Dbconnection = new MCDEntities())
                        //{

                        //    List<MessageTemplate> MT = (from a in Dbconnection.MessageTemplates
                        //                                from b in a.Files
                        //                                where a.ProcessStepID == (int)EnumProcessSteps.Enquiry__Apprenticeship__Step_1__Documentation_To_Send
                        //                                select a).ToList<MessageTemplate>();

                        //    MessageTemplate CurrentMessageTemplate = MT.FirstOrDefault<MessageTemplate>();
                        //    string Mess = "Good Day " + txtNewEnquiryTab_ContactPersonTitle.Text + " " + txtNewEnquiryTab_ContactPersonFirstName.Text + " " + txtNewEnquiryTab_ContactPersonLastName.Text + "\n \n";
                        //    frm1.txtTestMessage.Text = "Please Reference the Following Line Equiry Number when returning any documentation: \n" +
                        //                                "Enquiry No " + CE.EnquiryID + "-" + CE.CurriculumEnquiryID + "\n" + Mess + CurrentMessageTemplate.Message;
                        //    foreach (MessageTemplate MTObj in MT)
                        //    {
                        //        foreach (Data.Models.File FileObj in MTObj.Files)
                        //        {
                        //            frm1.AttachmentsUsingDbImageFileID.Add(FileObj.ImageID);
                        //        }
                        //    }

                    };
                    //frm1.ShowDialog();
                    using (var Dbconnection = new MCDEntities())
                    {
                        //EquiryHistory hist = new EquiryHistory
                        //{
                        //    EnquiryID = CE.EnquiryID,
                        //    EmployeeID = this.CurrentEmployeeLoggedIn.EmployeeID,
                        //    LookupEquiyHistoryTypeID = (int)EnumEquiryHistoryTypes.Enquiry_Initial_Documentation_Sent,
                        //    DateEnquiryUpdated = DateTime.Now,
                        //    EnquiryNotes = "Documentation Sent To Client Via Email"
                        //};
                        //Dbconnection.EquiryHistories.Add(hist);
                        //int IsSaved = Dbconnection.SaveChanges();
                        //if (IsSaved > 0)
                        //{
                        //    Dbconnection.CurriculumEnquiries.Attach(CE);
                        //    CE.InitialCurriculumEnquiryDocumentationSent = true;
                        //    CE.LastUpdated = DateTime.Now;
                        //    Dbconnection.Entry<CurriculumEnquiry>(CE).State = EntityState.Modified;
                        //    Dbconnection.SaveChanges();

                        //}
                        //dgvNewEnquiryTab_CurriculumEnquiry.Refresh();
                    };
                }
                else
                {

                    using (var Dbconnection = new MCDEntities())
                    {
                        //EquiryHistory hist = new EquiryHistory
                        //{
                        //    EnquiryID = CE.EnquiryID,
                        //    EmployeeID = this.CurrentEmployeeLoggedIn.EmployeeID,
                        //    LookupEquiyHistoryTypeID = (int)EnumEquiryHistoryTypes.Enquiry_Initial_Documentation_Sent,
                        //    DateEnquiryUpdated = DateTime.Now,
                        //    EnquiryNotes = "Documentation Manually Given To Client"
                        //};
                        //Dbconnection.EquiryHistories.Add(hist);
                        //int IsSaved = Dbconnection.SaveChanges();
                        //if (IsSaved > 0)
                        //{
                        //    Dbconnection.CurriculumEnquiries.Attach(CE);
                        //    CE.InitialCurriculumEnquiryDocumentationSent = true;
                        //    CE.LastUpdated = DateTime.Now;
                        //    Dbconnection.Entry<CurriculumEnquiry>(CE).State = EntityState.Modified;
                        //    Dbconnection.SaveChanges();
                        //    dgvNewEnquiryTab_CurriculumEnquiry.Refresh();
                        //}

                    };
                }
            };

        }
    }
}
