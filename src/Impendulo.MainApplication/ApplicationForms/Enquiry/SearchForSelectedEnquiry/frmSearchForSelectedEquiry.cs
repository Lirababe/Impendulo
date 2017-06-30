using Impendulo.Common.Enum;
using Impendulo.Data.Models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.Enquiry.Deployment.SearchForSelectedEnquiry
{
    public partial class frmSearchForSelectedEquiry : MetroForm
    {
        public frmSearchForSelectedEquiry()
        {
            InitializeComponent();
        }
        private int _SelectedEnquiryID = 0;
        public int SelectedEnquiryID { get { return _SelectedEnquiryID; } }

        private void frmSearchForSelectedEquiry_Load(object sender, EventArgs e)
        {
            //Resets the controls and loads the Comboboxes
            this.datFromDate.Text = DateTime.Now.ToString("D"); // DateTime.Now.Day + " " +DateTime.Now.Month + " "+ DateTime.Now.Year;
            this.resetAllSearchControls();
            this.refreshClientAutoCompleteDictonary();
            this.filterEnquiries();
        }

        private void refreshEquirySearchResults()
        {
            this.populateEquirySearchResults();
        }
        private void populateEquirySearchResults()
        {
            using (var Dbconnection = new MCDEntities())
            {
                //enquiryBindingSource.DataSource = (from a in Dbconnection.Enquiries.Find()
                //                                   where 
                //                                   )
            };
        }
        private void refreshClientAutoCompleteDictonary()
        {
            this.populateClientAutoCompleteDictonary();
        }
        private void populateClientAutoCompleteDictonary()
        {

            AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();
            AutoCompleteStringCollection allowedEnquiryID = new AutoCompleteStringCollection();

            List<Data.Models.Enquiry> x = new List<Data.Models.Enquiry>();

            using (var Dbconnection = new MCDEntities())
            {
                x = (from a in Dbconnection.Enquiries
                     select a)
                     .Include("Individuals")
                     .ToList<Data.Models.Enquiry>();


            };
            foreach (Data.Models.Enquiry EnquiryObj in x)
            {
                allowedEnquiryID.Add(EnquiryObj.EnquiryID.ToString());

                foreach (Individual IndividualObj in EnquiryObj.Individuals)
                {
                    allowedTypes.Add(IndividualObj.IndividualFirstName);
                }

            }

            txtContactName.AutoCompleteCustomSource = allowedTypes;
            txtContactName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtContactName.AutoCompleteSource = AutoCompleteSource.CustomSource;



            //txtEquiryRef.AutoCompleteCustomSource = allowedTypes;
            //txtContactName.AutoCompleteMode = AutoCompleteMode.Suggest;
            //txtContactName.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void refreshDepartments()
        {
            populateDepartments();
        }
        private void populateDepartments()
        {
            using (var Dbconnection = new MCDEntities())
            {
                lookupDepartmentBindingSource.DataSource = (from a in Dbconnection.LookupDepartments
                                                            orderby a.DepartmentName
                                                            select a)
                                                            .Include("Curriculums")
                                                            .ToList<LookupDepartment>();
            };
        }
        private void refreshCurriculum()
        {
            popluateCurriculums();
        }
        private void popluateCurriculums()
        {
            curriculumsBindingSource.DataSource = (from a in ((LookupDepartment)lookupDepartmentBindingSource.Current).Curriculums
                                                   select a).ToList<Curriculum>();

        }

        private void resetAllSearchControls()
        {
            this.txtEquiryRef.Clear();
            this.txtContactName.Clear();
            this.refreshDepartments();
            this.refreshCurriculum();
            this.chkUseDepartment.Checked = false;
            this.datToDate.Value = Common.CustomDateTime.getCustomDateTime(DateTime.Now, -10);
        }

        private void dgvEquirySearchResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                this._SelectedEnquiryID = ((Data.Models.Enquiry)dgvEquirySearchResults.Rows[e.RowIndex].DataBoundItem).EnquiryID;
                this.Close();
            }
        }





        private void lookupDepartmentBindingSource_PositionChanged(object sender, EventArgs e)
        {

            if (lookupDepartmentBindingSource.Count > 0)
            {
                this.refreshCurriculum();
            }

        }

        private void txtEquiryRef_KeyUp(object sender, KeyEventArgs e)
        {
            //if (txtEquiryRef.Text.Length > 0)
            //{
            //    this.disableAdvancedSearchControls();
            //}
            //else
            //{
            //    this.enableAdvancedSearchControls();
            //}
            filterEnquiries();
        }
        private void disableAdvancedSearchControls()
        {
            this.txtContactName.Enabled = false;
            this.cboDepartment.Enabled = false;
            this.cboCurriculum.Enabled = false;
            this.datToDate.Enabled = false;
        }
        private void enableAdvancedSearchControls()
        {
            this.txtContactName.Enabled = true;
            this.cboDepartment.Enabled = true;
            this.cboCurriculum.Enabled = true;
            this.datToDate.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.filterEnquiries();
        }
        private void filterEnquiries()
        {
            if (txtEquiryRef.Text.Length > 0)
            {

                using (var Dbconnection = new MCDEntities())
                {
                    int ID = Convert.ToInt32(txtEquiryRef.Text);
                    DateTime FromDate = Common.CustomDateTime.getCustomDateTime(datFromDate.Value, 0);
                    DateTime ToDAte = Common.CustomDateTime.getCustomDateTime(datToDate.Value, -1);
                    this.enquiryBindingSource.DataSource = (from a in Dbconnection.Enquiries
                                                            orderby a.EnquiryID descending
                                                            where a.EnquiryID == ID
                                                            select a)
                                                    //.Include("Individuals")
                                                    //.Include("Individuals.Companies")
                                                    //.Include("CurriculumEnquiries")
                                                    //.Include("CurriculumEnquiries.Curriculum")
                                                    .ToList<Data.Models.Enquiry>();
                };
            }
            else
            {
                DateTime FromDate = Common.CustomDateTime.getCustomDateTime(datFromDate.Value, 0);
                DateTime ToDAte = Common.CustomDateTime.getCustomDateTime(datToDate.Value, -1);
                int CurriculumID = 0;
                if (cboCurriculum.SelectedValue != null)
                {
                    CurriculumID = (Convert.ToInt32(cboCurriculum.SelectedValue));
                }

                List<Data.Models.Enquiry> AllEnquiry = new List<Data.Models.Enquiry>();
                List<Data.Models.Enquiry> FilteredEnquiry = new List<Data.Models.Enquiry>();

                using (var Dbconnection = new MCDEntities())
                {
                    if (radActiveEnquiry.Checked)
                    {
                        AllEnquiry = (from a in Dbconnection.Enquiries
                                      where a.EnquiryStatusID != (int)EnumEnquiryStatuses.Enquiry_Closed
                                      orderby a.EnquiryID descending
                                      select a).ToList<Data.Models.Enquiry>();
                    }
                    else
                    {
                        AllEnquiry = (from a in Dbconnection.Enquiries
                                      where a.EnquiryStatusID == (int)EnumEnquiryStatuses.Enquiry_Closed
                                      orderby a.EnquiryID descending
                                      select a).ToList<Data.Models.Enquiry>();
                    }



                    if (chkUseContactName.Checked)
                    {
                        foreach (Data.Models.Enquiry EnquiryObj in AllEnquiry)
                        {
                            Dbconnection.Entry(EnquiryObj).Collection(a => a.Individuals).Load();
                            foreach (Individual IndividualObj in EnquiryObj.Individuals)
                            {
                                if (!(Dbconnection.Entry(IndividualObj).Collection(a => a.Companies).IsLoaded))
                                {
                                    Dbconnection.Entry(IndividualObj).Collection(a => a.Companies).Load();
                                }
                            }
                            Dbconnection.Entry(EnquiryObj).Collection(a => a.CurriculumEnquiries).Load();
                            foreach (CurriculumEnquiry CE in EnquiryObj.CurriculumEnquiries)
                            {
                                Dbconnection.Entry(CE).Reference(a => a.Curriculum).Load();
                            }
                            //filters
                            foreach (Individual IndividualObj in EnquiryObj.Individuals)
                            {
                                if (IndividualObj.IndividualFirstName.Contains(txtContactName.Text) || IndividualObj.IndividualLastname.Contains(txtContactName.Text))
                                {
                                    FilteredEnquiry.Add(EnquiryObj);
                                }
                            }
                        }
                    }

                    if (chkUseDepartment.Checked)
                    {
                        foreach (Data.Models.Enquiry EnquiryObj in AllEnquiry)
                        {

                            if (!(Dbconnection.Entry(EnquiryObj).Collection(a => a.Individuals).IsLoaded))
                            {
                                Dbconnection.Entry(EnquiryObj).Collection(a => a.Individuals).Load();
                                foreach (Individual IndividualObj in EnquiryObj.Individuals)
                                {
                                    if (!(Dbconnection.Entry(IndividualObj).Collection(a => a.Companies).IsLoaded))
                                    {
                                        Dbconnection.Entry(IndividualObj).Collection(a => a.Companies).Load();
                                    }
                                }
                            }
                            if (!(Dbconnection.Entry(EnquiryObj).Collection(a => a.CurriculumEnquiries).IsLoaded))
                            {
                                Dbconnection.Entry(EnquiryObj).Collection(a => a.CurriculumEnquiries).Load();
                            }
                            foreach (CurriculumEnquiry CE in EnquiryObj.CurriculumEnquiries)
                            {
                                if (!(Dbconnection.Entry(CE).Reference(a => a.Curriculum).IsLoaded))
                                {
                                    Dbconnection.Entry(CE).Reference(a => a.Curriculum).Load();
                                }
                            }
                            foreach (CurriculumEnquiry CurriculumEnquiryObj in EnquiryObj.CurriculumEnquiries)
                            {
                                if (CurriculumEnquiryObj.CurriculumID == CurriculumID)
                                {
                                    FilteredEnquiry.Add(EnquiryObj);
                                }
                            }
                        }
                    }
                    if (chkUseDateFilter.Checked)
                    {

                        foreach (Data.Models.Enquiry EnquiryObj in AllEnquiry)
                        {
                            if (!(Dbconnection.Entry(EnquiryObj).Collection(a => a.Individuals).IsLoaded))
                            {
                                Dbconnection.Entry(EnquiryObj).Collection(a => a.Individuals).Load();
                                foreach (Individual IndividualObj in EnquiryObj.Individuals)
                                {
                                    if (!(Dbconnection.Entry(IndividualObj).Collection(a => a.Companies).IsLoaded))
                                    {
                                        Dbconnection.Entry(IndividualObj).Collection(a => a.Companies).Load();
                                    }
                                }
                            }
                            if (!(Dbconnection.Entry(EnquiryObj).Collection(a => a.CurriculumEnquiries).IsLoaded))
                            {
                                Dbconnection.Entry(EnquiryObj).Collection(a => a.CurriculumEnquiries).Load();
                            }
                            foreach (CurriculumEnquiry CE in EnquiryObj.CurriculumEnquiries)
                            {
                                if (!(Dbconnection.Entry(CE).Reference(a => a.Curriculum).IsLoaded))
                                {
                                    Dbconnection.Entry(CE).Reference(a => a.Curriculum).Load();
                                }
                            }
                            if (EnquiryObj.EnquiryDate <= FromDate && EnquiryObj.EnquiryDate >= ToDAte)
                            {
                                FilteredEnquiry.Add(EnquiryObj);
                            }
                        }
                    }
                    if ( chkUseContactName.Checked == false && chkUseDateFilter.Checked == false && chkUseDepartment.Checked == false)
                    {
                        FilteredEnquiry = AllEnquiry.ToList();
                    }
                    this.enquiryBindingSource.DataSource = FilteredEnquiry.Distinct().ToList();
                };

            }

        }

        private void dgvAssociatedEquiryCurriculum_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var CurriculumEnquiryObj = (CurriculumEnquiry)(row.DataBoundItem);
                    row.Cells[ColCurriculumName.Index].Value = CurriculumEnquiryObj.Curriculum.CurriculumName.ToString();

                }
            }
        }

        private void dgvClientFullName_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    Individual IndividualObj = (Individual)(row.DataBoundItem);

                    //if (IndividualObj.Companies == null)
                    //{
                    //    using (var Dbconnection = new MCDEntities())
                    //    {
                    //        Dbconnection.Configuration.LazyLoadingEnabled = false;
                    //        Dbconnection.Individuals.Attach(IndividualObj);
                    //        Dbconnection.Entry(IndividualObj).Collection(a => a.Companies).Load();
                    //    };
                    //}
                    //if (IndividualObj.Companies != null)
                    //{
                    if (IndividualObj.Companies.Count > 0)
                    {
                        row.Cells[colContactCompany.Index].Value = IndividualObj.Companies.FirstOrDefault().CompanyName.ToString();
                    }
                    else
                    {
                        row.Cells[colContactCompany.Index].Value = "NA - Private Client";
                    }
                    //}



                }
            }
        }

        private void datToDate_ValueChanged(object sender, EventArgs e)
        {
            if (datToDate.Value >= Common.CustomDateTime.getCustomDateTime(datFromDate.Value, 0))
            {
                datToDate.Value = Common.CustomDateTime.getCustomDateTime(datFromDate.Value, -1);
            }
            // this.filterEnquiries();
        }

        private void txtEquiryRef_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void datFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (datFromDate.Value <= datToDate.Value)
            {
                datToDate.Value = Common.CustomDateTime.getCustomDateTime(datFromDate.Value, -10);
            }
            //this.filterEnquiries();
        }

        private void chkUseDepartment_CheckedChanged(object sender, EventArgs e)
        {
            filterEnquiries();

        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterEnquiries();
        }

        private void cboCurriculum_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterEnquiries();
        }



        private void btnRefreshSearch_Click(object sender, EventArgs e)
        {
            this.resetAllSearchControls();
            this.enableAdvancedSearchControls();
            this.chkUseContactName.Checked = false;
            this.chkUseDateFilter.Checked = false;
            this.chkUseDepartment.Checked = false;
            this.filterEnquiries();
        }

        private void chkUseContactName_CheckedChanged(object sender, EventArgs e)
        {
            txtEquiryRef.Clear();
            if (chkUseContactName.Checked)
            {
                // filterEnquiries();
            }
            else
            {
                this.resetAllSearchControls();
                this.enableAdvancedSearchControls();
                this.filterEnquiries();
            }
        }



        private void chkUseDepartment_CheckedChanged_1(object sender, EventArgs e)
        {
            txtEquiryRef.Clear();
            if (chkUseDepartment.Checked)
            {
                // filterEnquiries();
            }
            else
            {
                this.resetAllSearchControls();
                this.enableAdvancedSearchControls();
                this.filterEnquiries();
            }
        }

        private void chkUseDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            txtEquiryRef.Clear();
            if (chkUseDateFilter.Checked)
            {
                //filterEnquiries();
            }
            else
            {
                this.resetAllSearchControls();
                this.enableAdvancedSearchControls();
                this.filterEnquiries();
            }
        }

        private void dgvEquirySearchResults_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    Data.Models.Enquiry EnquiryObj = (Data.Models.Enquiry)(row.DataBoundItem);
                    row.Cells[colEnquiryStatus.Index].Value = EnquiryObj.LookupEnquiryStatus.EnquiryStatus.ToString();
                }
            }
        }

        private void radActiveEnquiry_CheckedChanged(object sender, EventArgs e)
        {
            filterEnquiries();
        }

        private void radClosedEnquiry_CheckedChanged(object sender, EventArgs e)
        {
            filterEnquiries();
        }
    }
}
/*
 *  if (txtEquiryRef.Text.Length > 0)
            {

                using (var Dbconnection = new MCDEntities())
                {
                    Dbconnection.Configuration.LazyLoadingEnabled = false;
                    int ID = Convert.ToInt32(txtEquiryRef.Text);
                    //List<Data.Models.Enquiry> lst = new List<Data.Models.Enquiry>();

                    //lst = (from a in Dbconnection.Enquiries
                    //       orderby a.EnquiryID descending
                    //       where a.EnquiryID == ID
                    //       select a).ToList<Data.Models.Enquiry>();
                    ////filter out closed enquiries.
                    //List<CurriculumEnquiry> DataSourceList;
                    //foreach (Data.Models.Enquiry E in lst)
                    //{
                    //    DataSourceList = new List<CurriculumEnquiry>();
                    //    foreach (CurriculumEnquiry CE in E.CurriculumEnquiries)
                    //    {
                    //        if (CE.EnquiryStatusID != (int)EnumEnquiryStatuses.Enquiry_Closed)
                    //        {
                    //            DataSourceList.Add(CE);
                    //        }
                    //    }
                    //    E.CurriculumEnquiries.Clear();
                    //    foreach (CurriculumEnquiry CE in DataSourceList)
                    //    {
                    //        E.CurriculumEnquiries.Add(CE);
                    //    }
                    //}
                    DateTime FromDate = Common.CustomDateTime.getCustomDateTime(datFromDate.Value, 0);
                    DateTime ToDAte = Common.CustomDateTime.getCustomDateTime(datToDate.Value, -1);
                    //this.enquiryBindingSource.DataSource = Dbconnection.Enquiries.Find(Convert.ToInt32(txtEquiryRef.Text));
                    this.enquiryBindingSource.DataSource = (from a in Dbconnection.Enquiries
                                                                //from b in a.CurriculumEnquiries
                                                            orderby a.EnquiryID descending
                                                            where a.EnquiryID == ID
                                                            && (a.EnquiryDate <= FromDate && a.EnquiryDate >= ToDAte)
                                                            && a.EnquiryStatusID != (int)EnumEnquiryStatuses.Enquiry_Closed
                                                            select a)
                                                           //.Include("Individuals")
                                                           //.Include("Individuals.Companies")
                                                           //.Include("CurriculumEnquiries")
                                                           //.Include("CurriculumEnquiries.Curriculum")
                                                           .ToList<Data.Models.Enquiry>();
                };
            }
            else
            {
                int DepartmentID = (Convert.ToInt32(cboDepartment.SelectedValue));
                int CurriculumID = (Convert.ToInt32(cboCurriculum.SelectedValue));
                DateTime dtFilterDate = Common.CustomDateTime.getCustomDateTime(datToDate.Value, -1);

                using (var Dbconnection = new MCDEntities())
                {
                    Dbconnection.Configuration.LazyLoadingEnabled = false;
                    if (chkUseDepartment.Checked)
                    {

                        DateTime FromDate = Common.CustomDateTime.getCustomDateTime(datFromDate.Value, 0);
                        DateTime ToDAte = Common.CustomDateTime.getCustomDateTime(datToDate.Value, -1);
                        List<Data.Models.Enquiry> lstEnquiry = (from a in Dbconnection.Enquiries
                                                                where
                                                                  (a.EnquiryDate <= FromDate && a.EnquiryDate >= ToDAte)
                                                                orderby a.EnquiryID descending
                                                                select a)
                                                           //.Include("Individuals")
                                                           //.Include("Individuals.Companies")
                                                           //.Include("CurriculumEnquiries")
                                                           //.Include("CurriculumEnquiries.Curriculum")
                                                           .ToList<Data.Models.Enquiry>();

                        List<Data.Models.Enquiry> EnquiriesFilteredByName = new List<Data.Models.Enquiry>();
                        foreach (Data.Models.Enquiry EnquiryObj in lstEnquiry)
                        {
                            foreach (Individual IndividualObj in EnquiryObj.Individuals)
                            {
                                if (IndividualObj.IndividualFirstName.Contains(txtContactName.Text) || IndividualObj.IndividualLastname.Contains(txtContactName.Text))
                                {
                                    EnquiriesFilteredByName.Add(EnquiryObj);
                                }
                            }
                        }
                        List<Data.Models.Enquiry> EnquiriesFiltereDepartmentAndCurriculum = new List<Data.Models.Enquiry>();
                        foreach (Data.Models.Enquiry EnquiryObj in lstEnquiry)
                        {
                            foreach (CurriculumEnquiry CurriculumEnquiryObj in EnquiryObj.CurriculumEnquiries)
                            {
                                if (CurriculumEnquiryObj.CurriculumID == CurriculumID)
                                {
                                    EnquiriesFiltereDepartmentAndCurriculum.Add(EnquiryObj);
                                }
                            }
                        }
                        List<Data.Models.Enquiry> lstFilteredListOfEnquiry = new List<Data.Models.Enquiry>();

                        lstFilteredListOfEnquiry.AddRange(EnquiriesFilteredByName);
                        lstFilteredListOfEnquiry.AddRange(EnquiriesFiltereDepartmentAndCurriculum);
                        this.enquiryBindingSource.DataSource = (from a in lstFilteredListOfEnquiry
                                                                where a.EnquiryStatusID != (int)EnumEnquiryStatuses.Enquiry_Closed
                                                                orderby a.EnquiryID descending
                                                                select a)
                                                                .Distinct<Data.Models.Enquiry>()
                                                                .ToList<Data.Models.Enquiry>();
                    }

                    //    this.enquiryBindingSource.DataSource = (from a in Dbconnection.Enquiries
                    //                                            from b in a.Individuals
                    //                                            from c in a.CurriculumEnquiries
                    //                                            where
                    //                                              (a.EnquiryDate <= Common.CustomDateTime.getCustomDateTime(datFromDate.Value, 0) && a.EnquiryDate >= Common.CustomDateTime.getCustomDateTime(datToDate.Value, -1))
                    //                                              &&
                    //                                               (b.IndividualFirstName.Contains(txtContactName.Text) ||
                    //                                                b.IndividualLastname.Contains(txtContactName.Text))
                    //                                                && c.Curriculum.DepartmentID == DepartmentID
                    //                                                && c.CurriculumID == CurriculumID
                    //                                            orderby a.EnquiryID descending
                    //                                            select a)
                    //                                           .Include("Individuals")
                    //                                           .Include("Individuals.Companies")
                    //                                           .Include("CurriculumEnquiries")
                    //                                           .Include("CurriculumEnquiries.Curriculum")
                    //                                           .ToList<Data.Models.Enquiry>();
                    //}
                    else
                    {
                        DateTime FromDate = Common.CustomDateTime.getCustomDateTime(datFromDate.Value, 0);
                        DateTime ToDAte = Common.CustomDateTime.getCustomDateTime(datToDate.Value, -1);
                        List<Data.Models.Enquiry> lstEnquiry = (from a in Dbconnection.Enquiries
                                                                where
                                                                   (a.EnquiryDate <= FromDate && a.EnquiryDate >= ToDAte)
                                                                orderby a.EnquiryID descending
                                                                select a)
                                                           //.Include("Individuals")
                                                           //.Include("Individuals.Companies")
                                                           //.Include("CurriculumEnquiries")
                                                           //.Include("CurriculumEnquiries.Curriculum")
                                                           .ToList<Data.Models.Enquiry>();

                        List<Data.Models.Enquiry> EnquiriesFilteredByName = new List<Data.Models.Enquiry>();

                        foreach (Data.Models.Enquiry EnquiryObj in lstEnquiry)
                        {
                            Dbconnection.Entry(EnquiryObj).Collection(a => a.Individuals).Load();
                            Dbconnection.Entry(EnquiryObj).Collection(a => a.CurriculumEnquiries).Load();
                            foreach (CurriculumEnquiry CE in EnquiryObj.CurriculumEnquiries)
                            {
                                Dbconnection.Entry(CE).Reference(a => a.Curriculum).Load();
                            }
                            //Dbconnection.Entry(EnquiryObj).Collection(a => a.CurriculumEnquiries)..Load();

                            foreach (Individual IndividualObj in EnquiryObj.Individuals)
                            {
                                if (IndividualObj.IndividualFirstName.Contains(txtContactName.Text) || IndividualObj.IndividualLastname.Contains(txtContactName.Text))
                                {
                                    EnquiriesFilteredByName.Add(EnquiryObj);
                                }
                            }
                        }
                        List<Data.Models.Enquiry> lstFilteredListOfEnquiry = new List<Data.Models.Enquiry>();

                        lstFilteredListOfEnquiry.AddRange(EnquiriesFilteredByName);

                        this.enquiryBindingSource.DataSource = (from a in lstFilteredListOfEnquiry
                                                                where a.EnquiryStatusID != (int)EnumEnquiryStatuses.Enquiry_Closed
                                                                orderby a.EnquiryID descending
                                                                select a)
                                                          .ToList<Data.Models.Enquiry>();
                        //this.enquiryBindingSource.DataSource = (from a in Dbconnection.Enquiries
                        //                                        from b in a.Individuals
                        //                                        where
                        //                                           (a.EnquiryDate <= Common.CustomDateTime.getCustomDateTime(datFromDate.Value, 0) && a.EnquiryDate >= Common.CustomDateTime.getCustomDateTime(datToDate.Value, -1))
                        //                                          &&
                        //                                           (b.IndividualFirstName.Contains(txtContactName.Text) ||
                        //                                            b.IndividualLastname.Contains(txtContactName.Text))

                        //                                        orderby a.EnquiryID descending
                        //                                        select a)
                        //                                   .Include("Individuals")
                        //                                   .Include("Individuals.Companies")
                        //                                   .Include("CurriculumEnquiries")
                        //                                   .Include("CurriculumEnquiries.Curriculum")
                        //                                   .ToList<Data.Models.Enquiry>();
                    }

                };
            }
*/
