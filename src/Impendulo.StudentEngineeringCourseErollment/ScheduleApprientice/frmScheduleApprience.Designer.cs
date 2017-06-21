﻿namespace Impendulo.StudentEngineeringCourseErollment.Devlopment.ScheduleApprientice
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
            this.dgvConfirmSchedule = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbfilters = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpTodate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblTodate = new System.Windows.Forms.Label();
            this.lblFromdate = new System.Windows.Forms.Label();
            this.cbVanues = new System.Windows.Forms.ComboBox();
            this.cbFacilitators = new System.Windows.Forms.ComboBox();
            this.lblVanues = new System.Windows.Forms.Label();
            this.lblFacilitators = new System.Windows.Forms.Label();
            this.colSelect = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colScheduledCourses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacilitator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVanue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaximum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentlyScheduled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbfilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConfirmSchedule
            // 
            this.dgvConfirmSchedule.AllowUserToDeleteRows = false;
            this.dgvConfirmSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfirmSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colScheduledCourses,
            this.colStartdate,
            this.colFacilitator,
            this.colVanue,
            this.colMaximum,
            this.colCurrentlyScheduled,
            this.colStatus});
            this.dgvConfirmSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConfirmSchedule.Location = new System.Drawing.Point(0, 0);
            this.dgvConfirmSchedule.Name = "dgvConfirmSchedule";
            this.dgvConfirmSchedule.ReadOnly = true;
            this.dgvConfirmSchedule.Size = new System.Drawing.Size(863, 173);
            this.dgvConfirmSchedule.TabIndex = 0;
            this.dgvConfirmSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfirmSchedule_CellContentClick);
            this.dgvConfirmSchedule.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvConfirmSchedule_DataBindingComplete);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbfilters);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvConfirmSchedule);
            this.splitContainer1.Size = new System.Drawing.Size(863, 317);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbfilters
            // 
            this.gbfilters.Controls.Add(this.btnSearch);
            this.gbfilters.Controls.Add(this.dtpTodate);
            this.gbfilters.Controls.Add(this.dtpFromDate);
            this.gbfilters.Controls.Add(this.lblTodate);
            this.gbfilters.Controls.Add(this.lblFromdate);
            this.gbfilters.Controls.Add(this.cbVanues);
            this.gbfilters.Controls.Add(this.cbFacilitators);
            this.gbfilters.Controls.Add(this.lblVanues);
            this.gbfilters.Controls.Add(this.lblFacilitators);
            this.gbfilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbfilters.Location = new System.Drawing.Point(0, 0);
            this.gbfilters.Name = "gbfilters";
            this.gbfilters.Size = new System.Drawing.Size(863, 140);
            this.gbfilters.TabIndex = 0;
            this.gbfilters.TabStop = false;
            this.gbfilters.Text = "Filters";
            //this.gbfilters.Enter += new System.EventHandler(this.gbfilters_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Impendulo.StudentEngineeringCourseErollment.Devlopment.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(280, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 102);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dtpTodate
            // 
            this.dtpTodate.Location = new System.Drawing.Point(66, 104);
            this.dtpTodate.Name = "dtpTodate";
            this.dtpTodate.Size = new System.Drawing.Size(208, 20);
            this.dtpTodate.TabIndex = 7;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(66, 77);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(208, 20);
            this.dtpFromDate.TabIndex = 6;
            // 
            // lblTodate
            // 
            this.lblTodate.AutoSize = true;
            this.lblTodate.Location = new System.Drawing.Point(11, 111);
            this.lblTodate.Name = "lblTodate";
            this.lblTodate.Size = new System.Drawing.Size(25, 13);
            this.lblTodate.TabIndex = 5;
            this.lblTodate.Text = "TO:";
            // 
            // lblFromdate
            // 
            this.lblFromdate.AutoSize = true;
            this.lblFromdate.Location = new System.Drawing.Point(11, 85);
            this.lblFromdate.Name = "lblFromdate";
            this.lblFromdate.Size = new System.Drawing.Size(41, 13);
            this.lblFromdate.TabIndex = 4;
            this.lblFromdate.Text = "FROM:";
            // 
            // cbVanues
            // 
            this.cbVanues.FormattingEnabled = true;
            this.cbVanues.Location = new System.Drawing.Point(66, 49);
            this.cbVanues.Name = "cbVanues";
            this.cbVanues.Size = new System.Drawing.Size(208, 21);
            this.cbVanues.TabIndex = 3;
            // 
            // cbFacilitators
            // 
            this.cbFacilitators.FormattingEnabled = true;
            this.cbFacilitators.Location = new System.Drawing.Point(66, 22);
            this.cbFacilitators.Name = "cbFacilitators";
            this.cbFacilitators.Size = new System.Drawing.Size(208, 21);
            this.cbFacilitators.TabIndex = 2;
            // 
            // lblVanues
            // 
            this.lblVanues.AutoSize = true;
            this.lblVanues.Location = new System.Drawing.Point(11, 57);
            this.lblVanues.Name = "lblVanues";
            this.lblVanues.Size = new System.Drawing.Size(41, 13);
            this.lblVanues.TabIndex = 1;
            this.lblVanues.Text = "Venue:";
            // 
            // lblFacilitators
            // 
            this.lblFacilitators.AutoSize = true;
            this.lblFacilitators.Location = new System.Drawing.Point(11, 30);
            this.lblFacilitators.Name = "lblFacilitators";
            this.lblFacilitators.Size = new System.Drawing.Size(55, 13);
            this.lblFacilitators.TabIndex = 0;
            this.lblFacilitators.Text = "Facilitator:";
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "";
            this.colSelect.Name = "colSelect";
            this.colSelect.ReadOnly = true;
            this.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colScheduledCourses
            // 
            this.colScheduledCourses.HeaderText = "Courses";
            this.colScheduledCourses.Name = "colScheduledCourses";
            this.colScheduledCourses.ReadOnly = true;
            // 
            // colStartdate
            // 
            this.colStartdate.HeaderText = "Start Date";
            this.colStartdate.Name = "colStartdate";
            this.colStartdate.ReadOnly = true;
            // 
            // colFacilitator
            // 
            this.colFacilitator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFacilitator.HeaderText = "Facilitator";
            this.colFacilitator.Name = "colFacilitator";
            this.colFacilitator.ReadOnly = true;
            // 
            // colVanue
            // 
            this.colVanue.HeaderText = "Vanue";
            this.colVanue.Name = "colVanue";
            this.colVanue.ReadOnly = true;
            // 
            // colMaximum
            // 
            this.colMaximum.HeaderText = "Maximum";
            this.colMaximum.Name = "colMaximum";
            this.colMaximum.ReadOnly = true;
            // 
            // colCurrentlyScheduled
            // 
            this.colCurrentlyScheduled.HeaderText = "Currently Scheduled";
            this.colCurrentlyScheduled.Name = "colCurrentlyScheduled";
            this.colCurrentlyScheduled.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // frmScheduleApprience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 317);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmScheduleApprience";
            this.Text = "frmScheduleApprience";
            this.Load += new System.EventHandler(this.frmScheduleApprience_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmSchedule)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbfilters.ResumeLayout(false);
            this.gbfilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConfirmSchedule;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbfilters;
        private System.Windows.Forms.ComboBox cbVanues;
        private System.Windows.Forms.ComboBox cbFacilitators;
        private System.Windows.Forms.Label lblVanues;
        private System.Windows.Forms.Label lblFacilitators;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpTodate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblTodate;
        private System.Windows.Forms.Label lblFromdate;
        private System.Windows.Forms.DataGridViewLinkColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScheduledCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacilitator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVanue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaximum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentlyScheduled;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}