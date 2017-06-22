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
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label companySARSLevyRegistrationNumberLabel;
            System.Windows.Forms.Label companySicCodeLabel;
            System.Windows.Forms.Label companySETANumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSwitchEnquiryContactToCompany));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.companySicCodeTextBox = new System.Windows.Forms.TextBox();
            this.companySARSLevyRegistrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.companySETANumberTextBox = new System.Windows.Forms.TextBox();
            this.btnCompanySearch = new MetroFramework.Controls.MetroTile();
            companyNameLabel = new System.Windows.Forms.Label();
            companySARSLevyRegistrationNumberLabel = new System.Windows.Forms.Label();
            companySicCodeLabel = new System.Windows.Forms.Label();
            companySETANumberLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(6, 23);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(85, 13);
            companyNameLabel.TabIndex = 6;
            companyNameLabel.Text = "Company Name:";
            // 
            // companySARSLevyRegistrationNumberLabel
            // 
            companySARSLevyRegistrationNumberLabel.AutoSize = true;
            companySARSLevyRegistrationNumberLabel.Location = new System.Drawing.Point(6, 51);
            companySARSLevyRegistrationNumberLabel.Name = "companySARSLevyRegistrationNumberLabel";
            companySARSLevyRegistrationNumberLabel.Size = new System.Drawing.Size(153, 13);
            companySARSLevyRegistrationNumberLabel.TabIndex = 8;
            companySARSLevyRegistrationNumberLabel.Text = "Company Registration Number:";
            // 
            // companySicCodeLabel
            // 
            companySicCodeLabel.AutoSize = true;
            companySicCodeLabel.Location = new System.Drawing.Point(6, 107);
            companySicCodeLabel.Name = "companySicCodeLabel";
            companySicCodeLabel.Size = new System.Drawing.Size(100, 13);
            companySicCodeLabel.TabIndex = 12;
            companySicCodeLabel.Text = "Company Sic Code:";
            // 
            // companySETANumberLabel
            // 
            companySETANumberLabel.AutoSize = true;
            companySETANumberLabel.Location = new System.Drawing.Point(6, 79);
            companySETANumberLabel.Name = "companySETANumberLabel";
            companySETANumberLabel.Size = new System.Drawing.Size(122, 13);
            companySETANumberLabel.TabIndex = 10;
            companySETANumberLabel.Text = "Company SETANumber:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCompanySearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Company Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(companyNameLabel);
            this.groupBox2.Controls.Add(this.companyNameTextBox);
            this.groupBox2.Controls.Add(this.companySicCodeTextBox);
            this.groupBox2.Controls.Add(companySARSLevyRegistrationNumberLabel);
            this.groupBox2.Controls.Add(companySicCodeLabel);
            this.groupBox2.Controls.Add(this.companySARSLevyRegistrationNumberTextBox);
            this.groupBox2.Controls.Add(this.companySETANumberTextBox);
            this.groupBox2.Controls.Add(companySETANumberLabel);
            this.groupBox2.Location = new System.Drawing.Point(178, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 135);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Company Details";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(159, 20);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(451, 20);
            this.companyNameTextBox.TabIndex = 7;
            // 
            // companySicCodeTextBox
            // 
            this.companySicCodeTextBox.Location = new System.Drawing.Point(159, 104);
            this.companySicCodeTextBox.Name = "companySicCodeTextBox";
            this.companySicCodeTextBox.Size = new System.Drawing.Size(187, 20);
            this.companySicCodeTextBox.TabIndex = 13;
            // 
            // companySARSLevyRegistrationNumberTextBox
            // 
            this.companySARSLevyRegistrationNumberTextBox.Location = new System.Drawing.Point(159, 48);
            this.companySARSLevyRegistrationNumberTextBox.Name = "companySARSLevyRegistrationNumberTextBox";
            this.companySARSLevyRegistrationNumberTextBox.Size = new System.Drawing.Size(187, 20);
            this.companySARSLevyRegistrationNumberTextBox.TabIndex = 9;
            // 
            // companySETANumberTextBox
            // 
            this.companySETANumberTextBox.Location = new System.Drawing.Point(159, 76);
            this.companySETANumberTextBox.Name = "companySETANumberTextBox";
            this.companySETANumberTextBox.Size = new System.Drawing.Size(187, 20);
            this.companySETANumberTextBox.TabIndex = 11;
            // 
            // btnCompanySearch
            // 
            this.btnCompanySearch.ActiveControl = null;
            this.btnCompanySearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompanySearch.Location = new System.Drawing.Point(12, 19);
            this.btnCompanySearch.Name = "btnCompanySearch";
            this.btnCompanySearch.Size = new System.Drawing.Size(160, 135);
            this.btnCompanySearch.TabIndex = 21;
            this.btnCompanySearch.Text = "Search For Company";
            this.btnCompanySearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompanySearch.TileImage = ((System.Drawing.Image)(resources.GetObject("btnCompanySearch.TileImage")));
            this.btnCompanySearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompanySearch.UseSelectable = true;
            this.btnCompanySearch.UseTileImage = true;
            this.btnCompanySearch.Click += new System.EventHandler(this.btnCompanySearch_Click);
            // 
            // frmSwitchEnquiryContactToCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 474);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSwitchEnquiryContactToCompany";
            this.Text = "Switch Enquiry Contact To Company";
            this.Load += new System.EventHandler(this.frmSwitchEnquiryContactToCompany_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile btnCompanySearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox companySicCodeTextBox;
        private System.Windows.Forms.TextBox companySARSLevyRegistrationNumberTextBox;
        private System.Windows.Forms.TextBox companySETANumberTextBox;
    }
}