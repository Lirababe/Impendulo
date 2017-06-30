namespace Impendulo.Enquiry.Deployment.ViewHistory
{
    partial class frmEquiryViewHistory
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
            System.Windows.Forms.Label dateEnquiryUpdatedLabel;
            System.Windows.Forms.Label enqueryHistoryIDLabel;
            System.Windows.Forms.Label enquiryNotesLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label lookupEquiyHistoryTypeNameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquiryViewHistory));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.equiryHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lookupEquiyHistoryTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.dateEnquiryUpdatedTextBox = new System.Windows.Forms.TextBox();
            this.enqueryHistoryIDTextBox = new System.Windows.Forms.TextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dgvEnquiryHistory = new MetroFramework.Controls.MetroGrid();
            this.enqueryHistoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnquiryUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActionPerformed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enquiryNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equiryHistoriesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            dateEnquiryUpdatedLabel = new System.Windows.Forms.Label();
            enqueryHistoryIDLabel = new System.Windows.Forms.Label();
            enquiryNotesLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            lookupEquiyHistoryTypeNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equiryHistoryBindingSource)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnquiryHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiryHistoriesBindingNavigator)).BeginInit();
            this.equiryHistoriesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateEnquiryUpdatedLabel
            // 
            dateEnquiryUpdatedLabel.AutoSize = true;
            dateEnquiryUpdatedLabel.Location = new System.Drawing.Point(27, 35);
            dateEnquiryUpdatedLabel.Name = "dateEnquiryUpdatedLabel";
            dateEnquiryUpdatedLabel.Size = new System.Drawing.Size(162, 13);
            dateEnquiryUpdatedLabel.TabIndex = 0;
            dateEnquiryUpdatedLabel.Text = "Date Last Action Was Performed";
            // 
            // enqueryHistoryIDLabel
            // 
            enqueryHistoryIDLabel.AutoSize = true;
            enqueryHistoryIDLabel.Location = new System.Drawing.Point(123, 9);
            enqueryHistoryIDLabel.Name = "enqueryHistoryIDLabel";
            enqueryHistoryIDLabel.Size = new System.Drawing.Size(66, 13);
            enqueryHistoryIDLabel.TabIndex = 4;
            enqueryHistoryIDLabel.Text = "History Ref#";
            // 
            // enquiryNotesLabel
            // 
            enquiryNotesLabel.AutoSize = true;
            enquiryNotesLabel.Location = new System.Drawing.Point(77, 113);
            enquiryNotesLabel.Name = "enquiryNotesLabel";
            enquiryNotesLabel.Size = new System.Drawing.Size(112, 13);
            enquiryNotesLabel.TabIndex = 6;
            enquiryNotesLabel.Text = "Note or Details Noted:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(15, 61);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(174, 13);
            fullNameLabel.TabIndex = 8;
            fullNameLabel.Text = "Last Person that Perform the Action";
            // 
            // lookupEquiyHistoryTypeNameLabel
            // 
            lookupEquiyHistoryTypeNameLabel.AutoSize = true;
            lookupEquiyHistoryTypeNameLabel.Location = new System.Drawing.Point(75, 87);
            lookupEquiyHistoryTypeNameLabel.Name = "lookupEquiyHistoryTypeNameLabel";
            lookupEquiyHistoryTypeNameLabel.Size = new System.Drawing.Size(114, 13);
            lookupEquiyHistoryTypeNameLabel.TabIndex = 10;
            lookupEquiyHistoryTypeNameLabel.Text = "Last Action Performed:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel1.Controls.Add(lookupEquiyHistoryTypeNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.lookupEquiyHistoryTypeNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(fullNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.fullNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(dateEnquiryUpdatedLabel);
            this.splitContainer1.Panel1.Controls.Add(this.dateEnquiryUpdatedTextBox);
            this.splitContainer1.Panel1.Controls.Add(enqueryHistoryIDLabel);
            this.splitContainer1.Panel1.Controls.Add(this.enqueryHistoryIDTextBox);
            this.splitContainer1.Panel1.Controls.Add(enquiryNotesLabel);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.toolStripContainer1);
            this.splitContainer1.Size = new System.Drawing.Size(835, 402);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiryHistoryBindingSource, "EnquiryNotes", true));
            this.richTextBox1.Location = new System.Drawing.Point(195, 110);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(470, 75);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // equiryHistoryBindingSource
            // 
            this.equiryHistoryBindingSource.DataSource = typeof(Impendulo.Data.Models.EquiryHistory);
            // 
            // lookupEquiyHistoryTypeNameTextBox
            // 
            this.lookupEquiyHistoryTypeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiryHistoryBindingSource, "LookupEquiryHistoryType.LookupEquiyHistoryTypeName", true));
            this.lookupEquiyHistoryTypeNameTextBox.Location = new System.Drawing.Point(195, 84);
            this.lookupEquiyHistoryTypeNameTextBox.Name = "lookupEquiyHistoryTypeNameTextBox";
            this.lookupEquiyHistoryTypeNameTextBox.Size = new System.Drawing.Size(470, 20);
            this.lookupEquiyHistoryTypeNameTextBox.TabIndex = 11;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiryHistoryBindingSource, "Employee.Individual.FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(195, 58);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(470, 20);
            this.fullNameTextBox.TabIndex = 9;
            // 
            // dateEnquiryUpdatedTextBox
            // 
            this.dateEnquiryUpdatedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiryHistoryBindingSource, "DateEnquiryUpdated", true));
            this.dateEnquiryUpdatedTextBox.Location = new System.Drawing.Point(195, 32);
            this.dateEnquiryUpdatedTextBox.Name = "dateEnquiryUpdatedTextBox";
            this.dateEnquiryUpdatedTextBox.Size = new System.Drawing.Size(138, 20);
            this.dateEnquiryUpdatedTextBox.TabIndex = 1;
            // 
            // enqueryHistoryIDTextBox
            // 
            this.enqueryHistoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiryHistoryBindingSource, "EnqueryHistoryID", true));
            this.enqueryHistoryIDTextBox.Location = new System.Drawing.Point(195, 6);
            this.enqueryHistoryIDTextBox.Name = "enqueryHistoryIDTextBox";
            this.enqueryHistoryIDTextBox.Size = new System.Drawing.Size(138, 20);
            this.enqueryHistoryIDTextBox.TabIndex = 5;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvEnquiryHistory);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(835, 169);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(835, 202);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.equiryHistoriesBindingNavigator);
            // 
            // dgvEnquiryHistory
            // 
            this.dgvEnquiryHistory.AllowUserToAddRows = false;
            this.dgvEnquiryHistory.AllowUserToDeleteRows = false;
            this.dgvEnquiryHistory.AllowUserToResizeRows = false;
            this.dgvEnquiryHistory.AutoGenerateColumns = false;
            this.dgvEnquiryHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEnquiryHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEnquiryHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEnquiryHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEnquiryHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEnquiryHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnquiryHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enqueryHistoryIDDataGridViewTextBoxColumn,
            this.dateEnquiryUpdatedDataGridViewTextBoxColumn,
            this.colEmployeName,
            this.colActionPerformed,
            this.enquiryNotesDataGridViewTextBoxColumn});
            this.dgvEnquiryHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvEnquiryHistory.DataSource = this.equiryHistoryBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEnquiryHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEnquiryHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnquiryHistory.EnableHeadersVisualStyles = false;
            this.dgvEnquiryHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvEnquiryHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEnquiryHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvEnquiryHistory.Name = "dgvEnquiryHistory";
            this.dgvEnquiryHistory.ReadOnly = true;
            this.dgvEnquiryHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEnquiryHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEnquiryHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEnquiryHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnquiryHistory.Size = new System.Drawing.Size(835, 169);
            this.dgvEnquiryHistory.TabIndex = 0;
            this.dgvEnquiryHistory.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEnquiryHistory_DataBindingComplete);
            // 
            // enqueryHistoryIDDataGridViewTextBoxColumn
            // 
            this.enqueryHistoryIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.enqueryHistoryIDDataGridViewTextBoxColumn.DataPropertyName = "EnqueryHistoryID";
            this.enqueryHistoryIDDataGridViewTextBoxColumn.HeaderText = "REF#";
            this.enqueryHistoryIDDataGridViewTextBoxColumn.Name = "enqueryHistoryIDDataGridViewTextBoxColumn";
            this.enqueryHistoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.enqueryHistoryIDDataGridViewTextBoxColumn.Width = 56;
            // 
            // dateEnquiryUpdatedDataGridViewTextBoxColumn
            // 
            this.dateEnquiryUpdatedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateEnquiryUpdatedDataGridViewTextBoxColumn.DataPropertyName = "DateEnquiryUpdated";
            this.dateEnquiryUpdatedDataGridViewTextBoxColumn.HeaderText = "Date Performed";
            this.dateEnquiryUpdatedDataGridViewTextBoxColumn.Name = "dateEnquiryUpdatedDataGridViewTextBoxColumn";
            this.dateEnquiryUpdatedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateEnquiryUpdatedDataGridViewTextBoxColumn.Width = 101;
            // 
            // colEmployeName
            // 
            this.colEmployeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEmployeName.HeaderText = "Employee";
            this.colEmployeName.Name = "colEmployeName";
            this.colEmployeName.ReadOnly = true;
            this.colEmployeName.Width = 79;
            // 
            // colActionPerformed
            // 
            this.colActionPerformed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colActionPerformed.HeaderText = "Action";
            this.colActionPerformed.Name = "colActionPerformed";
            this.colActionPerformed.ReadOnly = true;
            this.colActionPerformed.Width = 63;
            // 
            // enquiryNotesDataGridViewTextBoxColumn
            // 
            this.enquiryNotesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.enquiryNotesDataGridViewTextBoxColumn.DataPropertyName = "EnquiryNotes";
            this.enquiryNotesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.enquiryNotesDataGridViewTextBoxColumn.Name = "enquiryNotesDataGridViewTextBoxColumn";
            this.enquiryNotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // equiryHistoriesBindingNavigator
            // 
            this.equiryHistoriesBindingNavigator.AddNewItem = null;
            this.equiryHistoriesBindingNavigator.BindingSource = this.equiryHistoryBindingSource;
            this.equiryHistoriesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.equiryHistoriesBindingNavigator.DeleteItem = null;
            this.equiryHistoriesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.equiryHistoriesBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.equiryHistoriesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.equiryHistoriesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.equiryHistoriesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.equiryHistoriesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.equiryHistoriesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.equiryHistoriesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.equiryHistoriesBindingNavigator.Name = "equiryHistoriesBindingNavigator";
            this.equiryHistoriesBindingNavigator.Padding = new System.Windows.Forms.Padding(5);
            this.equiryHistoriesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.equiryHistoriesBindingNavigator.Size = new System.Drawing.Size(835, 33);
            this.equiryHistoriesBindingNavigator.Stretch = true;
            this.equiryHistoriesBindingNavigator.TabIndex = 1;
            this.equiryHistoriesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 23);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // frmEquiryViewHistoryV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 501);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEquiryViewHistoryV2";
            this.Text = "Equiry History";
            this.Load += new System.EventHandler(this.frmEquiryViewHistory_Load);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.equiryHistoryBindingSource)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnquiryHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiryHistoriesBindingNavigator)).EndInit();
            this.equiryHistoriesBindingNavigator.ResumeLayout(false);
            this.equiryHistoriesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private MetroFramework.Controls.MetroGrid dgvEnquiryHistory;
        private System.Windows.Forms.BindingNavigator equiryHistoriesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource equiryHistoryBindingSource;
        private System.Windows.Forms.TextBox dateEnquiryUpdatedTextBox;
        private System.Windows.Forms.TextBox enqueryHistoryIDTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox lookupEquiyHistoryTypeNameTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn enqueryHistoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEnquiryUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActionPerformed;
        private System.Windows.Forms.DataGridViewTextBoxColumn enquiryNotesDataGridViewTextBoxColumn;
    }
}