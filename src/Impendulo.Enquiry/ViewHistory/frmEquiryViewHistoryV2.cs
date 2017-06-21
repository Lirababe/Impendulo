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

namespace Impendulo.Enquiry.Development.ViewHistory
{
    public partial class frmEquiryViewHistoryV2 : MetroForm
    {

        public int EnquiryID { get; set; }
        public frmEquiryViewHistoryV2()
        {
            InitializeComponent();
        }

        private void frmEquiryViewHistoryV2_Load(object sender, EventArgs e)
        {
            populateEnquiryHistroy();
        }
        private void populateEnquiryHistroy()
        {

            using (var Dbconnection = new MCDEntities())
            {
                equiryHistoryBindingSource.DataSource = (from a in Dbconnection.EquiryHistories
                                                         orderby a.DateEnquiryUpdated descending
                                                         where a.EnquiryID == this.EnquiryID
                                                           select a)
                                                       .ToList<EquiryHistory>();

                 /*   rhiwoo1010
                    0782555379
                    clientclieny
                    coenie@rhino

    */
                
            };
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEnquiryHistory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var EquiryHistoryObj = (EquiryHistory)(row.DataBoundItem);
                    row.Cells[colEmployeName.Index].Value = EquiryHistoryObj.Employee.Individual.FullName.ToString();
                    row.Cells[colActionPerformed.Index].Value = EquiryHistoryObj.LookupEquiryHistoryType.LookupEquiyHistoryTypeName.ToString();
                    //if (ContactDetailObj.ContactTypeID == (int)Common.Enum.EnumContactTypes.Email_Address)
                    //{
                    //    row.Cells[colInProgressContactDetailSendOption.Index].Value = "[ Send Email ]";
                    //}
                    //if (ContactDetailObj.ContactTypeID == (int)Common.Enum.EnumContactTypes.Cell_Number)
                    //{
                    //    row.Cells[colInProgressContactDetailSendOption.Index].Value = "[ Send SMS ]";
                    //}
                }
            }
        }
    }
}
