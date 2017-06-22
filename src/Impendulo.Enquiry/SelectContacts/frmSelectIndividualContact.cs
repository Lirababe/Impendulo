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
using Impendulo.ContactDetails.Development;
using Impendulo.Contacts.Development;
using MetroFramework.Forms;
using System.Data.Entity;
using Impendulo.Development.Contacts;

namespace Impendulo.Enquiry.SelectContacts.Developemnt
{
    public partial class frmSelectIndividualContact : MetroForm
    {
        public frmSelectIndividualContact()
        {
            InitializeComponent();
        }

        private string _FirstName = "";
        private string _LastName = "";
        private string _IDNumber = "";

        private Individual _CurrentSelectedIndividual;
        public Individual SelectedIndividual
        {
            get
            {
                if (_CurrentSelectedIndividual == null)
                {
                    _CurrentSelectedIndividual = new Individual();
                }
                return _CurrentSelectedIndividual;
            }
            set { _CurrentSelectedIndividual = value; }
        }

        private void frmSelectIndividualContact_Load(object sender, EventArgs e)
        {
            if (SelectedIndividual.IndividualID != 0)
            {
                txtFirstName.Text = SelectedIndividual.IndividualFirstName;
                txtLastName.Text = SelectedIndividual.IndividualLastname;
                setSearchControls();
            }
            else
            {

            }
            LoadSuggestions();
            this.refreshContacts();
            // this.refreshContactDetails();
        }

        private void LoadSuggestions()
        {

            AutoCompleteStringCollection StudentFirstNames = new AutoCompleteStringCollection();
            AutoCompleteStringCollection StudentLastNames = new AutoCompleteStringCollection();
            AutoCompleteStringCollection StudentIDNumbers = new AutoCompleteStringCollection();

            List<Student> x = new List<Student>();
            using (var Dbconnection = new MCDEntities())
            {
                x = (from a in Dbconnection.Students
                     select a)
                     .Include("Individual")
                     .ToList<Student>();


            };
            foreach (Student stud in x)
            {
                StudentFirstNames.Add(stud.Individual.IndividualFirstName);
            }

            txtFirstName.AutoCompleteCustomSource = StudentFirstNames;
            txtFirstName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtFirstName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (Student stud in x)
            {
                StudentLastNames.Add(stud.Individual.IndividualLastname);
            }

            txtLastName.AutoCompleteCustomSource = StudentLastNames;
            txtLastName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtLastName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (Student stud in x)
            {
                StudentIDNumbers.Add(stud.StudentIDNumber);
            }

            txtIDNumber.AutoCompleteCustomSource = StudentIDNumbers;
            txtIDNumber.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtIDNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void setSearchControls()
        {
            _FirstName = this.txtFirstName.Text.ToString();
            _LastName = this.txtLastName.Text.ToString();
            _IDNumber = this.txtIDNumber.Text.ToString();
            this.refreshContacts();
        }
        private void refreshContacts()
        {
            this.populateContacts();
        }

        private void refreshContactDetails()
        {
            if (individualBindingSource.Count > 0)
            {
                populateContactDetails();
            }
            else
            {
                contactDetailBindingSource.DataSource = null;
            }
        }

        private void populateContactDetails()
        {
            Individual CurrentIndividual = (Individual)individualBindingSource.Current;
            contactDetailBindingSource.DataSource = (CurrentIndividual.ContactDetails).ToList<ContactDetail>();
            if (contactDetailBindingSource.Count > 0)
            {
                this.btnSelectContact.Enabled = true;
            }
            else
            {
                this.btnSelectContact.Enabled = false;
            }
        }

        private void populateContacts()
        {
            using (var Dbconnection = new MCDEntities())
            {
                //List<Individual> AllIndividuals = (from a in Dbconnection.Individuals
                //                                      .Include("ContactDetails")
                //                                      .Include("ContactDetails.LookupContactType")
                //                                   where a.IndividualFirstName.Contains(_FirstName) && a.IndividualLastname.Contains(_LastName)
                //                                   select a)
                //                                       .Except(from a in Dbconnection.Facilitators
                //                                               select a.Individual)
                //                                               .Except(from a in Dbconnection.Employees
                //                                                       select a.Individual)
                //                                                       .Except(from a in Dbconnection.Assessors
                //                                                               select a.Individual)
                //                                                                       //.Except(from a in Dbconnection.Students
                //                                                                       //        select a.Individual)
                //                                                                       .Except(from a in Dbconnection.Individuals
                //                                                                               where a.Companies.Count > 0
                //                                                                               select a)
                //                                               .ToList<Individual>();

                List<Individual> AllIndividuals = (from a in Dbconnection.Students
                                                   where
                                                        a.Individual.IndividualFirstName.Contains(_FirstName)
                                                        && a.Individual.IndividualLastname.Contains(_LastName)
                                                        && a.StudentIDNumber.Contains(_IDNumber)
                                                   orderby a.Individual.IndividualFirstName
                                                   select a.Individual)
                                                    .Include("ContactDetails")
                                                    .Include("ContactDetails.LookupContactType")
                                                    .Take<Individual>(50)
                                                    .ToList<Individual>();

                individualBindingSource.DataSource = AllIndividuals;
            };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.setSearchControls();
            this.refreshContactDetails();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtIDNumber.Clear();
            this.setSearchControls();
            this.refreshContactDetails();
        }

        private void individualBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.refreshContactDetails();
        }

        private void dgvContactInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var ContactDetailObj = (ContactDetail)(row.DataBoundItem);
                    row.Cells[colContactType.Index].Value = ContactDetailObj.LookupContactType.ContactType;
                }
            }
        }

        private void btnAddContactInfo_Click(object sender, EventArgs e)
        {
            using (frmAddUpdateContactDetails frm = new frmAddUpdateContactDetails())
            {
                Individual CurrentContact = (Individual)individualBindingSource.Current;

                frm.ShowDialog();
                if (frm.CurrentDetail != null)
                {
                    using (var Dbconnection = new MCDEntities())
                    {
                        Dbconnection.Individuals.Attach(CurrentContact);

                        Dbconnection.ContactDetails.Attach(frm.CurrentDetail);

                        CurrentContact.ContactDetails.Add(frm.CurrentDetail);

                        Dbconnection.SaveChanges();

                        Dbconnection.Entry(frm.CurrentDetail).Reference("LookupContactType").Load();
                    };
                    this.refreshContactDetails();
                }
            }
        }

        private void btnSelectContact_Click(object sender, EventArgs e)
        {
            if (individualBindingSource.Count > 0)
            {
                SelectedIndividual = (Individual)individualBindingSource.Current;
            }
            this.Close();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            using (frmContactsV2 frm = new frmContactsV2())
            {
                frm.IsStudent = true;
                frm.ShowDialog();
                refreshContacts();
            }
        }

        private void btnUpdateContactDetials_Click(object sender, EventArgs e)
        {
            using (frmAddUpdateContactDetails frm = new frmAddUpdateContactDetails())
            {
                ContactDetail CurrentDetail = (ContactDetail)contactDetailBindingSource.Current;
                frm.CurrentDetail = CurrentDetail;
                frm.ContactDetailID = CurrentDetail.ContactDetailID;

                Individual CurrentContact = (Individual)individualBindingSource.Current;

                frm.ShowDialog();
                if (frm.CurrentDetail != null)
                {
                    using (var Dbconnection = new MCDEntities())
                    {
                        Dbconnection.ContactDetails.Attach(CurrentDetail);

                        Dbconnection.Entry(CurrentDetail).State = EntityState.Modified;

                        Dbconnection.SaveChanges();

                        Dbconnection.Entry(frm.CurrentDetail).Reference("LookupContactType").Load();
                    };
                    this.refreshContactDetails();
                }
            }
        }

        private void dgvContactsSearchResults_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    Individual IndividualObj = (Individual)(row.DataBoundItem);
                    row.Cells[colContactTitle.Index].Value = IndividualObj.LookupTitle.Title.ToString();
                }
            }
        }
    }
}
