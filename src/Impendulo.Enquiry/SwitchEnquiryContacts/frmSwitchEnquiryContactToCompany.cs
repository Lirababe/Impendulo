using Impendulo.Company.SearchForCompany.Development;
using Impendulo.Data.Models;
using MetroFramework;
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

namespace Impendulo.Enquiry.Development.SwitchEnquiryContacts
{
    public partial class frmSwitchEnquiryContactToCompany : MetroForm
    {
        public int StudentID { get; set; }
        public Data.Models.Enquiry CurrentEnquiry { get; set; }
        public frmSwitchEnquiryContactToCompany()
        {
            InitializeComponent();
            StudentID = 0;
        }

        private void frmSwitchEnquiryContactToCompany_Load(object sender, EventArgs e)
        {
        }

        private void btnCompanySearch_Click(object sender, EventArgs e)
        {
            //Select Company from Search Form
            frmCompanySearch frm = new frmCompanySearch();
            frm.ShowDialog();

            //check if Current Company is nit null means that a company was selected.
            if (frm.CurrentCompany != null)
            {

                using (var Dbconnection = new MCDEntities())
                {
                    //Select-Get Current Student.
                    Student CurrentStudent = (from a in Dbconnection.Students
                                              where a.StudentID == this.StudentID
                                              select a).FirstOrDefault<Student>();
                    if (CurrentStudent != null)
                    {
                        Boolean PreviouslyAssociatedWithCompany = false;
                        //Determines if the company selected has bee associated with the student in the past
                        if (CurrentStudent.StudentAssociatedCompanies.Count > 0)
                        {
                            foreach (StudentAssociatedCompany CompanyStatusToUpdate in CurrentStudent.StudentAssociatedCompanies)
                            {
                                CompanyStatusToUpdate.IsCurrentCompany = false;
                                if (CompanyStatusToUpdate.StudentID == this.StudentID && CompanyStatusToUpdate.CompanyID == frm.CurrentCompany.CompanyID)
                                {
                                    PreviouslyAssociatedWithCompany = true;
                                    CompanyStatusToUpdate.IsCurrentCompany = true;
                                }
                            }
                        }
                        DialogResult Rtn = MetroMessageBox.Show(this, MetroMessageBox.Show(this, "Are You Sure you wish to link " + CurrentStudent.Individual.FullName + " To - " + frm.CurrentCompany.CompanyName, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).ToString());
                        if (Rtn == DialogResult.Yes)
                        {
                            if (PreviouslyAssociatedWithCompany)
                            {
                                Dbconnection.SaveChanges();
                            }
                            else
                            {
                                CurrentStudent.StudentAssociatedCompanies.Add(new StudentAssociatedCompany
                                {
                                    CompanyID = frm.CurrentCompany.CompanyID,
                                    StudentID = CurrentStudent.StudentID,
                                    IsCurrentCompany = true
                                });
                                Dbconnection.SaveChanges();
                            }
                        }

                        //this.refreshStudentCompany();
                    }

                };
            }
        }

    }
}
