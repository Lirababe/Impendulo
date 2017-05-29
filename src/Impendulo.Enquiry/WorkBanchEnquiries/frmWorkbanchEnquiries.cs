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
    /*
     * How to data bind and create chart control with entity framework
     * https://www.codeproject.com/Articles/221931/Entity-Framework-in-WinForms
     * *****************************************************************/
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
            rbEnquiryByMonth.Checked = true;
            this.fillChart();

        }

        /// <summary>
        ///retruns date into the future or in to be past by a set amount of days excluding Saturday and Sunday.
        /// </summary>
        /// <param name="CurrentDate"></param>
        /// <param name="AmountDaysToAdd"></param>
        /// <returns></returns>
        private void LoadItems(DateTime FromDate, DateTime Todate, EnumDepartments aDepartment)
        {
            lblEquiyTotalEquiry.Text = getAllEnquiry(FromDate, Todate, aDepartment).Count.ToString();

            lblNewEnquiry.Text = GetNewEquiry(FromDate, Todate, aDepartment).Count.ToString();

            lblOverDueEnquiries.Text = GetOverDueEnquiry(FromDate, Todate, aDepartment).Count.ToString();

            lblCompanyEnquiry.Text = getCompanyEnquiry(FromDate, Todate, aDepartment).Count.ToString();

            lblPrivateEquiries.Text = getPrivateEnquiry(FromDate, Todate, aDepartment).Count.ToString();

        }
        /// <summary>
        ///  Get a list of equiry Object  -Amount of equiry for the period defined by the dates.
        /// </summary>
        /// <param name="FromDate"></param>
        /// <param name="Todate"></param>
        /// <param name="aDepartment"></param>
        /// <returns>List of Equiry Objects</returns>
        private List<Data.Models.Enquiry> getAllEnquiry(DateTime FromDate, DateTime Todate, EnumDepartments aDepartment)
        {
            List<Data.Models.Enquiry> Rtn = new List<Data.Models.Enquiry>();
            using (var Dbconnection = new MCDEntities())
            {
                Rtn = (from a in Dbconnection.Enquiries
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
                                         .ToList<Data.Models.Enquiry>();
            };
            return Rtn;
        }
        
        private List<Data.Models.Enquiry> getCompanyEnquiry(DateTime FromDate, DateTime Todate, EnumDepartments aDepartment)
        {
            List<Data.Models.Enquiry> Rtn = new List<Data.Models.Enquiry>();
            using (var Dbconnection = new MCDEntities())
            {
                //company enquiries
                //lblCompanyEnquiry.Text
                Rtn = (from a in Dbconnection.Enquiries
                                          from b in a.Companies
                                          join c in Dbconnection.Companies on b.CompanyID equals c.CompanyID
                                          where a.EnquiryID == a.EnquiryID && a.EnquiryDate >= FromDate && a.EnquiryDate <= Todate
                                          select a).ToList<Data.Models.Enquiry>();
            }
            return Rtn;
        }

        private List<Data.Models.Enquiry> getPrivateEnquiry(DateTime FromDate, DateTime Todate, EnumDepartments aDepartment)
        {
            List<Data.Models.Enquiry> Rtn = new List<Data.Models.Enquiry>();
            using (var Dbconnection = new MCDEntities())
            {
                //lblPrivateEquiries.Text 
                Rtn = (from a in Dbconnection.Enquiries
                       from b in a.Individuals
                       join c in Dbconnection.Individuals on b.IndividualID equals c.IndividualID
                       where a.EnquiryID == a.EnquiryID && a.EnquiryDate >= FromDate && a.EnquiryDate <= Todate
                       select a).ToList<Data.Models.Enquiry>();
            }

            return Rtn;
        }

        /// <summary>
        /// Get a list of equiry Object  - Only the new one for the period defined by the dates.
        /// </summary>
        /// <param name="FromDate"></param>
        /// <param name="Todate"></param>
        /// <param name="aDepartment"></param>
        /// <returns>>List of Equiry Objects</returns>
        private List<Data.Models.Enquiry> GetNewEquiry(DateTime FromDate, DateTime Todate, EnumDepartments aDepartment)
        {
            List<Data.Models.Enquiry> Rtn = new List<Data.Models.Enquiry>();
            using (var Dbconnection = new MCDEntities())
            {
                Rtn = (from a in Dbconnection.Enquiries
                       from b in a.CurriculumEnquiries
                       where
                       // a.InitialConsultationComplete == false &&
                       b.LookupEnquiryStatus.EnquiryStatusID == (int)EnumEnquiryStatuses.New
                       && a.EnquiryDate >= FromDate && a.EnquiryDate <= Todate &&
                       b.Curriculum.DepartmentID == (int)aDepartment
                       select a).ToList<Data.Models.Enquiry>();
            };

            return Rtn;
        }

        private List<Data.Models.Enquiry> GetOverDueEnquiry(DateTime FromDate, DateTime Todate, EnumDepartments aDepartment)
        {
            List<Data.Models.Enquiry> Rtn = new List<Data.Models.Enquiry>();

            using (var Dbconnection = new MCDEntities())
            {
                //I created the CustomerDateTime static classs inside impendulo.Common
                DateTime queryDatetime = Impendulo.Common.CustomerDateTime.CustomerDateTime.getCustomDateTime(DateTime.Now, -4);
                //DateTime queryDatetime = getCustDateTime(DateTime.Now, -4);
                Rtn = (from a in Dbconnection.Enquiries
                                            from b in a.CurriculumEnquiries
                                            where
                                            //Enquiriesw are deemed Over Due if not responded to with in 3 Working Days
                                            a.EnquiryDate <= queryDatetime &&
                                            b.EnquiryStatusID != (int)EnumEnquiryStatuses.Enquiry_Closed &&
                                            b.Curriculum.DepartmentID == (int)aDepartment
                                            select a).ToList<Data.Models.Enquiry>();
            };
            //Over due enquiries
           
            return Rtn;
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

        private void fillChart()
        {
            using (var Dbconnection = new MCDEntities())
            {
                //Im creating a List of Enquiries
                
                List<Impendulo.Data.Models.Enquiry> lst = (from a in Dbconnection.Enquiries
                                                           select a).ToList<Impendulo.Data.Models.Enquiry>();
                
                //Filling the chart
                chart1.DataSource = lst;
                chart1.Series["Series1"].XValueMember = "EnquiryDate";

                //The YValueMember should be the number of Enquiries not the EnquiryID, the EnquiryID was to check if the code would work
                chart1.Series["Series1"].YValueMembers = "EnquiryID";

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbNewEnquiryByMonth_CheckedChanged(object sender, EventArgs e)
        {
            this.NewEnquiryByMonth();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbAmountOfPrivateVSCompanyEnquiriesPerMonth_CheckedChanged(object sender, EventArgs e)
        {
            this.AmountOfPrivateVSCompanyEnquiriesPerMonth();
        }

        private void rbEnquiryByMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEnquiryByMonth.Checked == true)
            {
                lblGraphTitle.Text = "ENQUIRY BY MONTH";
                //this.fillChart();
            }
        }

        
        private void NewEnquiryByMonth()
        {
            if (rbNewEnquiryByMonth.Checked == true)
            {
                lblGraphTitle.Text = "NEW ENQUIRY BY MONTH";
               //Update the chart
            }
        }

        private void AmountOfPrivateVSCompanyEnquiriesPerMonth()
        {
            if (rbAmountOfPrivateVSCompanyEnquiriesPerMonth.Checked == true)
            {
                lblGraphTitle.Text = "AMOUNT OF PRIVATE VS COMPANY ENQUIRIES";
                //Update the chart

            }
        }
    }
}
