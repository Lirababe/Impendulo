using Impendulo.Data.Models;
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

namespace Impendulo.Enquiry.Development.SearchForSelectedEnquiry
{
    public partial class frmSearchForSelectedEquiry : MetroForm
    {
        public frmSearchForSelectedEquiry()
        {
            InitializeComponent();
        }
        private int _SelectedEnquiryID = 0;
        public int SelectedEnquiryID { get; }

        private void frmSearchForSelectedEquiry_Load(object sender, EventArgs e)
        {
            //Resets the controls and loads the Comboboxes
            this.resetAllSearchControls();
        }

        private void refreshEquirySearchResults()
        {
            this.populateEquirySearchResults();
        }
        private void populateEquirySearchResults()
        {
            using (var Dbconnection = new MCDEntities())
            {

            };
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
                                                            select a).ToList<LookupDepartment>();
            };
        }
        private void refreshCurriculum()
        {
            popluateCurriculums();
        }
        private void popluateCurriculums()
        {

            using (var Dbconnection = new MCDEntities())
            {
                curriculumBindingSource.DataSource = (from a in Dbconnection.Curriculums
                                                      orderby a.CurriculumName
                                                      select a).ToList<Curriculum>();
            };
        }

        private void resetAllSearchControls()
        {
            this.txtEquiryRef.Clear();
            this.txtContactName.Clear();
            this.refreshDepartments();
            this.refreshCurriculum();
            this.datFromDate.Value = Common.CustomDateTime.getCustomDateTime(DateTime.Now, 0);
            this.datFromDate.Value = Common.CustomDateTime.getCustomDateTime(DateTime.Now, -10);
        }

        private void dgvEquirySearchResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                this._SelectedEnquiryID = ((Data.Models.Enquiry)dgvEquirySearchResults.Rows[e.RowIndex].DataBoundItem).EnquiryID;
                this.Close();
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.resetAllSearchControls();
        }
    }
}
