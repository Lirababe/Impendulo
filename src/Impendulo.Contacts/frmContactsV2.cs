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

namespace Impendulo.Development.Contacts
{
    public partial class frmContactsV2 : MetroForm
    {

        public Boolean IsStudent { get; set; }
        public Individual CurrentContact { get; set; }
        public int IndividualID { get; set; }

        public frmContactsV2()
        {
            IndividualID = 0;
            IsStudent = false;
            InitializeComponent();
        }

        private void frmContactsV2_Load(object sender, EventArgs e)
        {
            this.populateTitles();
            if (IndividualID != 0)
            {
                this.setControls();
            }
            this.setContactAddUpdateButtons();
        }
        private void populateTitles()
        {
            using (var Dbconnection = new MCDEntities())
            {
                lookupTitleBindingSource.DataSource = (from a in Dbconnection.LookupTitles
                                                       select a).ToList<LookupTitle>();
            };
        }
        private void setControls()
        {
            //create individual with properties set
            Individual ContactObj;
            using (var Dbconnection = new MCDEntities())
            {
                ContactObj = (from a in Dbconnection.Individuals
                              where a.IndividualID == IndividualID
                              select a).FirstOrDefault<Individual>();
            };
            this.cboIndividualTitle.SelectedValue = ContactObj.TitleID;
            this.txtFirstName.Text = ContactObj.IndividualFirstName;
            this.txtSecondName.Text = ContactObj.IndividualSecondName;
            this.txtLastName.Text = ContactObj.IndividualLastname;
        }
        private void setContactAddUpdateButtons()
        {
            if (IndividualID == 0)
            {
                btnAddContact.Visible = true;
                btnUpdateContact.Visible = false;
            }
            else
            {
                btnAddContact.Visible = false;
                btnUpdateContact.Visible = true;
            }
        }
        private void setContactControls()
        {
            if (IndividualID == 0)
            {
                this.txtFirstName.Clear();
                this.txtSecondName.Clear();
                this.txtLastName.Clear();
            }
            else
            {
                this.txtFirstName.Text = CurrentContact.IndividualFirstName;
                this.txtSecondName.Text = CurrentContact.IndividualSecondName;
                this.txtLastName.Text = CurrentContact.IndividualLastname;
            }
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
