namespace Impendulo.Enquiry.Deployment.Enquiry
{
    partial class frmClientEnquiry
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
            System.Windows.Forms.Label enquiryDateLabel;
            System.Windows.Forms.Label enquiryIDLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label companyNameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientEnquiry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchForEnquiry = new MetroFramework.Controls.MetroTile();
            this.btnCloseInprogressEnquiry = new MetroFramework.Controls.MetroTile();
            this.btnViewProgressInProgressSections = new MetroFramework.Controls.MetroTile();
            this.btnInitialConsultationConfirmationInProgressSection = new MetroFramework.Controls.MetroTile();
            this.enquiryDateTextBox = new System.Windows.Forms.TextBox();
            this.txtEnquiryInProgressEnquiryID = new System.Windows.Forms.TextBox();
            this.gbInprogressContactNameAndCompanyName = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInProgressSwitchBetweenCompanyANdPrivate = new MetroFramework.Controls.MetroTile();
            this.btnInProgressChangeContact = new MetroFramework.Controls.MetroTile();
            this.txtInprogressCompanyName = new System.Windows.Forms.TextBox();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.individualsInprogressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.initialConsultationCompleteCheckBox = new System.Windows.Forms.CheckBox();
            this.gbInProgressContactDetails = new System.Windows.Forms.GroupBox();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.dgvInprogressContactDetails = new MetroFramework.Controls.MetroGrid();
            this.colInProgressContactType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInProgressContactDetailSendOption = new System.Windows.Forms.DataGridViewLinkColumn();
            this.contactDetailsInprogressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddContactDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRemoveContactDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnuUpdateContactDetails = new System.Windows.Forms.ToolStripButton();
            this.gbInProgressEnquiryEnrrolmentQueries = new System.Windows.Forms.GroupBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dgvInProgressCurriculumEnquiries = new MetroFramework.Controls.MetroGrid();
            this.colInProgressEnquiryCloseCurriculumEnquiry = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colInProgressCurriculumDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInProgressCurriculumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInProgressEnquiryQuantityCurrentlyEnrolled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInProgressProcessEnrollment = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colInProgressViewCurrentEnrollment = new System.Windows.Forms.DataGridViewLinkColumn();
            this.curriculumEnquiryInprogressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enquiryInprogressBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btrnInProgressSendInitialDocumentation = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUpdateCurriculumEnquiryItemEnrollmentQty = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualSecondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowVersionDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.assessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilitatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lookupTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextOfKinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemAdministratorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualFirstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualSecondNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualLastnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowVersionDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.assessorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilitatorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lookupTitleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextOfKinDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemAdministratorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualFirstNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualSecondNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualLastnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowVersionDataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.assessorDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilitatorDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lookupTitleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextOfKinDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemAdministratorDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualFirstNameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualSecondNameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualLastnameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowVersionDataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.assessorDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilitatorDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lookupTitleDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextOfKinDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemAdministratorDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companiesInprogressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enquiryInprogressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullNameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualIDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleIDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualFirstNameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualSecondNameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualLastnameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowVersionDataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.assessorDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilitatorDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lookupTitleDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextOfKinDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemAdministratorDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDetailValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentQuanityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            enquiryDateLabel = new System.Windows.Forms.Label();
            enquiryIDLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            companyNameLabel1 = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbInprogressContactNameAndCompanyName.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualsInprogressBindingSource)).BeginInit();
            this.gbInProgressContactDetails.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInprogressContactDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDetailsInprogressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.gbInProgressEnquiryEnrrolmentQueries.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProgressCurriculumEnquiries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumEnquiryInprogressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryInprogressBindingNavigator)).BeginInit();
            this.enquiryInprogressBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesInprogressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryInprogressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // enquiryDateLabel
            // 
            enquiryDateLabel.AutoSize = true;
            enquiryDateLabel.Location = new System.Drawing.Point(3, 34);
            enquiryDateLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            enquiryDateLabel.Name = "enquiryDateLabel";
            enquiryDateLabel.Size = new System.Drawing.Size(71, 13);
            enquiryDateLabel.TabIndex = 0;
            enquiryDateLabel.Text = "Enquiry Date:";
            // 
            // enquiryIDLabel
            // 
            enquiryIDLabel.AutoSize = true;
            enquiryIDLabel.Location = new System.Drawing.Point(3, 7);
            enquiryIDLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            enquiryIDLabel.Name = "enquiryIDLabel";
            enquiryIDLabel.Size = new System.Drawing.Size(65, 13);
            enquiryIDLabel.TabIndex = 2;
            enquiryIDLabel.Text = "Enquiry Ref:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(3, 7);
            fullNameLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 7;
            fullNameLabel.Text = "Full Name:";
            // 
            // companyNameLabel1
            // 
            companyNameLabel1.AutoSize = true;
            companyNameLabel1.Location = new System.Drawing.Point(3, 33);
            companyNameLabel1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            companyNameLabel1.Name = "companyNameLabel1";
            companyNameLabel1.Size = new System.Drawing.Size(54, 13);
            companyNameLabel1.TabIndex = 9;
            companyNameLabel1.Text = "Company:";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.HotTrack = true;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 30);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(809, 508);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(801, 466);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Dash-Board";
            this.metroTabPage1.UseVisualStyleBackColor = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.splitContainer1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(801, 466);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Inprogress Enquiry Work Bench";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1MinSize = 185;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbInProgressEnquiryEnrrolmentQueries);
            this.splitContainer1.Size = new System.Drawing.Size(801, 466);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel6);
            this.splitContainer2.Panel1MinSize = 450;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbInProgressContactDetails);
            this.splitContainer2.Size = new System.Drawing.Size(801, 185);
            this.splitContainer2.SplitterDistance = 466;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.gbInprogressContactNameAndCompanyName, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.01075F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.98925F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(466, 185);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 73);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enquiry";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.tableLayoutPanel4.Controls.Add(enquiryIDLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(enquiryDateLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.enquiryDateTextBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtEnquiryInProgressEnquiryID, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(454, 54);
            this.tableLayoutPanel4.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnSearchForEnquiry, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCloseInprogressEnquiry, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnViewProgressInProgressSections, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInitialConsultationConfirmationInProgressSection, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(200, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel4.SetRowSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 54);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // btnSearchForEnquiry
            // 
            this.btnSearchForEnquiry.ActiveControl = null;
            this.btnSearchForEnquiry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchForEnquiry.Location = new System.Drawing.Point(3, 3);
            this.btnSearchForEnquiry.Name = "btnSearchForEnquiry";
            this.btnSearchForEnquiry.Size = new System.Drawing.Size(57, 48);
            this.btnSearchForEnquiry.TabIndex = 6;
            this.btnSearchForEnquiry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchForEnquiry.TileImage = ((System.Drawing.Image)(resources.GetObject("btnSearchForEnquiry.TileImage")));
            this.btnSearchForEnquiry.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnSearchForEnquiry, "Search for Enquiry");
            this.btnSearchForEnquiry.UseSelectable = true;
            this.btnSearchForEnquiry.UseTileImage = true;
            this.btnSearchForEnquiry.Click += new System.EventHandler(this.btnSearchForEnquiry_Click);
            // 
            // btnCloseInprogressEnquiry
            // 
            this.btnCloseInprogressEnquiry.ActiveControl = null;
            this.btnCloseInprogressEnquiry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCloseInprogressEnquiry.Location = new System.Drawing.Point(192, 3);
            this.btnCloseInprogressEnquiry.Name = "btnCloseInprogressEnquiry";
            this.btnCloseInprogressEnquiry.Size = new System.Drawing.Size(59, 48);
            this.btnCloseInprogressEnquiry.TabIndex = 11;
            this.btnCloseInprogressEnquiry.TileImage = ((System.Drawing.Image)(resources.GetObject("btnCloseInprogressEnquiry.TileImage")));
            this.btnCloseInprogressEnquiry.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnCloseInprogressEnquiry, "Close The Enquiry, Closes All Enrollments Line Items As Well");
            this.btnCloseInprogressEnquiry.UseSelectable = true;
            this.btnCloseInprogressEnquiry.UseTileImage = true;
            this.btnCloseInprogressEnquiry.Click += new System.EventHandler(this.btnCloseInprogressEnquiry_Click);
            // 
            // btnViewProgressInProgressSections
            // 
            this.btnViewProgressInProgressSections.ActiveControl = null;
            this.btnViewProgressInProgressSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewProgressInProgressSections.Location = new System.Drawing.Point(129, 3);
            this.btnViewProgressInProgressSections.Name = "btnViewProgressInProgressSections";
            this.btnViewProgressInProgressSections.Size = new System.Drawing.Size(57, 48);
            this.btnViewProgressInProgressSections.TabIndex = 10;
            this.btnViewProgressInProgressSections.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewProgressInProgressSections.TileImage = ((System.Drawing.Image)(resources.GetObject("btnViewProgressInProgressSections.TileImage")));
            this.btnViewProgressInProgressSections.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnViewProgressInProgressSections, "View History");
            this.btnViewProgressInProgressSections.UseSelectable = true;
            this.btnViewProgressInProgressSections.UseTileImage = true;
            this.btnViewProgressInProgressSections.Click += new System.EventHandler(this.btnViewProgressInProgressSections_Click);
            // 
            // btnInitialConsultationConfirmationInProgressSection
            // 
            this.btnInitialConsultationConfirmationInProgressSection.ActiveControl = null;
            this.btnInitialConsultationConfirmationInProgressSection.BackColor = System.Drawing.Color.Olive;
            this.btnInitialConsultationConfirmationInProgressSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInitialConsultationConfirmationInProgressSection.Location = new System.Drawing.Point(66, 3);
            this.btnInitialConsultationConfirmationInProgressSection.Name = "btnInitialConsultationConfirmationInProgressSection";
            this.btnInitialConsultationConfirmationInProgressSection.Size = new System.Drawing.Size(57, 48);
            this.btnInitialConsultationConfirmationInProgressSection.TabIndex = 12;
            this.btnInitialConsultationConfirmationInProgressSection.TileImage = ((System.Drawing.Image)(resources.GetObject("btnInitialConsultationConfirmationInProgressSection.TileImage")));
            this.btnInitialConsultationConfirmationInProgressSection.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnInitialConsultationConfirmationInProgressSection, "Process Initial Consultation");
            this.btnInitialConsultationConfirmationInProgressSection.UseSelectable = true;
            this.btnInitialConsultationConfirmationInProgressSection.UseTileImage = true;
            this.btnInitialConsultationConfirmationInProgressSection.Click += new System.EventHandler(this.btnInitialConsultationConfirmation_Click);
            // 
            // enquiryDateTextBox
            // 
            this.enquiryDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enquiryInprogressBindingSource, "EnquiryDate", true));
            this.enquiryDateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enquiryDateTextBox.Location = new System.Drawing.Point(85, 30);
            this.enquiryDateTextBox.Name = "enquiryDateTextBox";
            this.enquiryDateTextBox.ReadOnly = true;
            this.enquiryDateTextBox.Size = new System.Drawing.Size(112, 20);
            this.enquiryDateTextBox.TabIndex = 1;
            this.enquiryDateTextBox.TextChanged += new System.EventHandler(this.enquiryDateTextBox_TextChanged);
            // 
            // txtEnquiryInProgressEnquiryID
            // 
            this.txtEnquiryInProgressEnquiryID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enquiryInprogressBindingSource, "EnquiryID", true));
            this.txtEnquiryInProgressEnquiryID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEnquiryInProgressEnquiryID.Location = new System.Drawing.Point(85, 3);
            this.txtEnquiryInProgressEnquiryID.Name = "txtEnquiryInProgressEnquiryID";
            this.txtEnquiryInProgressEnquiryID.ReadOnly = true;
            this.txtEnquiryInProgressEnquiryID.Size = new System.Drawing.Size(112, 20);
            this.txtEnquiryInProgressEnquiryID.TabIndex = 3;
            // 
            // gbInprogressContactNameAndCompanyName
            // 
            this.gbInprogressContactNameAndCompanyName.Controls.Add(this.tableLayoutPanel5);
            this.gbInprogressContactNameAndCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInprogressContactNameAndCompanyName.Location = new System.Drawing.Point(3, 82);
            this.gbInprogressContactNameAndCompanyName.Name = "gbInprogressContactNameAndCompanyName";
            this.gbInprogressContactNameAndCompanyName.Size = new System.Drawing.Size(460, 100);
            this.gbInprogressContactNameAndCompanyName.TabIndex = 9;
            this.gbInprogressContactNameAndCompanyName.TabStop = false;
            this.gbInprogressContactNameAndCompanyName.Text = "Company Contact Or ( Student Details if Private )";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtInprogressCompanyName, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.fullNameTextBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(fullNameLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(companyNameLabel1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.initialConsultationCompleteCheckBox, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(454, 81);
            this.tableLayoutPanel5.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnInProgressSwitchBetweenCompanyANdPrivate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInProgressChangeContact, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(354, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel5.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(97, 52);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // btnInProgressSwitchBetweenCompanyANdPrivate
            // 
            this.btnInProgressSwitchBetweenCompanyANdPrivate.ActiveControl = null;
            this.btnInProgressSwitchBetweenCompanyANdPrivate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInProgressSwitchBetweenCompanyANdPrivate.Location = new System.Drawing.Point(3, 3);
            this.btnInProgressSwitchBetweenCompanyANdPrivate.Name = "btnInProgressSwitchBetweenCompanyANdPrivate";
            this.btnInProgressSwitchBetweenCompanyANdPrivate.Size = new System.Drawing.Size(42, 46);
            this.btnInProgressSwitchBetweenCompanyANdPrivate.TabIndex = 12;
            this.btnInProgressSwitchBetweenCompanyANdPrivate.TileImage = ((System.Drawing.Image)(resources.GetObject("btnInProgressSwitchBetweenCompanyANdPrivate.TileImage")));
            this.btnInProgressSwitchBetweenCompanyANdPrivate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnInProgressSwitchBetweenCompanyANdPrivate, "Switch between Company And Private");
            this.btnInProgressSwitchBetweenCompanyANdPrivate.UseSelectable = true;
            this.btnInProgressSwitchBetweenCompanyANdPrivate.UseTileImage = true;
            this.btnInProgressSwitchBetweenCompanyANdPrivate.Click += new System.EventHandler(this.btnInProgressSwitchBetweenCompanyANdPrivate_Click);
            // 
            // btnInProgressChangeContact
            // 
            this.btnInProgressChangeContact.ActiveControl = null;
            this.btnInProgressChangeContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInProgressChangeContact.Location = new System.Drawing.Point(51, 3);
            this.btnInProgressChangeContact.Name = "btnInProgressChangeContact";
            this.btnInProgressChangeContact.Size = new System.Drawing.Size(43, 46);
            this.btnInProgressChangeContact.TabIndex = 15;
            this.btnInProgressChangeContact.TileImage = ((System.Drawing.Image)(resources.GetObject("btnInProgressChangeContact.TileImage")));
            this.btnInProgressChangeContact.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnInProgressChangeContact, "Change Enquiry Contact");
            this.btnInProgressChangeContact.UseSelectable = true;
            this.btnInProgressChangeContact.UseTileImage = true;
            this.btnInProgressChangeContact.Click += new System.EventHandler(this.btnInProgressChangeContact_Click);
            // 
            // txtInprogressCompanyName
            // 
            this.txtInprogressCompanyName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "CompanyName", true));
            this.txtInprogressCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInprogressCompanyName.Location = new System.Drawing.Point(69, 29);
            this.txtInprogressCompanyName.Name = "txtInprogressCompanyName";
            this.txtInprogressCompanyName.ReadOnly = true;
            this.txtInprogressCompanyName.Size = new System.Drawing.Size(282, 20);
            this.txtInprogressCompanyName.TabIndex = 10;
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "Companies";
            this.companiesBindingSource.DataSource = this.enquiryInprogressBindingSource;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.individualsInprogressBindingSource, "FullName", true));
            this.fullNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullNameTextBox.Location = new System.Drawing.Point(69, 3);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(282, 20);
            this.fullNameTextBox.TabIndex = 11;
            // 
            // individualsInprogressBindingSource
            // 
            this.individualsInprogressBindingSource.DataMember = "Individuals";
            this.individualsInprogressBindingSource.DataSource = this.enquiryInprogressBindingSource;
            // 
            // initialConsultationCompleteCheckBox
            // 
            this.initialConsultationCompleteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.enquiryInprogressBindingSource, "InitialConsultationComplete", true));
            this.initialConsultationCompleteCheckBox.Enabled = false;
            this.initialConsultationCompleteCheckBox.Location = new System.Drawing.Point(69, 55);
            this.initialConsultationCompleteCheckBox.Name = "initialConsultationCompleteCheckBox";
            this.initialConsultationCompleteCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.initialConsultationCompleteCheckBox.Size = new System.Drawing.Size(171, 24);
            this.initialConsultationCompleteCheckBox.TabIndex = 14;
            this.initialConsultationCompleteCheckBox.Text = "Initial Consultation Complete";
            this.initialConsultationCompleteCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.initialConsultationCompleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // gbInProgressContactDetails
            // 
            this.gbInProgressContactDetails.Controls.Add(this.toolStripContainer2);
            this.gbInProgressContactDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInProgressContactDetails.Location = new System.Drawing.Point(0, 0);
            this.gbInProgressContactDetails.Name = "gbInProgressContactDetails";
            this.gbInProgressContactDetails.Size = new System.Drawing.Size(331, 185);
            this.gbInProgressContactDetails.TabIndex = 0;
            this.gbInProgressContactDetails.TabStop = false;
            this.gbInProgressContactDetails.Text = "Contact Details";
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.dgvInprogressContactDetails);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(325, 141);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(3, 16);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(325, 166);
            this.toolStripContainer2.TabIndex = 0;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.bindingNavigator1);
            // 
            // dgvInprogressContactDetails
            // 
            this.dgvInprogressContactDetails.AllowUserToAddRows = false;
            this.dgvInprogressContactDetails.AllowUserToDeleteRows = false;
            this.dgvInprogressContactDetails.AllowUserToResizeRows = false;
            this.dgvInprogressContactDetails.AutoGenerateColumns = false;
            this.dgvInprogressContactDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInprogressContactDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInprogressContactDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInprogressContactDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInprogressContactDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInprogressContactDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInprogressContactDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInProgressContactType,
            this.contactDetailValueDataGridViewTextBoxColumn,
            this.colInProgressContactDetailSendOption});
            this.dgvInprogressContactDetails.DataSource = this.contactDetailsInprogressBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInprogressContactDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInprogressContactDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInprogressContactDetails.EnableHeadersVisualStyles = false;
            this.dgvInprogressContactDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvInprogressContactDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInprogressContactDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvInprogressContactDetails.Name = "dgvInprogressContactDetails";
            this.dgvInprogressContactDetails.ReadOnly = true;
            this.dgvInprogressContactDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInprogressContactDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInprogressContactDetails.RowHeadersVisible = false;
            this.dgvInprogressContactDetails.RowHeadersWidth = 15;
            this.dgvInprogressContactDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvInprogressContactDetails.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInprogressContactDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInprogressContactDetails.Size = new System.Drawing.Size(325, 141);
            this.dgvInprogressContactDetails.TabIndex = 0;
            this.dgvInprogressContactDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInprogressContactDetails_CellContentClick);
            this.dgvInprogressContactDetails.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInprogressContactDetails_DataBindingComplete);
            // 
            // colInProgressContactType
            // 
            this.colInProgressContactType.HeaderText = "Contact Type";
            this.colInProgressContactType.Name = "colInProgressContactType";
            this.colInProgressContactType.ReadOnly = true;
            // 
            // colInProgressContactDetailSendOption
            // 
            this.colInProgressContactDetailSendOption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInProgressContactDetailSendOption.HeaderText = "Option";
            this.colInProgressContactDetailSendOption.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colInProgressContactDetailSendOption.Name = "colInProgressContactDetailSendOption";
            this.colInProgressContactDetailSendOption.ReadOnly = true;
            this.colInProgressContactDetailSendOption.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colInProgressContactDetailSendOption.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colInProgressContactDetailSendOption.ToolTipText = "Select To Send Message";
            this.colInProgressContactDetailSendOption.TrackVisitedState = false;
            // 
            // contactDetailsInprogressBindingSource
            // 
            this.contactDetailsInprogressBindingSource.DataMember = "ContactDetails";
            this.contactDetailsInprogressBindingSource.DataSource = this.individualsInprogressBindingSource;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.contactDetailsInprogressBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.btnAddContactDetail,
            this.toolStripSeparator1,
            this.btnRemoveContactDetail,
            this.toolStripSeparator2,
            this.btnuUpdateContactDetails});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(325, 25);
            this.bindingNavigator1.Stretch = true;
            this.bindingNavigator1.TabIndex = 0;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddContactDetail
            // 
            this.btnAddContactDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddContactDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnAddContactDetail.Image")));
            this.btnAddContactDetail.Name = "btnAddContactDetail";
            this.btnAddContactDetail.RightToLeftAutoMirrorImage = true;
            this.btnAddContactDetail.Size = new System.Drawing.Size(23, 22);
            this.btnAddContactDetail.Text = "Add new";
            this.btnAddContactDetail.Click += new System.EventHandler(this.btnAddContactDetail_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRemoveContactDetail
            // 
            this.btnRemoveContactDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveContactDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveContactDetail.Image")));
            this.btnRemoveContactDetail.Name = "btnRemoveContactDetail";
            this.btnRemoveContactDetail.RightToLeftAutoMirrorImage = true;
            this.btnRemoveContactDetail.Size = new System.Drawing.Size(23, 22);
            this.btnRemoveContactDetail.Text = "Delete";
            this.btnRemoveContactDetail.Click += new System.EventHandler(this.btnRemoveContactDetail_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnuUpdateContactDetails
            // 
            this.btnuUpdateContactDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnuUpdateContactDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnuUpdateContactDetails.Image")));
            this.btnuUpdateContactDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnuUpdateContactDetails.Name = "btnuUpdateContactDetails";
            this.btnuUpdateContactDetails.Size = new System.Drawing.Size(23, 22);
            this.btnuUpdateContactDetails.Text = "toolStripButton1";
            this.btnuUpdateContactDetails.ToolTipText = "Update Contact Detail";
            this.btnuUpdateContactDetails.Click += new System.EventHandler(this.btnuUpdateContactDetails_Click);
            // 
            // gbInProgressEnquiryEnrrolmentQueries
            // 
            this.gbInProgressEnquiryEnrrolmentQueries.Controls.Add(this.toolStripContainer1);
            this.gbInProgressEnquiryEnrrolmentQueries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInProgressEnquiryEnrrolmentQueries.Location = new System.Drawing.Point(0, 0);
            this.gbInProgressEnquiryEnrrolmentQueries.Name = "gbInProgressEnquiryEnrrolmentQueries";
            this.gbInProgressEnquiryEnrrolmentQueries.Size = new System.Drawing.Size(801, 277);
            this.gbInProgressEnquiryEnrrolmentQueries.TabIndex = 0;
            this.gbInProgressEnquiryEnrrolmentQueries.TabStop = false;
            this.gbInProgressEnquiryEnrrolmentQueries.Text = "Enquiry Enrollment Queries";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvInProgressCurriculumEnquiries);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(795, 233);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 16);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(795, 258);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.enquiryInprogressBindingNavigator);
            // 
            // dgvInProgressCurriculumEnquiries
            // 
            this.dgvInProgressCurriculumEnquiries.AllowUserToAddRows = false;
            this.dgvInProgressCurriculumEnquiries.AllowUserToDeleteRows = false;
            this.dgvInProgressCurriculumEnquiries.AllowUserToResizeRows = false;
            this.dgvInProgressCurriculumEnquiries.AutoGenerateColumns = false;
            this.dgvInProgressCurriculumEnquiries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInProgressCurriculumEnquiries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInProgressCurriculumEnquiries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInProgressCurriculumEnquiries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInProgressCurriculumEnquiries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInProgressCurriculumEnquiries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInProgressCurriculumEnquiries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastUpdatedDataGridViewTextBoxColumn,
            this.colInProgressEnquiryCloseCurriculumEnquiry,
            this.colInProgressCurriculumDepartment,
            this.colInProgressCurriculumName,
            this.enrollmentQuanityDataGridViewTextBoxColumn,
            this.colInProgressEnquiryQuantityCurrentlyEnrolled,
            this.colInProgressProcessEnrollment,
            this.colInProgressViewCurrentEnrollment});
            this.dgvInProgressCurriculumEnquiries.DataSource = this.curriculumEnquiryInprogressBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInProgressCurriculumEnquiries.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInProgressCurriculumEnquiries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInProgressCurriculumEnquiries.EnableHeadersVisualStyles = false;
            this.dgvInProgressCurriculumEnquiries.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvInProgressCurriculumEnquiries.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInProgressCurriculumEnquiries.Location = new System.Drawing.Point(0, 0);
            this.dgvInProgressCurriculumEnquiries.Name = "dgvInProgressCurriculumEnquiries";
            this.dgvInProgressCurriculumEnquiries.ReadOnly = true;
            this.dgvInProgressCurriculumEnquiries.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInProgressCurriculumEnquiries.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInProgressCurriculumEnquiries.RowHeadersVisible = false;
            this.dgvInProgressCurriculumEnquiries.RowHeadersWidth = 15;
            this.dgvInProgressCurriculumEnquiries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvInProgressCurriculumEnquiries.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvInProgressCurriculumEnquiries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInProgressCurriculumEnquiries.Size = new System.Drawing.Size(795, 233);
            this.dgvInProgressCurriculumEnquiries.TabIndex = 0;
            this.dgvInProgressCurriculumEnquiries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInProgressCurriculumEnquiries_CellContentClick);
            this.dgvInProgressCurriculumEnquiries.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInProgressCurriculumEnquiries_DataBindingComplete);
            // 
            // colInProgressEnquiryCloseCurriculumEnquiry
            // 
            this.colInProgressEnquiryCloseCurriculumEnquiry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.colInProgressEnquiryCloseCurriculumEnquiry.DefaultCellStyle = dataGridViewCellStyle6;
            this.colInProgressEnquiryCloseCurriculumEnquiry.HeaderText = "";
            this.colInProgressEnquiryCloseCurriculumEnquiry.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colInProgressEnquiryCloseCurriculumEnquiry.Name = "colInProgressEnquiryCloseCurriculumEnquiry";
            this.colInProgressEnquiryCloseCurriculumEnquiry.ReadOnly = true;
            this.colInProgressEnquiryCloseCurriculumEnquiry.Text = "[ Close Enquiry Item ]";
            this.colInProgressEnquiryCloseCurriculumEnquiry.TrackVisitedState = false;
            this.colInProgressEnquiryCloseCurriculumEnquiry.Width = 5;
            // 
            // colInProgressCurriculumDepartment
            // 
            this.colInProgressCurriculumDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colInProgressCurriculumDepartment.HeaderText = "Department";
            this.colInProgressCurriculumDepartment.Name = "colInProgressCurriculumDepartment";
            this.colInProgressCurriculumDepartment.ReadOnly = true;
            this.colInProgressCurriculumDepartment.Width = 91;
            // 
            // colInProgressCurriculumName
            // 
            this.colInProgressCurriculumName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colInProgressCurriculumName.HeaderText = "Curriculum";
            this.colInProgressCurriculumName.Name = "colInProgressCurriculumName";
            this.colInProgressCurriculumName.ReadOnly = true;
            this.colInProgressCurriculumName.Width = 86;
            // 
            // colInProgressEnquiryQuantityCurrentlyEnrolled
            // 
            this.colInProgressEnquiryQuantityCurrentlyEnrolled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colInProgressEnquiryQuantityCurrentlyEnrolled.DefaultCellStyle = dataGridViewCellStyle8;
            this.colInProgressEnquiryQuantityCurrentlyEnrolled.HeaderText = "Qty Enrolled";
            this.colInProgressEnquiryQuantityCurrentlyEnrolled.Name = "colInProgressEnquiryQuantityCurrentlyEnrolled";
            this.colInProgressEnquiryQuantityCurrentlyEnrolled.ReadOnly = true;
            this.colInProgressEnquiryQuantityCurrentlyEnrolled.Width = 93;
            // 
            // colInProgressProcessEnrollment
            // 
            this.colInProgressProcessEnrollment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colInProgressProcessEnrollment.HeaderText = "";
            this.colInProgressProcessEnrollment.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colInProgressProcessEnrollment.Name = "colInProgressProcessEnrollment";
            this.colInProgressProcessEnrollment.ReadOnly = true;
            this.colInProgressProcessEnrollment.Text = "[ Pocess Enrollment ]";
            this.colInProgressProcessEnrollment.TrackVisitedState = false;
            this.colInProgressProcessEnrollment.UseColumnTextForLinkValue = true;
            this.colInProgressProcessEnrollment.Width = 5;
            // 
            // colInProgressViewCurrentEnrollment
            // 
            this.colInProgressViewCurrentEnrollment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInProgressViewCurrentEnrollment.HeaderText = "";
            this.colInProgressViewCurrentEnrollment.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colInProgressViewCurrentEnrollment.Name = "colInProgressViewCurrentEnrollment";
            this.colInProgressViewCurrentEnrollment.ReadOnly = true;
            this.colInProgressViewCurrentEnrollment.Text = "[ View Current Enrollments ]";
            this.colInProgressViewCurrentEnrollment.TrackVisitedState = false;
            this.colInProgressViewCurrentEnrollment.UseColumnTextForLinkValue = true;
            // 
            // curriculumEnquiryInprogressBindingSource
            // 
            this.curriculumEnquiryInprogressBindingSource.DataMember = "CurriculumEnquiries";
            this.curriculumEnquiryInprogressBindingSource.DataSource = this.enquiryInprogressBindingSource;
            // 
            // enquiryInprogressBindingNavigator
            // 
            this.enquiryInprogressBindingNavigator.AddNewItem = null;
            this.enquiryInprogressBindingNavigator.BindingSource = this.curriculumEnquiryInprogressBindingSource;
            this.enquiryInprogressBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.enquiryInprogressBindingNavigator.DeleteItem = null;
            this.enquiryInprogressBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.enquiryInprogressBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator3,
            this.btrnInProgressSendInitialDocumentation,
            this.toolStripSeparator4,
            this.btnUpdateCurriculumEnquiryItemEnrollmentQty,
            this.toolStripSeparator5});
            this.enquiryInprogressBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.enquiryInprogressBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.enquiryInprogressBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.enquiryInprogressBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.enquiryInprogressBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.enquiryInprogressBindingNavigator.Name = "enquiryInprogressBindingNavigator";
            this.enquiryInprogressBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.enquiryInprogressBindingNavigator.Size = new System.Drawing.Size(795, 25);
            this.enquiryInprogressBindingNavigator.Stretch = true;
            this.enquiryInprogressBindingNavigator.TabIndex = 1;
            this.enquiryInprogressBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.ToolTipText = "Add Additional Enquiry Items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.ToolTipText = "Cancel/Close Enquiry Item";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btrnInProgressSendInitialDocumentation
            // 
            this.btrnInProgressSendInitialDocumentation.Image = ((System.Drawing.Image)(resources.GetObject("btrnInProgressSendInitialDocumentation.Image")));
            this.btrnInProgressSendInitialDocumentation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btrnInProgressSendInitialDocumentation.Name = "btrnInProgressSendInitialDocumentation";
            this.btrnInProgressSendInitialDocumentation.Size = new System.Drawing.Size(171, 22);
            this.btrnInProgressSendInitialDocumentation.Text = "Send Initail Documentation";
            this.btrnInProgressSendInitialDocumentation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btrnInProgressSendInitialDocumentation.ToolTipText = "Send Initial Documentation after Initial Consultation";
            this.btrnInProgressSendInitialDocumentation.Click += new System.EventHandler(this.btrnInProgressSendInitialDocumentation_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnUpdateCurriculumEnquiryItemEnrollmentQty
            // 
            this.btnUpdateCurriculumEnquiryItemEnrollmentQty.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCurriculumEnquiryItemEnrollmentQty.Image")));
            this.btnUpdateCurriculumEnquiryItemEnrollmentQty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateCurriculumEnquiryItemEnrollmentQty.Name = "btnUpdateCurriculumEnquiryItemEnrollmentQty";
            this.btnUpdateCurriculumEnquiryItemEnrollmentQty.Size = new System.Drawing.Size(87, 22);
            this.btnUpdateCurriculumEnquiryItemEnrollmentQty.Text = "Update Qty";
            this.btnUpdateCurriculumEnquiryItemEnrollmentQty.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdateCurriculumEnquiryItemEnrollmentQty.Click += new System.EventHandler(this.btnUpdateCurriculumEnquiryItemEnrollmentQty_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(801, 466);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Completed Enquiry";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Documents-icon-32.png");
            this.imageList1.Images.SetKeyName(1, "Downloads-icon-32.png");
            this.imageList1.Images.SetKeyName(2, "Favorite-icon-32.png");
            this.imageList1.Images.SetKeyName(3, "Network-icon-32.png");
            this.imageList1.Images.SetKeyName(4, "Public-icon-32.png");
            this.imageList1.Images.SetKeyName(5, "System-icon-32.png");
            this.imageList1.Images.SetKeyName(6, "User-icon-32.png");
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // individualIDDataGridViewTextBoxColumn
            // 
            this.individualIDDataGridViewTextBoxColumn.DataPropertyName = "IndividualID";
            this.individualIDDataGridViewTextBoxColumn.HeaderText = "IndividualID";
            this.individualIDDataGridViewTextBoxColumn.Name = "individualIDDataGridViewTextBoxColumn";
            // 
            // titleIDDataGridViewTextBoxColumn
            // 
            this.titleIDDataGridViewTextBoxColumn.DataPropertyName = "TitleID";
            this.titleIDDataGridViewTextBoxColumn.HeaderText = "TitleID";
            this.titleIDDataGridViewTextBoxColumn.Name = "titleIDDataGridViewTextBoxColumn";
            // 
            // individualFirstNameDataGridViewTextBoxColumn
            // 
            this.individualFirstNameDataGridViewTextBoxColumn.DataPropertyName = "IndividualFirstName";
            this.individualFirstNameDataGridViewTextBoxColumn.HeaderText = "IndividualFirstName";
            this.individualFirstNameDataGridViewTextBoxColumn.Name = "individualFirstNameDataGridViewTextBoxColumn";
            // 
            // individualSecondNameDataGridViewTextBoxColumn
            // 
            this.individualSecondNameDataGridViewTextBoxColumn.DataPropertyName = "IndividualSecondName";
            this.individualSecondNameDataGridViewTextBoxColumn.HeaderText = "IndividualSecondName";
            this.individualSecondNameDataGridViewTextBoxColumn.Name = "individualSecondNameDataGridViewTextBoxColumn";
            // 
            // individualLastnameDataGridViewTextBoxColumn
            // 
            this.individualLastnameDataGridViewTextBoxColumn.DataPropertyName = "IndividualLastname";
            this.individualLastnameDataGridViewTextBoxColumn.HeaderText = "IndividualLastname";
            this.individualLastnameDataGridViewTextBoxColumn.Name = "individualLastnameDataGridViewTextBoxColumn";
            // 
            // rowVersionDataGridViewImageColumn
            // 
            this.rowVersionDataGridViewImageColumn.DataPropertyName = "RowVersion";
            this.rowVersionDataGridViewImageColumn.HeaderText = "RowVersion";
            this.rowVersionDataGridViewImageColumn.Name = "rowVersionDataGridViewImageColumn";
            // 
            // assessorDataGridViewTextBoxColumn
            // 
            this.assessorDataGridViewTextBoxColumn.DataPropertyName = "Assessor";
            this.assessorDataGridViewTextBoxColumn.HeaderText = "Assessor";
            this.assessorDataGridViewTextBoxColumn.Name = "assessorDataGridViewTextBoxColumn";
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            // 
            // facilitatorDataGridViewTextBoxColumn
            // 
            this.facilitatorDataGridViewTextBoxColumn.DataPropertyName = "Facilitator";
            this.facilitatorDataGridViewTextBoxColumn.HeaderText = "Facilitator";
            this.facilitatorDataGridViewTextBoxColumn.Name = "facilitatorDataGridViewTextBoxColumn";
            // 
            // lookupTitleDataGridViewTextBoxColumn
            // 
            this.lookupTitleDataGridViewTextBoxColumn.DataPropertyName = "LookupTitle";
            this.lookupTitleDataGridViewTextBoxColumn.HeaderText = "LookupTitle";
            this.lookupTitleDataGridViewTextBoxColumn.Name = "lookupTitleDataGridViewTextBoxColumn";
            // 
            // nextOfKinDataGridViewTextBoxColumn
            // 
            this.nextOfKinDataGridViewTextBoxColumn.DataPropertyName = "NextOfKin";
            this.nextOfKinDataGridViewTextBoxColumn.HeaderText = "NextOfKin";
            this.nextOfKinDataGridViewTextBoxColumn.Name = "nextOfKinDataGridViewTextBoxColumn";
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            // 
            // systemAdministratorDataGridViewTextBoxColumn
            // 
            this.systemAdministratorDataGridViewTextBoxColumn.DataPropertyName = "SystemAdministrator";
            this.systemAdministratorDataGridViewTextBoxColumn.HeaderText = "SystemAdministrator";
            this.systemAdministratorDataGridViewTextBoxColumn.Name = "systemAdministratorDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            this.fullNameDataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn1.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            this.fullNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // individualIDDataGridViewTextBoxColumn1
            // 
            this.individualIDDataGridViewTextBoxColumn1.DataPropertyName = "IndividualID";
            this.individualIDDataGridViewTextBoxColumn1.HeaderText = "IndividualID";
            this.individualIDDataGridViewTextBoxColumn1.Name = "individualIDDataGridViewTextBoxColumn1";
            // 
            // titleIDDataGridViewTextBoxColumn1
            // 
            this.titleIDDataGridViewTextBoxColumn1.DataPropertyName = "TitleID";
            this.titleIDDataGridViewTextBoxColumn1.HeaderText = "TitleID";
            this.titleIDDataGridViewTextBoxColumn1.Name = "titleIDDataGridViewTextBoxColumn1";
            // 
            // individualFirstNameDataGridViewTextBoxColumn1
            // 
            this.individualFirstNameDataGridViewTextBoxColumn1.DataPropertyName = "IndividualFirstName";
            this.individualFirstNameDataGridViewTextBoxColumn1.HeaderText = "IndividualFirstName";
            this.individualFirstNameDataGridViewTextBoxColumn1.Name = "individualFirstNameDataGridViewTextBoxColumn1";
            // 
            // individualSecondNameDataGridViewTextBoxColumn1
            // 
            this.individualSecondNameDataGridViewTextBoxColumn1.DataPropertyName = "IndividualSecondName";
            this.individualSecondNameDataGridViewTextBoxColumn1.HeaderText = "IndividualSecondName";
            this.individualSecondNameDataGridViewTextBoxColumn1.Name = "individualSecondNameDataGridViewTextBoxColumn1";
            // 
            // individualLastnameDataGridViewTextBoxColumn1
            // 
            this.individualLastnameDataGridViewTextBoxColumn1.DataPropertyName = "IndividualLastname";
            this.individualLastnameDataGridViewTextBoxColumn1.HeaderText = "IndividualLastname";
            this.individualLastnameDataGridViewTextBoxColumn1.Name = "individualLastnameDataGridViewTextBoxColumn1";
            // 
            // rowVersionDataGridViewImageColumn1
            // 
            this.rowVersionDataGridViewImageColumn1.DataPropertyName = "RowVersion";
            this.rowVersionDataGridViewImageColumn1.HeaderText = "RowVersion";
            this.rowVersionDataGridViewImageColumn1.Name = "rowVersionDataGridViewImageColumn1";
            // 
            // assessorDataGridViewTextBoxColumn1
            // 
            this.assessorDataGridViewTextBoxColumn1.DataPropertyName = "Assessor";
            this.assessorDataGridViewTextBoxColumn1.HeaderText = "Assessor";
            this.assessorDataGridViewTextBoxColumn1.Name = "assessorDataGridViewTextBoxColumn1";
            // 
            // employeeDataGridViewTextBoxColumn1
            // 
            this.employeeDataGridViewTextBoxColumn1.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn1.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn1.Name = "employeeDataGridViewTextBoxColumn1";
            // 
            // facilitatorDataGridViewTextBoxColumn1
            // 
            this.facilitatorDataGridViewTextBoxColumn1.DataPropertyName = "Facilitator";
            this.facilitatorDataGridViewTextBoxColumn1.HeaderText = "Facilitator";
            this.facilitatorDataGridViewTextBoxColumn1.Name = "facilitatorDataGridViewTextBoxColumn1";
            // 
            // lookupTitleDataGridViewTextBoxColumn1
            // 
            this.lookupTitleDataGridViewTextBoxColumn1.DataPropertyName = "LookupTitle";
            this.lookupTitleDataGridViewTextBoxColumn1.HeaderText = "LookupTitle";
            this.lookupTitleDataGridViewTextBoxColumn1.Name = "lookupTitleDataGridViewTextBoxColumn1";
            // 
            // nextOfKinDataGridViewTextBoxColumn1
            // 
            this.nextOfKinDataGridViewTextBoxColumn1.DataPropertyName = "NextOfKin";
            this.nextOfKinDataGridViewTextBoxColumn1.HeaderText = "NextOfKin";
            this.nextOfKinDataGridViewTextBoxColumn1.Name = "nextOfKinDataGridViewTextBoxColumn1";
            // 
            // studentDataGridViewTextBoxColumn1
            // 
            this.studentDataGridViewTextBoxColumn1.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn1.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn1.Name = "studentDataGridViewTextBoxColumn1";
            // 
            // systemAdministratorDataGridViewTextBoxColumn1
            // 
            this.systemAdministratorDataGridViewTextBoxColumn1.DataPropertyName = "SystemAdministrator";
            this.systemAdministratorDataGridViewTextBoxColumn1.HeaderText = "SystemAdministrator";
            this.systemAdministratorDataGridViewTextBoxColumn1.Name = "systemAdministratorDataGridViewTextBoxColumn1";
            // 
            // fullNameDataGridViewTextBoxColumn2
            // 
            this.fullNameDataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn2.Name = "fullNameDataGridViewTextBoxColumn2";
            this.fullNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // individualIDDataGridViewTextBoxColumn2
            // 
            this.individualIDDataGridViewTextBoxColumn2.DataPropertyName = "IndividualID";
            this.individualIDDataGridViewTextBoxColumn2.HeaderText = "IndividualID";
            this.individualIDDataGridViewTextBoxColumn2.Name = "individualIDDataGridViewTextBoxColumn2";
            // 
            // titleIDDataGridViewTextBoxColumn2
            // 
            this.titleIDDataGridViewTextBoxColumn2.DataPropertyName = "TitleID";
            this.titleIDDataGridViewTextBoxColumn2.HeaderText = "TitleID";
            this.titleIDDataGridViewTextBoxColumn2.Name = "titleIDDataGridViewTextBoxColumn2";
            // 
            // individualFirstNameDataGridViewTextBoxColumn2
            // 
            this.individualFirstNameDataGridViewTextBoxColumn2.DataPropertyName = "IndividualFirstName";
            this.individualFirstNameDataGridViewTextBoxColumn2.HeaderText = "IndividualFirstName";
            this.individualFirstNameDataGridViewTextBoxColumn2.Name = "individualFirstNameDataGridViewTextBoxColumn2";
            // 
            // individualSecondNameDataGridViewTextBoxColumn2
            // 
            this.individualSecondNameDataGridViewTextBoxColumn2.DataPropertyName = "IndividualSecondName";
            this.individualSecondNameDataGridViewTextBoxColumn2.HeaderText = "IndividualSecondName";
            this.individualSecondNameDataGridViewTextBoxColumn2.Name = "individualSecondNameDataGridViewTextBoxColumn2";
            // 
            // individualLastnameDataGridViewTextBoxColumn2
            // 
            this.individualLastnameDataGridViewTextBoxColumn2.DataPropertyName = "IndividualLastname";
            this.individualLastnameDataGridViewTextBoxColumn2.HeaderText = "IndividualLastname";
            this.individualLastnameDataGridViewTextBoxColumn2.Name = "individualLastnameDataGridViewTextBoxColumn2";
            // 
            // rowVersionDataGridViewImageColumn2
            // 
            this.rowVersionDataGridViewImageColumn2.DataPropertyName = "RowVersion";
            this.rowVersionDataGridViewImageColumn2.HeaderText = "RowVersion";
            this.rowVersionDataGridViewImageColumn2.Name = "rowVersionDataGridViewImageColumn2";
            // 
            // assessorDataGridViewTextBoxColumn2
            // 
            this.assessorDataGridViewTextBoxColumn2.DataPropertyName = "Assessor";
            this.assessorDataGridViewTextBoxColumn2.HeaderText = "Assessor";
            this.assessorDataGridViewTextBoxColumn2.Name = "assessorDataGridViewTextBoxColumn2";
            // 
            // employeeDataGridViewTextBoxColumn2
            // 
            this.employeeDataGridViewTextBoxColumn2.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn2.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn2.Name = "employeeDataGridViewTextBoxColumn2";
            // 
            // facilitatorDataGridViewTextBoxColumn2
            // 
            this.facilitatorDataGridViewTextBoxColumn2.DataPropertyName = "Facilitator";
            this.facilitatorDataGridViewTextBoxColumn2.HeaderText = "Facilitator";
            this.facilitatorDataGridViewTextBoxColumn2.Name = "facilitatorDataGridViewTextBoxColumn2";
            // 
            // lookupTitleDataGridViewTextBoxColumn2
            // 
            this.lookupTitleDataGridViewTextBoxColumn2.DataPropertyName = "LookupTitle";
            this.lookupTitleDataGridViewTextBoxColumn2.HeaderText = "LookupTitle";
            this.lookupTitleDataGridViewTextBoxColumn2.Name = "lookupTitleDataGridViewTextBoxColumn2";
            // 
            // nextOfKinDataGridViewTextBoxColumn2
            // 
            this.nextOfKinDataGridViewTextBoxColumn2.DataPropertyName = "NextOfKin";
            this.nextOfKinDataGridViewTextBoxColumn2.HeaderText = "NextOfKin";
            this.nextOfKinDataGridViewTextBoxColumn2.Name = "nextOfKinDataGridViewTextBoxColumn2";
            // 
            // studentDataGridViewTextBoxColumn2
            // 
            this.studentDataGridViewTextBoxColumn2.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn2.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn2.Name = "studentDataGridViewTextBoxColumn2";
            // 
            // systemAdministratorDataGridViewTextBoxColumn2
            // 
            this.systemAdministratorDataGridViewTextBoxColumn2.DataPropertyName = "SystemAdministrator";
            this.systemAdministratorDataGridViewTextBoxColumn2.HeaderText = "SystemAdministrator";
            this.systemAdministratorDataGridViewTextBoxColumn2.Name = "systemAdministratorDataGridViewTextBoxColumn2";
            // 
            // fullNameDataGridViewTextBoxColumn3
            // 
            this.fullNameDataGridViewTextBoxColumn3.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn3.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn3.Name = "fullNameDataGridViewTextBoxColumn3";
            this.fullNameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // individualIDDataGridViewTextBoxColumn3
            // 
            this.individualIDDataGridViewTextBoxColumn3.DataPropertyName = "IndividualID";
            this.individualIDDataGridViewTextBoxColumn3.HeaderText = "IndividualID";
            this.individualIDDataGridViewTextBoxColumn3.Name = "individualIDDataGridViewTextBoxColumn3";
            // 
            // titleIDDataGridViewTextBoxColumn3
            // 
            this.titleIDDataGridViewTextBoxColumn3.DataPropertyName = "TitleID";
            this.titleIDDataGridViewTextBoxColumn3.HeaderText = "TitleID";
            this.titleIDDataGridViewTextBoxColumn3.Name = "titleIDDataGridViewTextBoxColumn3";
            // 
            // individualFirstNameDataGridViewTextBoxColumn3
            // 
            this.individualFirstNameDataGridViewTextBoxColumn3.DataPropertyName = "IndividualFirstName";
            this.individualFirstNameDataGridViewTextBoxColumn3.HeaderText = "IndividualFirstName";
            this.individualFirstNameDataGridViewTextBoxColumn3.Name = "individualFirstNameDataGridViewTextBoxColumn3";
            // 
            // individualSecondNameDataGridViewTextBoxColumn3
            // 
            this.individualSecondNameDataGridViewTextBoxColumn3.DataPropertyName = "IndividualSecondName";
            this.individualSecondNameDataGridViewTextBoxColumn3.HeaderText = "IndividualSecondName";
            this.individualSecondNameDataGridViewTextBoxColumn3.Name = "individualSecondNameDataGridViewTextBoxColumn3";
            // 
            // individualLastnameDataGridViewTextBoxColumn3
            // 
            this.individualLastnameDataGridViewTextBoxColumn3.DataPropertyName = "IndividualLastname";
            this.individualLastnameDataGridViewTextBoxColumn3.HeaderText = "IndividualLastname";
            this.individualLastnameDataGridViewTextBoxColumn3.Name = "individualLastnameDataGridViewTextBoxColumn3";
            // 
            // rowVersionDataGridViewImageColumn3
            // 
            this.rowVersionDataGridViewImageColumn3.DataPropertyName = "RowVersion";
            this.rowVersionDataGridViewImageColumn3.HeaderText = "RowVersion";
            this.rowVersionDataGridViewImageColumn3.Name = "rowVersionDataGridViewImageColumn3";
            // 
            // assessorDataGridViewTextBoxColumn3
            // 
            this.assessorDataGridViewTextBoxColumn3.DataPropertyName = "Assessor";
            this.assessorDataGridViewTextBoxColumn3.HeaderText = "Assessor";
            this.assessorDataGridViewTextBoxColumn3.Name = "assessorDataGridViewTextBoxColumn3";
            // 
            // employeeDataGridViewTextBoxColumn3
            // 
            this.employeeDataGridViewTextBoxColumn3.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn3.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn3.Name = "employeeDataGridViewTextBoxColumn3";
            // 
            // facilitatorDataGridViewTextBoxColumn3
            // 
            this.facilitatorDataGridViewTextBoxColumn3.DataPropertyName = "Facilitator";
            this.facilitatorDataGridViewTextBoxColumn3.HeaderText = "Facilitator";
            this.facilitatorDataGridViewTextBoxColumn3.Name = "facilitatorDataGridViewTextBoxColumn3";
            // 
            // lookupTitleDataGridViewTextBoxColumn3
            // 
            this.lookupTitleDataGridViewTextBoxColumn3.DataPropertyName = "LookupTitle";
            this.lookupTitleDataGridViewTextBoxColumn3.HeaderText = "LookupTitle";
            this.lookupTitleDataGridViewTextBoxColumn3.Name = "lookupTitleDataGridViewTextBoxColumn3";
            // 
            // nextOfKinDataGridViewTextBoxColumn3
            // 
            this.nextOfKinDataGridViewTextBoxColumn3.DataPropertyName = "NextOfKin";
            this.nextOfKinDataGridViewTextBoxColumn3.HeaderText = "NextOfKin";
            this.nextOfKinDataGridViewTextBoxColumn3.Name = "nextOfKinDataGridViewTextBoxColumn3";
            // 
            // studentDataGridViewTextBoxColumn3
            // 
            this.studentDataGridViewTextBoxColumn3.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn3.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn3.Name = "studentDataGridViewTextBoxColumn3";
            // 
            // systemAdministratorDataGridViewTextBoxColumn3
            // 
            this.systemAdministratorDataGridViewTextBoxColumn3.DataPropertyName = "SystemAdministrator";
            this.systemAdministratorDataGridViewTextBoxColumn3.HeaderText = "SystemAdministrator";
            this.systemAdministratorDataGridViewTextBoxColumn3.Name = "systemAdministratorDataGridViewTextBoxColumn3";
            // 
            // companiesInprogressBindingSource
            // 
            this.companiesInprogressBindingSource.DataMember = "Companies";
            this.companiesInprogressBindingSource.DataSource = this.individualsInprogressBindingSource;
            // 
            // enquiryInprogressBindingSource
            // 
            this.enquiryInprogressBindingSource.DataSource = typeof(Impendulo.Data.Models.Enquiry);
            this.enquiryInprogressBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.enquiryInprogressBindingSource_BindingComplete);
            // 
            // fullNameDataGridViewTextBoxColumn4
            // 
            this.fullNameDataGridViewTextBoxColumn4.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn4.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn4.Name = "fullNameDataGridViewTextBoxColumn4";
            this.fullNameDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // individualIDDataGridViewTextBoxColumn4
            // 
            this.individualIDDataGridViewTextBoxColumn4.DataPropertyName = "IndividualID";
            this.individualIDDataGridViewTextBoxColumn4.HeaderText = "IndividualID";
            this.individualIDDataGridViewTextBoxColumn4.Name = "individualIDDataGridViewTextBoxColumn4";
            // 
            // titleIDDataGridViewTextBoxColumn4
            // 
            this.titleIDDataGridViewTextBoxColumn4.DataPropertyName = "TitleID";
            this.titleIDDataGridViewTextBoxColumn4.HeaderText = "TitleID";
            this.titleIDDataGridViewTextBoxColumn4.Name = "titleIDDataGridViewTextBoxColumn4";
            // 
            // individualFirstNameDataGridViewTextBoxColumn4
            // 
            this.individualFirstNameDataGridViewTextBoxColumn4.DataPropertyName = "IndividualFirstName";
            this.individualFirstNameDataGridViewTextBoxColumn4.HeaderText = "IndividualFirstName";
            this.individualFirstNameDataGridViewTextBoxColumn4.Name = "individualFirstNameDataGridViewTextBoxColumn4";
            // 
            // individualSecondNameDataGridViewTextBoxColumn4
            // 
            this.individualSecondNameDataGridViewTextBoxColumn4.DataPropertyName = "IndividualSecondName";
            this.individualSecondNameDataGridViewTextBoxColumn4.HeaderText = "IndividualSecondName";
            this.individualSecondNameDataGridViewTextBoxColumn4.Name = "individualSecondNameDataGridViewTextBoxColumn4";
            // 
            // individualLastnameDataGridViewTextBoxColumn4
            // 
            this.individualLastnameDataGridViewTextBoxColumn4.DataPropertyName = "IndividualLastname";
            this.individualLastnameDataGridViewTextBoxColumn4.HeaderText = "IndividualLastname";
            this.individualLastnameDataGridViewTextBoxColumn4.Name = "individualLastnameDataGridViewTextBoxColumn4";
            // 
            // rowVersionDataGridViewImageColumn4
            // 
            this.rowVersionDataGridViewImageColumn4.DataPropertyName = "RowVersion";
            this.rowVersionDataGridViewImageColumn4.HeaderText = "RowVersion";
            this.rowVersionDataGridViewImageColumn4.Name = "rowVersionDataGridViewImageColumn4";
            // 
            // assessorDataGridViewTextBoxColumn4
            // 
            this.assessorDataGridViewTextBoxColumn4.DataPropertyName = "Assessor";
            this.assessorDataGridViewTextBoxColumn4.HeaderText = "Assessor";
            this.assessorDataGridViewTextBoxColumn4.Name = "assessorDataGridViewTextBoxColumn4";
            // 
            // employeeDataGridViewTextBoxColumn4
            // 
            this.employeeDataGridViewTextBoxColumn4.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn4.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn4.Name = "employeeDataGridViewTextBoxColumn4";
            // 
            // facilitatorDataGridViewTextBoxColumn4
            // 
            this.facilitatorDataGridViewTextBoxColumn4.DataPropertyName = "Facilitator";
            this.facilitatorDataGridViewTextBoxColumn4.HeaderText = "Facilitator";
            this.facilitatorDataGridViewTextBoxColumn4.Name = "facilitatorDataGridViewTextBoxColumn4";
            // 
            // lookupTitleDataGridViewTextBoxColumn4
            // 
            this.lookupTitleDataGridViewTextBoxColumn4.DataPropertyName = "LookupTitle";
            this.lookupTitleDataGridViewTextBoxColumn4.HeaderText = "LookupTitle";
            this.lookupTitleDataGridViewTextBoxColumn4.Name = "lookupTitleDataGridViewTextBoxColumn4";
            // 
            // nextOfKinDataGridViewTextBoxColumn4
            // 
            this.nextOfKinDataGridViewTextBoxColumn4.DataPropertyName = "NextOfKin";
            this.nextOfKinDataGridViewTextBoxColumn4.HeaderText = "NextOfKin";
            this.nextOfKinDataGridViewTextBoxColumn4.Name = "nextOfKinDataGridViewTextBoxColumn4";
            // 
            // studentDataGridViewTextBoxColumn4
            // 
            this.studentDataGridViewTextBoxColumn4.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn4.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn4.Name = "studentDataGridViewTextBoxColumn4";
            // 
            // systemAdministratorDataGridViewTextBoxColumn4
            // 
            this.systemAdministratorDataGridViewTextBoxColumn4.DataPropertyName = "SystemAdministrator";
            this.systemAdministratorDataGridViewTextBoxColumn4.HeaderText = "SystemAdministrator";
            this.systemAdministratorDataGridViewTextBoxColumn4.Name = "systemAdministratorDataGridViewTextBoxColumn4";
            // 
            // contactDetailValueDataGridViewTextBoxColumn
            // 
            this.contactDetailValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contactDetailValueDataGridViewTextBoxColumn.DataPropertyName = "ContactDetailValue";
            this.contactDetailValueDataGridViewTextBoxColumn.HeaderText = "Contact Detail";
            this.contactDetailValueDataGridViewTextBoxColumn.MinimumWidth = 105;
            this.contactDetailValueDataGridViewTextBoxColumn.Name = "contactDetailValueDataGridViewTextBoxColumn";
            this.contactDetailValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactDetailValueDataGridViewTextBoxColumn.Width = 105;
            // 
            // lastUpdatedDataGridViewTextBoxColumn
            // 
            this.lastUpdatedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.HeaderText = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.Name = "lastUpdatedDataGridViewTextBoxColumn";
            this.lastUpdatedDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastUpdatedDataGridViewTextBoxColumn.Width = 95;
            // 
            // enrollmentQuanityDataGridViewTextBoxColumn
            // 
            this.enrollmentQuanityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.enrollmentQuanityDataGridViewTextBoxColumn.DataPropertyName = "EnrollmentQuanity";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.enrollmentQuanityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.enrollmentQuanityDataGridViewTextBoxColumn.HeaderText = "Qty To Enroll";
            this.enrollmentQuanityDataGridViewTextBoxColumn.Name = "enrollmentQuanityDataGridViewTextBoxColumn";
            this.enrollmentQuanityDataGridViewTextBoxColumn.ReadOnly = true;
            this.enrollmentQuanityDataGridViewTextBoxColumn.Width = 94;
            // 
            // frmClientEnquiry
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(849, 558);
            this.Controls.Add(this.metroTabControl1);
            this.DisplayHeader = false;
            this.Name = "frmClientEnquiry";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Client Enquiry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClientEnquiry_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbInprogressContactNameAndCompanyName.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualsInprogressBindingSource)).EndInit();
            this.gbInProgressContactDetails.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInprogressContactDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDetailsInprogressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.gbInProgressEnquiryEnrrolmentQueries.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProgressCurriculumEnquiries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumEnquiryInprogressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryInprogressBindingNavigator)).EndInit();
            this.enquiryInprogressBindingNavigator.ResumeLayout(false);
            this.enquiryInprogressBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesInprogressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryInprogressBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingNavigator enquiryInprogressBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource enquiryInprogressBindingSource;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbInProgressEnquiryEnrrolmentQueries;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private MetroFramework.Controls.MetroGrid dgvInProgressCurriculumEnquiries;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTile btnSearchForEnquiry;
        private System.Windows.Forms.TextBox txtEnquiryInProgressEnquiryID;
        private System.Windows.Forms.BindingSource individualsInprogressBindingSource;
        private System.Windows.Forms.GroupBox gbInProgressContactDetails;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private MetroFramework.Controls.MetroGrid dgvInprogressContactDetails;
        private System.Windows.Forms.BindingSource contactDetailsInprogressBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnAddContactDetail;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton btnRemoveContactDetail;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.GroupBox gbInprogressContactNameAndCompanyName;
        private System.Windows.Forms.BindingSource companiesInprogressBindingSource;
        private System.Windows.Forms.BindingSource curriculumEnquiryInprogressBindingSource;
        private System.Windows.Forms.TextBox enquiryDateTextBox;
        private System.Windows.Forms.TextBox txtInprogressCompanyName;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private MetroFramework.Controls.MetroTile btnViewProgressInProgressSections;
        private MetroFramework.Controls.MetroTile btnInProgressSwitchBetweenCompanyANdPrivate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualSecondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn rowVersionDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilitatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lookupTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextOfKinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemAdministratorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTile btnCloseInprogressEnquiry;
        private MetroFramework.Controls.MetroTile btnInitialConsultationConfirmationInProgressSection;
        private System.Windows.Forms.CheckBox initialConsultationCompleteCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInProgressContactType;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDetailValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn colInProgressContactDetailSendOption;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnuUpdateContactDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroTile btnInProgressChangeContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualFirstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualSecondNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualLastnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn rowVersionDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilitatorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lookupTitleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextOfKinDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemAdministratorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btrnInProgressSendInitialDocumentation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualFirstNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualSecondNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualLastnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn rowVersionDataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessorDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilitatorDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lookupTitleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextOfKinDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemAdministratorDataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripButton btnUpdateCurriculumEnquiryItemEnrollmentQty;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualFirstNameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualSecondNameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualLastnameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn rowVersionDataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessorDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilitatorDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lookupTitleDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextOfKinDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemAdministratorDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn colInProgressEnquiryCloseCurriculumEnquiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInProgressCurriculumDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInProgressCurriculumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentQuanityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInProgressEnquiryQuantityCurrentlyEnrolled;
        private System.Windows.Forms.DataGridViewLinkColumn colInProgressProcessEnrollment;
        private System.Windows.Forms.DataGridViewLinkColumn colInProgressViewCurrentEnrollment;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualIDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleIDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualFirstNameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualSecondNameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualLastnameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn rowVersionDataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessorDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilitatorDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn lookupTitleDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextOfKinDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemAdministratorDataGridViewTextBoxColumn4;
    }
}