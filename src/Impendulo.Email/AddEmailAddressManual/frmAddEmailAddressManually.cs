using Impendulo.Common.EmailSending;
using MetroFramework;
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

namespace Impendulo.Email.Development.AddEmailAddressManual
{
    public partial class frmAddEmailAddressManually : MetroForm
    {
        public List<EmailAddress> CurrentEmailAddress { get; set; }
        public frmAddEmailAddressManually()
        {
            InitializeComponent();
            lstEmailAddresses.DisplayMember = "Address";
            lstEmailAddresses.Refresh();
            this.Refresh();
        }

        private void frmAddEmailAddressManually_Load(object sender, EventArgs e)
        {
            lstEmailAddresses.DataSource = CurrentEmailAddress;
            lstEmailAddresses.Refresh();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //DialogResult Rtn = MetroMessageBox.Show(this, MetroMessageBox.Show(this, "Are you sure?", "Remove Address", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).ToString());
            //if (Rtn == DialogResult.Yes)
            //{
            CurrentEmailAddress.RemoveAt(lstEmailAddresses.SelectedIndex);
            //}
            lstEmailAddresses.DataSource = CurrentEmailAddress;
            lstEmailAddresses.Refresh();
            this.Refresh();
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            try
            {
                EmailAddress EA = new EmailAddress(txtNewEmailAddress.Text);
                if (EA.ValidateEmailAddress(txtNewEmailAddress.Text))
                {
                    CurrentEmailAddress.Add(EA);
                }
                lstEmailAddresses.DataSource = CurrentEmailAddress;
                lstEmailAddresses.DisplayMember = "Address";
                lstEmailAddresses.Refresh();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error Adding Address. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //private void dgvManualEmailAddresses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        //{
        //    var gridView = (DataGridView)sender;
        //    foreach (DataGridViewRow row in gridView.Rows)
        //    {
        //        if (!row.IsNewRow)
        //        {
        //            var ContactDetailObj = (EmailAddress)(row.DataBoundItem);
        //            row.Cells[colEmailAddesses.Index].Value = ContactDetailObj.Address.ToString();

        //        }
        //    }
        //}
    }
}
