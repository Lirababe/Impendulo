namespace Impendulo.StudentEngineeringCourseErollment.Devlopment.ScheduleApprientice
{
    partial class frmScheduleApprience
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbfilters = new System.Windows.Forms.GroupBox();
            this.mbtnSearch = new MetroFramework.Controls.MetroButton();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.mlblToDate = new MetroFramework.Controls.MetroLabel();
            this.mlblFromdate = new MetroFramework.Controls.MetroLabel();
            this.mlblVanue = new MetroFramework.Controls.MetroLabel();
            this.mlblFacilitator = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.mdgvScheduleApprienticeship = new MetroFramework.Controls.MetroGrid();
            this.colCourseSelect = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colCourses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseFacilitator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseVanue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseMaximum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoursecurrentSchedules = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcourseAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleApprienticeshipbindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbfilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvScheduleApprienticeship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleApprienticeshipbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbfilters);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mdgvScheduleApprienticeship);
            this.splitContainer1.Size = new System.Drawing.Size(834, 382);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbfilters
            // 
            this.gbfilters.Controls.Add(this.mbtnSearch);
            this.gbfilters.Controls.Add(this.metroComboBox2);
            this.gbfilters.Controls.Add(this.metroComboBox1);
            this.gbfilters.Controls.Add(this.mlblToDate);
            this.gbfilters.Controls.Add(this.mlblFromdate);
            this.gbfilters.Controls.Add(this.mlblVanue);
            this.gbfilters.Controls.Add(this.mlblFacilitator);
            this.gbfilters.Controls.Add(this.metroDateTime2);
            this.gbfilters.Controls.Add(this.metroDateTime1);
            this.gbfilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbfilters.Location = new System.Drawing.Point(0, 0);
            this.gbfilters.Name = "gbfilters";
            this.gbfilters.Size = new System.Drawing.Size(834, 168);
            this.gbfilters.TabIndex = 0;
            this.gbfilters.TabStop = false;
            this.gbfilters.Text = "Filters";
            // 
            // mbtnSearch
            // 
            this.mbtnSearch.BackgroundImage = global::Impendulo.StudentEngineeringCourseErollment.Devlopment.Properties.Resources.search1;
            this.mbtnSearch.Location = new System.Drawing.Point(291, 14);
            this.mbtnSearch.Name = "mbtnSearch";
            this.mbtnSearch.Size = new System.Drawing.Size(122, 134);
            this.mbtnSearch.TabIndex = 16;
            this.mbtnSearch.UseSelectable = true;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(77, 49);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(208, 29);
            this.metroComboBox2.TabIndex = 15;
            this.metroComboBox2.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(77, 14);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(208, 29);
            this.metroComboBox1.TabIndex = 14;
            this.metroComboBox1.UseSelectable = true;
            // 
            // mlblToDate
            // 
            this.mlblToDate.AutoSize = true;
            this.mlblToDate.Location = new System.Drawing.Point(6, 129);
            this.mlblToDate.Name = "mlblToDate";
            this.mlblToDate.Size = new System.Drawing.Size(27, 19);
            this.mlblToDate.TabIndex = 13;
            this.mlblToDate.Text = "To:";
            // 
            // mlblFromdate
            // 
            this.mlblFromdate.AutoSize = true;
            this.mlblFromdate.Location = new System.Drawing.Point(6, 94);
            this.mlblFromdate.Name = "mlblFromdate";
            this.mlblFromdate.Size = new System.Drawing.Size(44, 19);
            this.mlblFromdate.TabIndex = 12;
            this.mlblFromdate.Text = "From:";
            // 
            // mlblVanue
            // 
            this.mlblVanue.AutoSize = true;
            this.mlblVanue.Location = new System.Drawing.Point(6, 59);
            this.mlblVanue.Name = "mlblVanue";
            this.mlblVanue.Size = new System.Drawing.Size(48, 19);
            this.mlblVanue.TabIndex = 11;
            this.mlblVanue.Text = "Vanue:";
            // 
            // mlblFacilitator
            // 
            this.mlblFacilitator.AutoSize = true;
            this.mlblFacilitator.Location = new System.Drawing.Point(6, 24);
            this.mlblFacilitator.Name = "mlblFacilitator";
            this.mlblFacilitator.Size = new System.Drawing.Size(65, 19);
            this.mlblFacilitator.TabIndex = 10;
            this.mlblFacilitator.Text = "Faciliator:";
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(77, 119);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(208, 29);
            this.metroDateTime2.TabIndex = 9;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(77, 84);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(208, 29);
            this.metroDateTime1.TabIndex = 8;
            // 
            // mdgvScheduleApprienticeship
            // 
            this.mdgvScheduleApprienticeship.AllowUserToAddRows = false;
            this.mdgvScheduleApprienticeship.AllowUserToDeleteRows = false;
            this.mdgvScheduleApprienticeship.AllowUserToResizeRows = false;
            this.mdgvScheduleApprienticeship.AutoGenerateColumns = false;
            this.mdgvScheduleApprienticeship.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvScheduleApprienticeship.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvScheduleApprienticeship.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvScheduleApprienticeship.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvScheduleApprienticeship.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mdgvScheduleApprienticeship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdgvScheduleApprienticeship.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCourseSelect,
            this.colCourses,
            this.colCourseStartDate,
            this.colCourseFacilitator,
            this.colCourseVanue,
            this.colCourseMaximum,
            this.colCoursecurrentSchedules,
            this.colcourseAvailable});
            this.mdgvScheduleApprienticeship.DataSource = this.ScheduleApprienticeshipbindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvScheduleApprienticeship.DefaultCellStyle = dataGridViewCellStyle2;
            this.mdgvScheduleApprienticeship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdgvScheduleApprienticeship.EnableHeadersVisualStyles = false;
            this.mdgvScheduleApprienticeship.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvScheduleApprienticeship.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvScheduleApprienticeship.Location = new System.Drawing.Point(0, 0);
            this.mdgvScheduleApprienticeship.Name = "mdgvScheduleApprienticeship";
            this.mdgvScheduleApprienticeship.ReadOnly = true;
            this.mdgvScheduleApprienticeship.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvScheduleApprienticeship.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mdgvScheduleApprienticeship.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvScheduleApprienticeship.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvScheduleApprienticeship.Size = new System.Drawing.Size(834, 210);
            this.mdgvScheduleApprienticeship.TabIndex = 1;
            this.mdgvScheduleApprienticeship.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mdgvScheduleApprienticeship_CellClick);
            this.mdgvScheduleApprienticeship.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.mdgvScheduleApprienticeship_DataBindingComplete);
            // 
            // colCourseSelect
            // 
            this.colCourseSelect.HeaderText = "";
            this.colCourseSelect.LinkColor = System.Drawing.Color.Red;
            this.colCourseSelect.Name = "colCourseSelect";
            this.colCourseSelect.ReadOnly = true;
            this.colCourseSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCourseSelect.Text = "Select Course";
            // 
            // colCourses
            // 
            this.colCourses.HeaderText = "Courses";
            this.colCourses.Name = "colCourses";
            this.colCourses.ReadOnly = true;
            // 
            // colCourseStartDate
            // 
            this.colCourseStartDate.HeaderText = "Start date";
            this.colCourseStartDate.Name = "colCourseStartDate";
            this.colCourseStartDate.ReadOnly = true;
            // 
            // colCourseFacilitator
            // 
            this.colCourseFacilitator.HeaderText = "Facilitator";
            this.colCourseFacilitator.Name = "colCourseFacilitator";
            this.colCourseFacilitator.ReadOnly = true;
            // 
            // colCourseVanue
            // 
            this.colCourseVanue.HeaderText = "Vanue";
            this.colCourseVanue.Name = "colCourseVanue";
            this.colCourseVanue.ReadOnly = true;
            // 
            // colCourseMaximum
            // 
            this.colCourseMaximum.HeaderText = "Maximum";
            this.colCourseMaximum.Name = "colCourseMaximum";
            this.colCourseMaximum.ReadOnly = true;
            // 
            // colCoursecurrentSchedules
            // 
            this.colCoursecurrentSchedules.HeaderText = "Current Scheduled";
            this.colCoursecurrentSchedules.Name = "colCoursecurrentSchedules";
            this.colCoursecurrentSchedules.ReadOnly = true;
            // 
            // colcourseAvailable
            // 
            this.colcourseAvailable.HeaderText = "Available";
            this.colcourseAvailable.Name = "colcourseAvailable";
            this.colcourseAvailable.ReadOnly = true;
            // 
            // frmScheduleApprience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 462);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmScheduleApprience";
            this.Text = "Schedule Apprienticeship";
            this.Load += new System.EventHandler(this.frmScheduleApprience_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbfilters.ResumeLayout(false);
            this.gbfilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvScheduleApprienticeship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleApprienticeshipbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbfilters;
        private MetroFramework.Controls.MetroButton mbtnSearch;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel mlblToDate;
        private MetroFramework.Controls.MetroLabel mlblFromdate;
        private MetroFramework.Controls.MetroLabel mlblVanue;
        private MetroFramework.Controls.MetroLabel mlblFacilitator;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroGrid mdgvScheduleApprienticeship;
        private System.Windows.Forms.BindingSource ScheduleApprienticeshipbindingSource;
        private System.Windows.Forms.DataGridViewLinkColumn colCourseSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseFacilitator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseVanue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseMaximum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoursecurrentSchedules;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcourseAvailable;
    }
}