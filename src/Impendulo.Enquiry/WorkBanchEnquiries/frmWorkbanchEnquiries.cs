using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impendulo.Data.Models;
using Impendulo.Common.Enum;

namespace Impendulo.Enquiry.Development.WorkBanchEnquiries
{
    public partial class frmWorkbanchEnquiries : Form
    {
        public frmWorkbanchEnquiries()
        {
            InitializeComponent();
        }

        private void frmWorkbanchEnquiries_Load(object sender, EventArgs e)
        {
            /*set date parameters*/
            DateTime Todaydate = DateTime.Now;
            Todaydate.Month.ToString("D");
            lbCurrentDateTime.Text = Todaydate.ToShortDateString();
            dtpFrom.Value = new DateTime(Todaydate.Year, Todaydate.Month, 1);
            dtpTo.Value = new DateTime(Todaydate.Year, Todaydate.Month, 1).AddMonths(1).AddDays(-1);
            /*load queries*/
            LoadItems(dtpFrom.Value, dtpTo.Value, EnumDepartments.Apprenticeship);
        }
        /// <summary>
        ///retruns date into the future or in to be past by a set amount of days excluding Saturday and Sunday.
        /// </summary>
        /// <param name="CurrentDate"></param>
        /// <param name="AmountDaysToAdd"></param>
        /// <returns></returns>
        
        private void LoadItems(DateTime FromDate, DateTime Todate, EnumDepartments aDepartment)
        {
            using (var Dbconnection = new MCDEntities())
            {
                lblEquiyTotalEquiry.Text = (from a in Dbconnection.Enquiries
                                                /*Include Sections */
                                            from b in a.CurriculumEnquiries
                                                /* Where Sections */
                                            where
                                                 /*Filters*/
                                                 (a.EnquiryDate >= FromDate &&
                                                  a.EnquiryDate <= Todate) &&
                                                  //Sections
                                                  b.Curriculum.DepartmentID == (int)aDepartment
                                            select a)
                                         /*Aggregation*/
                                         .Count<Data.Models.Enquiry>().ToString();
                //new enquiries
                lblNewEnquiry.Text = (from a in Dbconnection.Enquiries
                                      from b in a.CurriculumEnquiries
                                      where 
                                     // a.InitialConsultationComplete == false &&
                                      b.LookupEnquiryStatus.EnquiryStatusID == (int)EnumEnquiryStatuses.New
                                      && a.EnquiryDate >= FromDate && a.EnquiryDate <= Todate &&
                                      b.Curriculum.DepartmentID == (int)aDepartment
                                      select a).Count<Data.Models.Enquiry>().ToString();

                //Over due enquiries
                //I created the CustomerDateTime static classs inside impendulo.Common
                DateTime queryDatetime = Impendulo.Common.CustomerDateTime.CustomerDateTime.getCustomDateTime(DateTime.Now, -4);
                //DateTime queryDatetime = getCustDateTime(DateTime.Now, -4);
                lblOverDueEnquiries.Text = (from a in Dbconnection.Enquiries
                                            from b in a.CurriculumEnquiries
                                            where
                                            //Enquiriesw are deemed Over Due if not responded to with in 3 Working Days
                                            a.EnquiryDate <= queryDatetime &&
                                            b.EnquiryStatusID != (int)EnumEnquiryStatuses.Enquiry_Closed &&
                                            b.Curriculum.DepartmentID == (int)aDepartment
                                            select a).Count<Data.Models.Enquiry>().ToString();

                //company enquiries
                lblCompanyEnquiry.Text = (from a in Dbconnection.Enquiries
                                          from b in a.Companies
                                          join c in Dbconnection.Companies on b.CompanyID equals c.CompanyID
                                          where a.EnquiryID == a.EnquiryID && a.EnquiryDate >= FromDate && a.EnquiryDate <= Todate
                                          select a).Count<Data.Models.Enquiry>().ToString();

                //Private enquiries
                lblPrivateEquiries.Text = (from a in Dbconnection.Enquiries
                                           from b in a.Individuals
                                           join c in Dbconnection.Individuals on b.IndividualID equals c.IndividualID
                                           where a.EnquiryID == a.EnquiryID && a.EnquiryDate >= FromDate && a.EnquiryDate <= Todate
                                           select a).Count<Data.Models.Enquiry>().ToString();
            }


        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            LoadItems(dtpFrom.Value, dtpTo.Value, EnumDepartments.Apprenticeship);
        }
        /// <summary>
        /// Date Added 24 May 2017
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApprenticeshipFilterSearch_Click(object sender, EventArgs e)
        {
            LoadItems(dtpFrom.Value, dtpTo.Value, EnumDepartments.Apprenticeship);
        }
    }
}
