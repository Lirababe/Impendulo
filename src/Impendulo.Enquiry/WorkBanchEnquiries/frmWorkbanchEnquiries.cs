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

            this.enquiriesByMonth(dtpFrom.Value, dtpTo.Value, EnumDepartments.Apprenticeship);

            rbEnquiryByMonth.Checked = true;
           

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
            //LoadItems(dtpFrom.Value, dtpTo.Value, EnumDepartments.Apprenticeship);
            //fillChart();
        }
        /// <summary>
        /// Date Added 24 May 2017
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApprenticeshipFilterSearch_Click(object sender, EventArgs e)
        {
            LoadItems(dtpFrom.Value, dtpTo.Value, EnumDepartments.Apprenticeship);
            fillChart(dtpFrom.Value, dtpTo.Value, EnumDepartments.Apprenticeship);
        }

        private void fillChart(DateTime FromDate, DateTime Todate, EnumDepartments aDepartment)
        {
            using (var Dbconnection = new MCDEntities())
            {
                /*Notice that i have assigned the YValueMembers with the same name as the field that i created in the Anonymous class flied Name:
                 * match the numbers to referfence what i mean
                 * 1.1 YValueMembers =  AmountOfEnquiries is the same as the field name that i created in the anonymous class field name.
                 * 
                 * */
                chart1.Series["Series1"].YValueMembers = "AmountOfEnquiries";   //1.1 HERE MAtch the Class Field Name Below.
                chart1.Series["Series1"].XValueMember = "Date";                 //1.2 HERE MAtch the Class Field Name Below.

                //count enquiries made at a specific date
                var enquiriesByDate = (from a in Dbconnection.Enquiries
                                       from b in a.CurriculumEnquiries
                                       where a.EnquiryID != 1 //&& a.EnquiryDate >= FromDate && a.EnquiryDate <= Todate && b.Curriculum.DepartmentID == (int)aDepartment

                                      // where a.EnquiryID != 1 && a.EnquiryDate >= FromDate && a.EnquiryDate <= Todate && b.Curriculum.DepartmentID == (int)aDepartment

                                       group a by a.EnquiryDate into b
                                       select new
                                       {
                                           Date = b.Key,                            //1.1 - Same field name "Date" as above SEE 1.1 ABOVE( I made the field name up - the Fieldname is the same as above.)//1.1 - Same field name as above( I made the field name up - the Fieldname is the same as above.
                                           AmountOfEnquiries = b.Distinct().Count() //1.2 - Same field name "AmountOfEnquiries" as above SEE 1.2 ABOVE( I made the field name up - the Fieldname is the same as above.)
                                       });
                //filling the chart
                enquiryBindingSource.DataSource = enquiriesByDate.ToList();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbNewEnquiryByMonth_CheckedChanged(object sender, EventArgs e)
        {
            this.NewEnquiryByMonth(dtpFrom.Value, dtpTo.Value, EnumDepartments.Apprenticeship);
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbAmountOfPrivateVSCompanyEnquiriesPerMonth_CheckedChanged(object sender, EventArgs e)
        {
            this.AmountOfPrivateVSCompanyEnquiriesPerMonth(dtpFrom.Value, dtpTo.Value, EnumDepartments.Apprenticeship);
        }

        private void rbEnquiryByMonth_CheckedChanged(object sender, EventArgs e)
        {
            this.enquiriesByMonth(dtpFrom.Value, dtpTo.Value, EnumDepartments.Apprenticeship);
        }

        private void enquiriesByMonth(DateTime FromDate, DateTime Todate, EnumDepartments aDepartment)
        {
            if (rbEnquiryByMonth.Checked == true)
            {
                lblGraphTitle.Text = "ENQUIRY BY MONTH";
                this.fillChart(dtpFrom.Value, dtpTo.Value, EnumDepartments.Apprenticeship);
            }
        }

        private void NewEnquiryByMonth(DateTime FromDate, DateTime Todate, EnumDepartments aDepartment)
        {
            if (rbNewEnquiryByMonth.Checked == true)
            {
                lblGraphTitle.Text = "NEW ENQUIRY BY MONTH";
                //Update the chart
                chart1.BackColor = System.Drawing.Color.Gray;
                using (var Dbconnection = new MCDEntities())
                {
                    chart1.Series["Series1"].YValueMembers = "AmountOfEnquiries";   //1.1 HERE MAtch the Class Field Name Below.
                    chart1.Series["Series1"].XValueMember = "Date";                 //1.2 HERE MAtch the Class Field Name Below.

                    //count enquiries made at a specific date
                    var enquiriesByDate = (from a in Dbconnection.Enquiries
                                           from b in a.CurriculumEnquiries
                                           where a.EnquiryID != 1 //&& a.EnquiryDate >= FromDate && a.EnquiryDate <= Todate && b.Curriculum.DepartmentID == (int)aDepartment
                                           //&& b.LookupEnquiryStatus.EnquiryStatusID == (int)EnumEnquiryStatuses.New
                                           group a by a.EnquiryDate into b
                                           select new
                                           {
                                               Date = b.Key,                            //1.1 - Same field name "Date" as above SEE 1.1 ABOVE( I made the field name up - the Fieldname is the same as above.)//1.1 - Same field name as above( I made the field name up - the Fieldname is the same as above.
                                               AmountOfEnquiries = b.Distinct().Count() //1.2 - Same field name "AmountOfEnquiries" as above SEE 1.2 ABOVE( I made the field name up - the Fieldname is the same as above.)
                                           });


                    //filling the chart
                    enquiryBindingSource.DataSource = enquiriesByDate.ToList();
                }
            }
        }

        private void AmountOfPrivateVSCompanyEnquiriesPerMonth(DateTime FromDate, DateTime Todate, EnumDepartments aDepartment)
        {
            if (rbAmountOfPrivateVSCompanyEnquiriesPerMonth.Checked == true)
            {
                lblGraphTitle.Text = "AMOUNT OF PRIVATE VS COMPANY ENQUIRIES";
                //Update the chart
                
                using (var Dbconnection = new MCDEntities())
                {
                    chart1.Series["Series1"].YValueMembers = "AmountOfEnquiries";   //1.1 HERE MAtch the Class Field Name Below.
                    chart1.Series["Series1"].XValueMember = "Date";                 //1.2 HERE MAtch the Class Field Name Below
                    chart1.Series["series2"].YValueMembers = "AmountOfEnquiries";
                    chart1.Series["series2"].YValueMembers = "Date";

                    //count enquiries made at a specific date
                    var enquiriesByDate = (from a in Dbconnection.Enquiries
                                           from b in a.CurriculumEnquiries
                                           where a.EnquiryID != 1 //&& a.EnquiryDate >= FromDate && a.EnquiryDate <= Todate && b.Curriculum.DepartmentID == (int)aDepartment
                                           //&& b.LookupEnquiryStatus.EnquiryStatusID == (int)EnumEnquiryStatuses.New
                                           group a by a.EnquiryDate into b
                                           select new
                                           {
                                               Date = b.Key,                            //1.1 - Same field name "Date" as above SEE 1.1 ABOVE( I made the field name up - the Fieldname is the same as above.)//1.1 - Same field name as above( I made the field name up - the Fieldname is the same as above.
                                               AmountOfEnquiries = b.Distinct().Count() //1.2 - Same field name "AmountOfEnquiries" as above SEE 1.2 ABOVE( I made the field name up - the Fieldname is the same as above.)
                                           });


                    //filling the chart
                    enquiryBindingSource.DataSource = enquiriesByDate.ToList();
                }


            }
        }
    }
}
