namespace Impendulo.Addresses.Development
{
    partial class frmAddUpdateAddresses
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lookupProvinceLabel;
            System.Windows.Forms.Label lookupCountryLabel;
            System.Windows.Forms.Label lookupAddressTypeLabel;
            System.Windows.Forms.Label addressLineOneLabel;
            System.Windows.Forms.Label addressLineTwoLabel;
            System.Windows.Forms.Label addressTownLabel;
            System.Windows.Forms.Label addressSuburbLabel;
            System.Windows.Forms.Label addressAreaCodeLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpdateAddress = new System.Windows.Forms.Button();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.btnlCancel = new System.Windows.Forms.Button();
            this.cboStudentAddressProvince = new System.Windows.Forms.ComboBox();
            this.lookupProvinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboStudentAddressCountry = new System.Windows.Forms.ComboBox();
            this.lookupCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboStudentAddressAddressType = new System.Windows.Forms.ComboBox();
            this.lookupAddressTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtStudentAddressLineOne = new System.Windows.Forms.TextBox();
            this.txtStudentAddressLineTwo = new System.Windows.Forms.TextBox();
            this.txtStudentAddressTown = new System.Windows.Forms.TextBox();
            this.txtStudentAddressSuburb = new System.Windows.Forms.TextBox();
            this.txtStudentAddressAreaCode = new System.Windows.Forms.TextBox();
            this.chkStudnetAddressIsDefault = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lookupProvinceLabel = new System.Windows.Forms.Label();
            lookupCountryLabel = new System.Windows.Forms.Label();
            lookupAddressTypeLabel = new System.Windows.Forms.Label();
            addressLineOneLabel = new System.Windows.Forms.Label();
            addressLineTwoLabel = new System.Windows.Forms.Label();
            addressTownLabel = new System.Windows.Forms.Label();
            addressSuburbLabel = new System.Windows.Forms.Label();
            addressAreaCodeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupProvinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCountryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupAddressTypeBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lookupProvinceLabel
            // 
            lookupProvinceLabel.AutoSize = true;
            lookupProvinceLabel.Location = new System.Drawing.Point(3, 116);
            lookupProvinceLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            lookupProvinceLabel.Name = "lookupProvinceLabel";
            lookupProvinceLabel.Size = new System.Drawing.Size(52, 13);
            lookupProvinceLabel.TabIndex = 62;
            lookupProvinceLabel.Text = "Province:";
            // 
            // lookupCountryLabel
            // 
            lookupCountryLabel.AutoSize = true;
            lookupCountryLabel.Location = new System.Drawing.Point(3, 221);
            lookupCountryLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            lookupCountryLabel.Name = "lookupCountryLabel";
            lookupCountryLabel.Size = new System.Drawing.Size(46, 13);
            lookupCountryLabel.TabIndex = 59;
            lookupCountryLabel.Text = "Country:";
            // 
            // lookupAddressTypeLabel
            // 
            lookupAddressTypeLabel.AutoSize = true;
            lookupAddressTypeLabel.Location = new System.Drawing.Point(3, 7);
            lookupAddressTypeLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            lookupAddressTypeLabel.Name = "lookupAddressTypeLabel";
            lookupAddressTypeLabel.Size = new System.Drawing.Size(75, 13);
            lookupAddressTypeLabel.TabIndex = 58;
            lookupAddressTypeLabel.Text = "Address Type:";
            // 
            // addressLineOneLabel
            // 
            addressLineOneLabel.AutoSize = true;
            addressLineOneLabel.Location = new System.Drawing.Point(3, 64);
            addressLineOneLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            addressLineOneLabel.Name = "addressLineOneLabel";
            addressLineOneLabel.Size = new System.Drawing.Size(94, 13);
            addressLineOneLabel.TabIndex = 47;
            addressLineOneLabel.Text = "Address Line One:";
            // 
            // addressLineTwoLabel
            // 
            addressLineTwoLabel.AutoSize = true;
            addressLineTwoLabel.Location = new System.Drawing.Point(3, 90);
            addressLineTwoLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            addressLineTwoLabel.Name = "addressLineTwoLabel";
            addressLineTwoLabel.Size = new System.Drawing.Size(95, 13);
            addressLineTwoLabel.TabIndex = 49;
            addressLineTwoLabel.Text = "Address Line Two:";
            // 
            // addressTownLabel
            // 
            addressTownLabel.AutoSize = true;
            addressTownLabel.Location = new System.Drawing.Point(3, 143);
            addressTownLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            addressTownLabel.Name = "addressTownLabel";
            addressTownLabel.Size = new System.Drawing.Size(37, 13);
            addressTownLabel.TabIndex = 51;
            addressTownLabel.Text = "Town:";
            // 
            // addressSuburbLabel
            // 
            addressSuburbLabel.AutoSize = true;
            addressSuburbLabel.Location = new System.Drawing.Point(3, 169);
            addressSuburbLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            addressSuburbLabel.Name = "addressSuburbLabel";
            addressSuburbLabel.Size = new System.Drawing.Size(44, 13);
            addressSuburbLabel.TabIndex = 53;
            addressSuburbLabel.Text = "Suburb:";
            // 
            // addressAreaCodeLabel
            // 
            addressAreaCodeLabel.AutoSize = true;
            addressAreaCodeLabel.Location = new System.Drawing.Point(3, 195);
            addressAreaCodeLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            addressAreaCodeLabel.Name = "addressAreaCodeLabel";
            addressAreaCodeLabel.Size = new System.Drawing.Size(60, 13);
            addressAreaCodeLabel.TabIndex = 55;
            addressAreaCodeLabel.Text = "Area Code:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address Details";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnUpdateAddress);
            this.flowLayoutPanel1.Controls.Add(this.btnAddAddress);
            this.flowLayoutPanel1.Controls.Add(this.btnlCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 260);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(491, 43);
            this.flowLayoutPanel1.TabIndex = 66;
            // 
            // btnUpdateAddress
            // 
            this.btnUpdateAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateAddress.Location = new System.Drawing.Point(411, 3);
            this.btnUpdateAddress.Name = "btnUpdateAddress";
            this.btnUpdateAddress.Size = new System.Drawing.Size(77, 37);
            this.btnUpdateAddress.TabIndex = 65;
            this.btnUpdateAddress.Text = "Update";
            this.btnUpdateAddress.UseVisualStyleBackColor = true;
            this.btnUpdateAddress.Click += new System.EventHandler(this.btnStudentAddressAddUpdate_Click);
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAddress.Location = new System.Drawing.Point(328, 3);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(77, 37);
            this.btnAddAddress.TabIndex = 66;
            this.btnAddAddress.Text = "Add";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // btnlCancel
            // 
            this.btnlCancel.Location = new System.Drawing.Point(247, 3);
            this.btnlCancel.Name = "btnlCancel";
            this.btnlCancel.Size = new System.Drawing.Size(75, 36);
            this.btnlCancel.TabIndex = 64;
            this.btnlCancel.Text = "Cancel";
            this.btnlCancel.UseVisualStyleBackColor = true;
            this.btnlCancel.Click += new System.EventHandler(this.btnStudentAddressCancelAddUpdate_Click);
            // 
            // cboStudentAddressProvince
            // 
            this.cboStudentAddressProvince.DataSource = this.lookupProvinceBindingSource;
            this.cboStudentAddressProvince.DisplayMember = "Province";
            this.cboStudentAddressProvince.FormattingEnabled = true;
            this.cboStudentAddressProvince.Location = new System.Drawing.Point(107, 112);
            this.cboStudentAddressProvince.Name = "cboStudentAddressProvince";
            this.cboStudentAddressProvince.Size = new System.Drawing.Size(200, 21);
            this.cboStudentAddressProvince.TabIndex = 63;
            this.cboStudentAddressProvince.ValueMember = "ProvinceID";
            // 
            // lookupProvinceBindingSource
            // 
            this.lookupProvinceBindingSource.DataSource = typeof(Impendulo.Data.Models.LookupProvince);
            // 
            // cboStudentAddressCountry
            // 
            this.cboStudentAddressCountry.DataSource = this.lookupCountryBindingSource;
            this.cboStudentAddressCountry.DisplayMember = "CountryName";
            this.cboStudentAddressCountry.FormattingEnabled = true;
            this.cboStudentAddressCountry.Location = new System.Drawing.Point(107, 217);
            this.cboStudentAddressCountry.Name = "cboStudentAddressCountry";
            this.cboStudentAddressCountry.Size = new System.Drawing.Size(200, 21);
            this.cboStudentAddressCountry.TabIndex = 61;
            this.cboStudentAddressCountry.ValueMember = "CountryID";
            // 
            // lookupCountryBindingSource
            // 
            this.lookupCountryBindingSource.DataSource = typeof(Impendulo.Data.Models.LookupCountry);
            // 
            // cboStudentAddressAddressType
            // 
            this.cboStudentAddressAddressType.DataSource = this.lookupAddressTypeBindingSource;
            this.cboStudentAddressAddressType.DisplayMember = "AddressType";
            this.cboStudentAddressAddressType.FormattingEnabled = true;
            this.cboStudentAddressAddressType.Location = new System.Drawing.Point(107, 3);
            this.cboStudentAddressAddressType.Name = "cboStudentAddressAddressType";
            this.cboStudentAddressAddressType.Size = new System.Drawing.Size(200, 21);
            this.cboStudentAddressAddressType.TabIndex = 60;
            this.cboStudentAddressAddressType.ValueMember = "AddressTypeID";
            // 
            // lookupAddressTypeBindingSource
            // 
            this.lookupAddressTypeBindingSource.DataSource = typeof(Impendulo.Data.Models.LookupAddressType);
            // 
            // txtStudentAddressLineOne
            // 
            this.txtStudentAddressLineOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentAddressLineOne.Location = new System.Drawing.Point(107, 60);
            this.txtStudentAddressLineOne.Name = "txtStudentAddressLineOne";
            this.txtStudentAddressLineOne.Size = new System.Drawing.Size(381, 20);
            this.txtStudentAddressLineOne.TabIndex = 48;
            // 
            // txtStudentAddressLineTwo
            // 
            this.txtStudentAddressLineTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentAddressLineTwo.Location = new System.Drawing.Point(107, 86);
            this.txtStudentAddressLineTwo.Name = "txtStudentAddressLineTwo";
            this.txtStudentAddressLineTwo.Size = new System.Drawing.Size(381, 20);
            this.txtStudentAddressLineTwo.TabIndex = 50;
            // 
            // txtStudentAddressTown
            // 
            this.txtStudentAddressTown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentAddressTown.Location = new System.Drawing.Point(107, 139);
            this.txtStudentAddressTown.Name = "txtStudentAddressTown";
            this.txtStudentAddressTown.Size = new System.Drawing.Size(381, 20);
            this.txtStudentAddressTown.TabIndex = 52;
            // 
            // txtStudentAddressSuburb
            // 
            this.txtStudentAddressSuburb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentAddressSuburb.Location = new System.Drawing.Point(107, 165);
            this.txtStudentAddressSuburb.Name = "txtStudentAddressSuburb";
            this.txtStudentAddressSuburb.Size = new System.Drawing.Size(381, 20);
            this.txtStudentAddressSuburb.TabIndex = 54;
            // 
            // txtStudentAddressAreaCode
            // 
            this.txtStudentAddressAreaCode.Location = new System.Drawing.Point(107, 191);
            this.txtStudentAddressAreaCode.Name = "txtStudentAddressAreaCode";
            this.txtStudentAddressAreaCode.Size = new System.Drawing.Size(118, 20);
            this.txtStudentAddressAreaCode.TabIndex = 56;
            // 
            // chkStudnetAddressIsDefault
            // 
            this.chkStudnetAddressIsDefault.Location = new System.Drawing.Point(107, 30);
            this.chkStudnetAddressIsDefault.Name = "chkStudnetAddressIsDefault";
            this.chkStudnetAddressIsDefault.Size = new System.Drawing.Size(118, 24);
            this.chkStudnetAddressIsDefault.TabIndex = 57;
            this.chkStudnetAddressIsDefault.Text = "Is Default Address";
            this.chkStudnetAddressIsDefault.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cboStudentAddressAddressType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(lookupAddressTypeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(lookupCountryLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(lookupProvinceLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cboStudentAddressCountry, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.chkStudnetAddressIsDefault, 1, 1);
            this.tableLayoutPanel1.Controls.Add(addressAreaCodeLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(addressSuburbLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtStudentAddressAreaCode, 1, 7);
            this.tableLayoutPanel1.Controls.Add(addressTownLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtStudentAddressSuburb, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cboStudentAddressProvince, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtStudentAddressTown, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtStudentAddressLineOne, 1, 2);
            this.tableLayoutPanel1.Controls.Add(addressLineOneLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(addressLineTwoLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtStudentAddressLineTwo, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 244);
            this.tableLayoutPanel1.TabIndex = 67;
            // 
            // frmAddUpdateAddresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 386);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddUpdateAddresses";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add/Update Address Details";
            this.Load += new System.EventHandler(this.frmAddresses_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookupProvinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCountryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupAddressTypeBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnlCancel;
        private System.Windows.Forms.Button btnUpdateAddress;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.ComboBox cboStudentAddressProvince;
        private System.Windows.Forms.ComboBox cboStudentAddressCountry;
        private System.Windows.Forms.ComboBox cboStudentAddressAddressType;
        private System.Windows.Forms.TextBox txtStudentAddressLineOne;
        private System.Windows.Forms.TextBox txtStudentAddressLineTwo;
        private System.Windows.Forms.TextBox txtStudentAddressTown;
        private System.Windows.Forms.TextBox txtStudentAddressSuburb;
        private System.Windows.Forms.TextBox txtStudentAddressAreaCode;
        private System.Windows.Forms.CheckBox chkStudnetAddressIsDefault;
        private System.Windows.Forms.BindingSource lookupProvinceBindingSource;
        private System.Windows.Forms.BindingSource lookupCountryBindingSource;
        private System.Windows.Forms.BindingSource lookupAddressTypeBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

