namespace Impendulo.Enquiry.Development.SearchForSelectedEnquiry
{
    partial class frmSearchForSelectedEquiry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchForSelectedEquiry));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dgvEquirySearchResults = new MetroFramework.Controls.MetroGrid();
            this.colSelect = new System.Windows.Forms.DataGridViewLinkColumn();
            this.enquiryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialConsultationCompleteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.enquiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enquiryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panelStudentSearchResults = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbSearchForStudent = new System.Windows.Forms.GroupBox();
            this.txtContactName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.cboDepartment = new MetroFramework.Controls.MetroComboBox();
            this.lookupDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cboCurriculum = new MetroFramework.Controls.MetroComboBox();
            this.curriculumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEquiryRef = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.datToDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.datFromDate = new MetroFramework.Controls.MetroDateTime();
            this.individualsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquirySearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panelStudentSearchResults.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbSearchForStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvEquirySearchResults);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(770, 227);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 16);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(770, 252);
            this.toolStripContainer1.TabIndex = 11;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.bindingNavigator1);
            // 
            // dgvEquirySearchResults
            // 
            this.dgvEquirySearchResults.AllowUserToAddRows = false;
            this.dgvEquirySearchResults.AllowUserToDeleteRows = false;
            this.dgvEquirySearchResults.AllowUserToResizeRows = false;
            this.dgvEquirySearchResults.AutoGenerateColumns = false;
            this.dgvEquirySearchResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEquirySearchResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquirySearchResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEquirySearchResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquirySearchResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvEquirySearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquirySearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.enquiryIDDataGridViewTextBoxColumn,
            this.initialConsultationCompleteDataGridViewCheckBoxColumn,
            this.enquiryDateDataGridViewTextBoxColumn});
            this.dgvEquirySearchResults.DataSource = this.enquiryBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquirySearchResults.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvEquirySearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEquirySearchResults.EnableHeadersVisualStyles = false;
            this.dgvEquirySearchResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvEquirySearchResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEquirySearchResults.Location = new System.Drawing.Point(0, 0);
            this.dgvEquirySearchResults.Name = "dgvEquirySearchResults";
            this.dgvEquirySearchResults.ReadOnly = true;
            this.dgvEquirySearchResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquirySearchResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvEquirySearchResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEquirySearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquirySearchResults.Size = new System.Drawing.Size(770, 227);
            this.dgvEquirySearchResults.TabIndex = 0;
            this.dgvEquirySearchResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquirySearchResults_CellContentClick);
            // 
            // colSelect
            // 
            this.colSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSelect.HeaderText = "";
            this.colSelect.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colSelect.Name = "colSelect";
            this.colSelect.ReadOnly = true;
            this.colSelect.Text = "Select Enquiry";
            this.colSelect.TrackVisitedState = false;
            this.colSelect.UseColumnTextForLinkValue = true;
            this.colSelect.Width = 5;
            // 
            // enquiryIDDataGridViewTextBoxColumn
            // 
            this.enquiryIDDataGridViewTextBoxColumn.DataPropertyName = "EnquiryID";
            this.enquiryIDDataGridViewTextBoxColumn.HeaderText = "Enquiry Ref#";
            this.enquiryIDDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.enquiryIDDataGridViewTextBoxColumn.Name = "enquiryIDDataGridViewTextBoxColumn";
            this.enquiryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // initialConsultationCompleteDataGridViewCheckBoxColumn
            // 
            this.initialConsultationCompleteDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.initialConsultationCompleteDataGridViewCheckBoxColumn.DataPropertyName = "InitialConsultationComplete";
            this.initialConsultationCompleteDataGridViewCheckBoxColumn.HeaderText = "Initial Complete";
            this.initialConsultationCompleteDataGridViewCheckBoxColumn.MinimumWidth = 105;
            this.initialConsultationCompleteDataGridViewCheckBoxColumn.Name = "initialConsultationCompleteDataGridViewCheckBoxColumn";
            this.initialConsultationCompleteDataGridViewCheckBoxColumn.ReadOnly = true;
            this.initialConsultationCompleteDataGridViewCheckBoxColumn.Width = 105;
            // 
            // enquiryDateDataGridViewTextBoxColumn
            // 
            this.enquiryDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.enquiryDateDataGridViewTextBoxColumn.DataPropertyName = "EnquiryDate";
            this.enquiryDateDataGridViewTextBoxColumn.HeaderText = "Date Created";
            this.enquiryDateDataGridViewTextBoxColumn.Name = "enquiryDateDataGridViewTextBoxColumn";
            this.enquiryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enquiryBindingSource
            // 
            this.enquiryBindingSource.DataSource = typeof(Impendulo.Data.Models.Enquiry);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(770, 25);
            this.bindingNavigator1.Stretch = true;
            this.bindingNavigator1.TabIndex = 0;
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
            // panelStudentSearchResults
            // 
            this.panelStudentSearchResults.Controls.Add(this.groupBox2);
            this.panelStudentSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStudentSearchResults.Location = new System.Drawing.Point(20, 252);
            this.panelStudentSearchResults.Name = "panelStudentSearchResults";
            this.panelStudentSearchResults.Size = new System.Drawing.Size(776, 271);
            this.panelStudentSearchResults.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStripContainer1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 271);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // gbSearchForStudent
            // 
            this.gbSearchForStudent.Controls.Add(this.txtContactName);
            this.gbSearchForStudent.Controls.Add(this.metroLabel6);
            this.gbSearchForStudent.Controls.Add(this.metroTile2);
            this.gbSearchForStudent.Controls.Add(this.metroTile1);
            this.gbSearchForStudent.Controls.Add(this.cboDepartment);
            this.gbSearchForStudent.Controls.Add(this.metroLabel5);
            this.gbSearchForStudent.Controls.Add(this.cboCurriculum);
            this.gbSearchForStudent.Controls.Add(this.txtEquiryRef);
            this.gbSearchForStudent.Controls.Add(this.metroLabel4);
            this.gbSearchForStudent.Controls.Add(this.metroLabel3);
            this.gbSearchForStudent.Controls.Add(this.metroLabel2);
            this.gbSearchForStudent.Controls.Add(this.datToDate);
            this.gbSearchForStudent.Controls.Add(this.metroLabel1);
            this.gbSearchForStudent.Controls.Add(this.datFromDate);
            this.gbSearchForStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchForStudent.Location = new System.Drawing.Point(20, 60);
            this.gbSearchForStudent.Name = "gbSearchForStudent";
            this.gbSearchForStudent.Size = new System.Drawing.Size(776, 192);
            this.gbSearchForStudent.TabIndex = 13;
            this.gbSearchForStudent.TabStop = false;
            this.gbSearchForStudent.Text = "Search Fields";
            // 
            // txtContactName
            // 
            this.txtContactName.Lines = new string[0];
            this.txtContactName.Location = new System.Drawing.Point(120, 123);
            this.txtContactName.MaxLength = 32767;
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.PasswordChar = '\0';
            this.txtContactName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContactName.SelectedText = "";
            this.txtContactName.Size = new System.Drawing.Size(426, 23);
            this.txtContactName.TabIndex = 26;
            this.txtContactName.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(17, 123);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(97, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Contact Name:";
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.Location = new System.Drawing.Point(357, 24);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(93, 93);
            this.metroTile2.TabIndex = 24;
            this.metroTile2.Text = "Search";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(453, 24);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(93, 93);
            this.metroTile1.TabIndex = 23;
            this.metroTile1.Text = "Refresh";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // cboDepartment
            // 
            this.cboDepartment.DataSource = this.lookupDepartmentBindingSource;
            this.cboDepartment.DisplayMember = "DepartmentName";
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.ItemHeight = 23;
            this.cboDepartment.Location = new System.Drawing.Point(120, 53);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(230, 29);
            this.cboDepartment.TabIndex = 22;
            this.cboDepartment.UseSelectable = true;
            this.cboDepartment.ValueMember = "DepartmentID";
            // 
            // lookupDepartmentBindingSource
            // 
            this.lookupDepartmentBindingSource.DataSource = typeof(Impendulo.Data.Models.LookupDepartment);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(16, 57);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Department:";
            // 
            // cboCurriculum
            // 
            this.cboCurriculum.DataSource = this.curriculumBindingSource;
            this.cboCurriculum.DisplayMember = "CurriculumName";
            this.cboCurriculum.FormattingEnabled = true;
            this.cboCurriculum.ItemHeight = 23;
            this.cboCurriculum.Location = new System.Drawing.Point(120, 88);
            this.cboCurriculum.Name = "cboCurriculum";
            this.cboCurriculum.Size = new System.Drawing.Size(230, 29);
            this.cboCurriculum.TabIndex = 20;
            this.cboCurriculum.UseSelectable = true;
            this.cboCurriculum.ValueMember = "CurriculumID";
            // 
            // curriculumBindingSource
            // 
            this.curriculumBindingSource.DataSource = typeof(Impendulo.Data.Models.Curriculum);
            // 
            // txtEquiryRef
            // 
            this.txtEquiryRef.Lines = new string[0];
            this.txtEquiryRef.Location = new System.Drawing.Point(120, 24);
            this.txtEquiryRef.MaxLength = 32767;
            this.txtEquiryRef.Name = "txtEquiryRef";
            this.txtEquiryRef.PasswordChar = '\0';
            this.txtEquiryRef.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEquiryRef.SelectedText = "";
            this.txtEquiryRef.Size = new System.Drawing.Size(231, 23);
            this.txtEquiryRef.TabIndex = 19;
            this.txtEquiryRef.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 157);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(140, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Enquiry Date Between:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 24);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Enquiry Ref:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Cuuriculum:";
            // 
            // datToDate
            // 
            this.datToDate.Location = new System.Drawing.Point(372, 152);
            this.datToDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.datToDate.Name = "datToDate";
            this.datToDate.Size = new System.Drawing.Size(174, 29);
            this.datToDate.TabIndex = 15;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(335, 157);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(31, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "and";
            // 
            // datFromDate
            // 
            this.datFromDate.Location = new System.Drawing.Point(160, 152);
            this.datFromDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.datFromDate.Name = "datFromDate";
            this.datFromDate.Size = new System.Drawing.Size(169, 29);
            this.datFromDate.TabIndex = 13;
            // 
            // individualsBindingSource
            // 
            this.individualsBindingSource.DataMember = "Individuals";
            this.individualsBindingSource.DataSource = this.enquiryBindingSource;
            // 
            // frmSearchForSelectedEquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 543);
            this.Controls.Add(this.panelStudentSearchResults);
            this.Controls.Add(this.gbSearchForStudent);
            this.Name = "frmSearchForSelectedEquiry";
            this.Text = "Select Equiry";
            this.Load += new System.EventHandler(this.frmSearchForSelectedEquiry_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquirySearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panelStudentSearchResults.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbSearchForStudent.ResumeLayout(false);
            this.gbSearchForStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private MetroFramework.Controls.MetroGrid dgvEquirySearchResults;
        private System.Windows.Forms.BindingSource enquiryBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panelStudentSearchResults;
        private System.Windows.Forms.GroupBox gbSearchForStudent;
        private System.Windows.Forms.BindingSource individualsBindingSource;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroComboBox cboDepartment;
        private System.Windows.Forms.BindingSource curriculumBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cboCurriculum;
        private MetroFramework.Controls.MetroTextBox txtEquiryRef;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime datToDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime datFromDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtContactName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.BindingSource lookupDepartmentBindingSource;
        private System.Windows.Forms.DataGridViewLinkColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn enquiryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn initialConsultationCompleteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enquiryDateDataGridViewTextBoxColumn;
    }
}