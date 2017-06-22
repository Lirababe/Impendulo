namespace Impendulo.Enquiry.Development.SwitchEnquiryContacts
{
    partial class frmSwitchEnquiryContactToCompany
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSwitchEnquiryContactToCompany));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCompanySearch = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCompanySearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Company Details";
            // 
            // btnCompanySearch
            // 
            this.btnCompanySearch.ActiveControl = null;
            this.btnCompanySearch.Location = new System.Drawing.Point(25, 30);
            this.btnCompanySearch.Name = "btnCompanySearch";
            this.btnCompanySearch.Size = new System.Drawing.Size(160, 103);
            this.btnCompanySearch.TabIndex = 21;
            this.btnCompanySearch.Text = "Search For Company";
            this.btnCompanySearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompanySearch.TileImage = ((System.Drawing.Image)(resources.GetObject("btnCompanySearch.TileImage")));
            this.btnCompanySearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompanySearch.UseSelectable = true;
            this.btnCompanySearch.UseTileImage = true;
            // 
            // frmSwitchEnquiryContactToCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 474);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSwitchEnquiryContactToCompany";
            this.Text = "Switch Enquiry Contact To Company";
            this.Load += new System.EventHandler(this.frmSwitchEnquiryContactToCompany_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile btnCompanySearch;
    }
}