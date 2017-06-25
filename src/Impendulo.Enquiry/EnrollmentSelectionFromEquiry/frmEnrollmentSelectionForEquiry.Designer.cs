namespace Impendulo.Enquiry.Development.EnrollmentSelectionFromEquiry
{
    partial class frmEnrollmentSelectionForEquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnrollmentSelectionForEquiry));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.enrollmentDataGridView = new System.Windows.Forms.DataGridView();
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.curriculumEnquiryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelection = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colStudentIDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumEnquiryBindingNavigator)).BeginInit();
            this.curriculumEnquiryBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStripContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Enrollment";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.enrollmentDataGridView);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(693, 313);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 16);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(693, 338);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.curriculumEnquiryBindingNavigator);
            // 
            // enrollmentDataGridView
            // 
            this.enrollmentDataGridView.AutoGenerateColumns = false;
            this.enrollmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrollmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.colSelection,
            this.colStudentIDNumber,
            this.colFirstName,
            this.colLastName,
            this.colStatus});
            this.enrollmentDataGridView.DataSource = this.enrollmentBindingSource;
            this.enrollmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enrollmentDataGridView.Location = new System.Drawing.Point(0, 0);
            this.enrollmentDataGridView.Name = "enrollmentDataGridView";
            this.enrollmentDataGridView.Size = new System.Drawing.Size(693, 313);
            this.enrollmentDataGridView.TabIndex = 0;
            this.enrollmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.enrollmentDataGridView_CellContentClick);
            this.enrollmentDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.enrollmentDataGridView_DataBindingComplete);
            // 
            // enrollmentBindingSource
            // 
            this.enrollmentBindingSource.DataSource = typeof(Impendulo.Data.Models.Enrollment);
            // 
            // curriculumEnquiryBindingNavigator
            // 
            this.curriculumEnquiryBindingNavigator.AddNewItem = null;
            this.curriculumEnquiryBindingNavigator.BindingSource = this.enrollmentBindingSource;
            this.curriculumEnquiryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.curriculumEnquiryBindingNavigator.CountItemFormat = "of {0} Enrollments";
            this.curriculumEnquiryBindingNavigator.DeleteItem = null;
            this.curriculumEnquiryBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.curriculumEnquiryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.curriculumEnquiryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.curriculumEnquiryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.curriculumEnquiryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.curriculumEnquiryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.curriculumEnquiryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.curriculumEnquiryBindingNavigator.Name = "curriculumEnquiryBindingNavigator";
            this.curriculumEnquiryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.curriculumEnquiryBindingNavigator.Size = new System.Drawing.Size(693, 25);
            this.curriculumEnquiryBindingNavigator.Stretch = true;
            this.curriculumEnquiryBindingNavigator.TabIndex = 1;
            this.curriculumEnquiryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(101, 22);
            this.bindingNavigatorCountItem.Text = "of {0} Enrollments";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateIntitiated";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date Enrolled";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 96;
            // 
            // colSelection
            // 
            this.colSelection.ActiveLinkColor = System.Drawing.Color.Blue;
            this.colSelection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSelection.HeaderText = "";
            this.colSelection.Name = "colSelection";
            this.colSelection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSelection.Text = "Select";
            this.colSelection.UseColumnTextForLinkValue = true;
            this.colSelection.VisitedLinkColor = System.Drawing.Color.Blue;
            this.colSelection.Width = 21;
            // 
            // colStudentIDNumber
            // 
            this.colStudentIDNumber.HeaderText = "ID Number";
            this.colStudentIDNumber.Name = "colStudentIDNumber";
            // 
            // colFirstName
            // 
            this.colFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Width = 82;
            // 
            // colLastName
            // 
            this.colLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.Width = 83;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.HeaderText = "Progress";
            this.colStatus.Name = "colStatus";
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
            // frmEnrollmentSelectionForEquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 437);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEnrollmentSelectionForEquiry";
            this.Text = "Enrollment Selection";
            this.Load += new System.EventHandler(this.frmEnrollmentSelectionForEquiry_Load);
            this.groupBox1.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumEnquiryBindingNavigator)).EndInit();
            this.curriculumEnquiryBindingNavigator.ResumeLayout(false);
            this.curriculumEnquiryBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView enrollmentDataGridView;
        private System.Windows.Forms.BindingSource enrollmentBindingSource;
        private System.Windows.Forms.BindingNavigator curriculumEnquiryBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewLinkColumn colSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentIDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    }
}