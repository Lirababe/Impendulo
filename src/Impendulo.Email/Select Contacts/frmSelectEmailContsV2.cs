using Impendulo.Common.EmailSending;
using Impendulo.Common.Enum;
using Impendulo.Data;
using Impendulo.Data.Models;
using MetroFramework.Controls;
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

namespace Impendulo.Email.Select_Contacts
{
    public partial class frmSelectEmailContsV2 : MetroFramework.Forms.MetroForm
    {
        private List<Individual> _AvailableContacts = new List<Individual>();
        public List<Individual> AvailableContacts { get { return _AvailableContacts; } set { _AvailableContacts = value; } }

        private List<Individual> _SelectedContacts = new List<Individual>();
        public List<Individual> SelectedContacts { get { return _SelectedContacts; } set { _SelectedContacts = value; } }

        public frmSelectEmailContsV2()
        {
            InitializeComponent();
            PreLoadContacts();
        }
        private void refreshSelectedContacts()
        {
            populateSelectedContacts();
        }
        private void PreLoadContacts()
        {
            using (var Dbconnection = new MCDEntities())
            {


                AvailableContacts = (from a in Dbconnection.Individuals
                                     from b in a.ContactDetails
                                     where b.ContactTypeID == (int)EnumContactTypes.Email_Address
                                     select a)
                                     .Include("ContactDetails")
                                     .Include("Companies")
                                     .Include("Employee")
                                     .Include("Assessor")
                                     .Include("Facilitator")
                                     .Include("Student")
                                     .Include("Companies.Individuals.ContactDetails")
                                     .ToList<Individual>();


            };


        }

        private void populateSelectedContacts()
        {
            ContactsSelectedBindingSource.DataSource = SelectedContacts.ToList<Individual>();
        }

        private void frmSelectEmailContsV2_Load(object sender, EventArgs e)
        {
            this.refreshAvailableContacts();
        }
        public void LoadExistingContacts(List<IEmailAddress> x)
        {
            using (var Dbconnection = new MCDEntities())
            {
                foreach (EmailAddress y in x)
                {
                    foreach (Individual z in (from a in Dbconnection.Individuals
                                              from b in a.ContactDetails
                                              where b.ContactTypeID == (int)EnumContactTypes.Email_Address
                                              && b.ContactDetailValue.Contains(y.Address)
                                              select a)
                                    .Include("ContactDetails")
                                    .Include("Companies")
                                    .Include("Employee")
                                    .Include("Assessor")
                                    .Include("Facilitator")
                                    .Include("Student")
                                    .Include("Companies.Individuals.ContactDetails")
                                    .ToList<Individual>())
                    {
                        SelectedContacts.Add(z);
                    }
                    SelectedContacts = (from a in SelectedContacts
                                        select a).Distinct<Individual>().ToList<Individual>();
                }
            };
        }

        private void refreshAvailableContacts()
        {
            populateAvailableContacts();
        }
        private void populateAvailableContacts()
        {

            List<Individual> TempList = new List<Individual>();
            if (chkAllContacts.Checked)
            {
                ContactToLinkBindingSource.DataSource =
                    (from a in AvailableContacts
                     where (a.IndividualFirstName.ToString().ToLower()).Contains(txtContactFilterCriteria.Text.ToString().ToLower())
                     select a).Except(
                        SelectedContacts
                        ).ToList<Individual>(); ;
            }
            else
            {
                if (chkAssessor.Checked)
                {
                    TempList.AddRange((from a in AvailableContacts
                                       where a.Assessor != null
                                       select a).ToList<Individual>());
                }
                if (chkEmployee.Checked)
                {
                    TempList.AddRange((from a in AvailableContacts
                                       where a.Employee != null
                                       select a).ToList<Individual>());
                }
                if (chkStudent.Checked)
                {
                    TempList.AddRange((from a in AvailableContacts
                                       where a.Student != null
                                       select a).ToList<Individual>());
                }
                if (chkFaclitator.Checked)
                {
                    TempList.AddRange((from a in AvailableContacts
                                       where a.Facilitator != null
                                       select a).ToList<Individual>());
                }
                if (chkCompany.Checked)
                {

                    TempList.AddRange((from a in AvailableContacts
                                       from b in a.Companies
                                       from c in b.Individuals
                                       from d in c.ContactDetails
                                       where d.ContactTypeID == (int)EnumContactTypes.Email_Address

                                       select a).ToList<Individual>());
                }
                ContactToLinkBindingSource.DataSource = (from a in TempList
                                                         where (a.IndividualFirstName.ToString().ToLower()).Contains(txtContactFilterCriteria.Text.ToString().ToLower())
                                                         select a).Except(SelectedContacts).ToList<Individual>();
            }

        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.SelectedContacts.Clear();
            this.Close();
        }

        private void btnLinkContact_Click(object sender, EventArgs e)
        {
            var gridView = (DataGridView)dgvAvaiableContacts;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[colSelectContactToLink.Index].Value != null)
                    {
                        if ((Boolean)row.Cells[colSelectContactToLink.Index].Value == true)
                        {
                            SelectedContacts.Add((Individual)(row.DataBoundItem));
                            AvailableContacts.Remove((Individual)(row.DataBoundItem));
                        }
                    }
                }
            }
            refreshAvailableContacts();
            refreshSelectedContacts();
        }

        private void btnDeselectContacts_Click(object sender, EventArgs e)
        {

            var gridView = (DataGridView)dgvLinkedContacts;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[colSelectContactToLink.Index].Value != null)
                    {
                        if ((Boolean)row.Cells[colSelectContactToLink.Index].Value == true)
                        {
                            AvailableContacts.Add((Individual)(row.DataBoundItem));
                            SelectedContacts.Remove((Individual)(row.DataBoundItem));

                        }
                    }
                }
            }
            refreshAvailableContacts();
            refreshSelectedContacts();
        }

        private void setCheckBoxes(object TagValue)
        {

            if (Convert.ToInt32(TagValue) == 0)
            {
                foreach (Control con in flowLayoutPanelForCheckBoxes.Controls)
                {
                    if (con is MetroToggle)
                    {
                        ((MetroToggle)con).Checked = false;
                    }
                }
                chkAllContacts.Checked = true;
            }
            else
            {
                chkAllContacts.Checked = false;
            }



        }

        private void chk_Click(object sender, EventArgs e)
        {
            MetroToggle chk = (MetroToggle)sender;
            setCheckBoxes(chk.Tag);
            refreshAvailableContacts();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
