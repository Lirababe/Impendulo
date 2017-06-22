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

namespace Impendulo.Enquiry.Development.SearchForSelectedEnquiry
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

            List<Individual> x = new List<Individual>();
            using (var Dbconnection = new MCDEntities())
            {
                x = (from a in Dbconnection.Enquiries
                     from b in a.Individuals
                     select b).ToList<Individual>();


            };
            foreach (Individual individ in x)
            {
                allowedTypes.Add(individ.IndividualFirstName);
            }

            txtContactName.AutoCompleteCustomSource = allowedTypes;
            txtContactName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtContactName.AutoCompleteSource = AutoCompleteSource.CustomSource;

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


        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.resetAllSearchControls();
            this.enableAdvancedSearchControls();
            this.filterEnquiries();
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
            if (txtEquiryRef.Text.Length > 0)
            {
                this.disableAdvancedSearchControls();
            }
            else
            {
                this.enableAdvancedSearchControls();
            }
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

                    //this.enquiryBindingSource.DataSource = Dbconnection.Enquiries.Find(Convert.ToInt32(txtEquiryRef.Text));
                    this.enquiryBindingSource.DataSource = (from a in Dbconnection.Enquiries
                                                            from b in a.CurriculumEnquiries
                                                            orderby a.EnquiryID descending
                                                            where a.EnquiryID == ID
                                                            && (a.EnquiryDate <= Common.CustomDateTime.getCustomDateTime(datFromDate.Value, 0) && a.EnquiryDate >= Common.CustomDateTime.getCustomDateTime(datToDate.Value, -1))
                                                            && b.EnquiryStatusID != (int)EnumEnquiryStatuses.Enquiry_Closed
                                                            select a)
                                                            .Include("Individuals")
                                                           .Include("Individuals.Companies")
                                                           .Include("CurriculumEnquiries")
                                                           .Include("CurriculumEnquiries.Curriculum")
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
                    if (chkUseDepartment.Checked)
                    {
                        List<Data.Models.Enquiry> lstEnquiry = (from a in Dbconnection.Enquiries
                                                                where
                                                                  (a.EnquiryDate <= Common.CustomDateTime.getCustomDateTime(datFromDate.Value, 0) && a.EnquiryDate >= Common.CustomDateTime.getCustomDateTime(datToDate.Value, -1))
                                                                  &&
                                                                   (b.IndividualFirstName.Contains(txtContactName.Text) ||
                                                                    b.IndividualLastname.Contains(txtContactName.Text))
                                                                    && c.Curriculum.DepartmentID == DepartmentID
                                                                    && c.CurriculumID == CurriculumID
                                                                orderby a.EnquiryID descending
                                                                select a)
                                                           .Include("Individuals")
                                                           .Include("Individuals.Companies")
                                                           .Include("CurriculumEnquiries")
                                                           .Include("CurriculumEnquiries.Curriculum")
                                                           .ToList<Data.Models.Enquiry>();

                        List<Data.Models.Enquiry> EnquiriesFilteredByName = new List<Data.Models.Enquiry>();
                        foreach (Data.Models.Enquiry EnquiryObj in lstEnquiry)
                        {
                            foreach (Individual IndividualObj in EnquiryObj.Individuals)
                            {
                                EnquiriesFilteredByName.Add(EnquiryObj);
                            }
                        }

                        this.enquiryBindingSource.DataSource = (from a in Dbconnection.Enquiries
                                                                from b in a.Individuals
                                                                from c in a.CurriculumEnquiries
                                                                where
                                                                  (a.EnquiryDate <= Common.CustomDateTime.getCustomDateTime(datFromDate.Value, 0) && a.EnquiryDate >= Common.CustomDateTime.getCustomDateTime(datToDate.Value, -1))
                                                                  &&
                                                                   (b.IndividualFirstName.Contains(txtContactName.Text) ||
                                                                    b.IndividualLastname.Contains(txtContactName.Text))
                                                                    && c.Curriculum.DepartmentID == DepartmentID
                                                                    && c.CurriculumID == CurriculumID
                                                                orderby a.EnquiryID descending
                                                                select a)
                                                           .Include("Individuals")
                                                           .Include("Individuals.Companies")
                                                           .Include("CurriculumEnquiries")
                                                           .Include("CurriculumEnquiries.Curriculum")
                                                           .ToList<Data.Models.Enquiry>();
                    }
                    else
                    {

                        this.enquiryBindingSource.DataSource = (from a in Dbconnection.Enquiries
                                                                from b in a.Individuals
                                                                where
                                                                   (a.EnquiryDate <= Common.CustomDateTime.getCustomDateTime(datFromDate.Value, 0) && a.EnquiryDate >= Common.CustomDateTime.getCustomDateTime(datToDate.Value, -1))
                                                                  &&
                                                                   (b.IndividualFirstName.Contains(txtContactName.Text) ||
                                                                    b.IndividualLastname.Contains(txtContactName.Text))

                                                                orderby a.EnquiryID descending
                                                                select a)
                                                           .Include("Individuals")
                                                           .Include("Individuals.Companies")
                                                           .Include("CurriculumEnquiries")
                                                           .Include("CurriculumEnquiries.Curriculum")
                                                           .ToList<Data.Models.Enquiry>();
                    }

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
                    if (IndividualObj.Companies.Count > 0)
                    {
                        row.Cells[colContactCompany.Index].Value = IndividualObj.Companies.FirstOrDefault().CompanyName.ToString();
                    }
                    else
                    {
                        row.Cells[colContactCompany.Index].Value = "NA - Private Client";
                    }


                }
            }
        }

        private void datToDate_ValueChanged(object sender, EventArgs e)
        {
            if (datToDate.Value >= Common.CustomDateTime.getCustomDateTime(datFromDate.Value, 0))
            {
                datToDate.Value = Common.CustomDateTime.getCustomDateTime(datFromDate.Value, -1);
            }
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
    }
}
