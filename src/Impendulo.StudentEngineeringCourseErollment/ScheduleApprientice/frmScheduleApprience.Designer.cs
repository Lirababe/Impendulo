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
            this.dgvConfirmSchedule = new System.Windows.Forms.DataGridView();
            this.colFacilitator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVanue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaximum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentlyScheduled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmSchedule = new System.Windows.Forms.DataGridViewLinkColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbfilters = new System.Windows.Forms.GroupBox();
            this.lblFacilitators = new System.Windows.Forms.Label();
            this.lblVanues = new System.Windows.Forms.Label();
            this.cbFacilitators = new System.Windows.Forms.ComboBox();
            this.cbVanues = new System.Windows.Forms.ComboBox();
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
            this.colFacilitator,
            this.colVanue,
            this.colMaximum,
            this.colCurrentlyScheduled,
            this.colStatus,
            this.colConfirmSchedule});
            this.dgvConfirmSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConfirmSchedule.Location = new System.Drawing.Point(0, 0);
            this.dgvConfirmSchedule.Name = "dgvConfirmSchedule";
            this.dgvConfirmSchedule.ReadOnly = true;
            this.dgvConfirmSchedule.Size = new System.Drawing.Size(678, 251);
            this.dgvConfirmSchedule.TabIndex = 0;
            this.dgvConfirmSchedule.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvConfirmSchedule_DataBindingComplete);
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
            // colConfirmSchedule
            // 
            this.colConfirmSchedule.HeaderText = "ConfirmSchedule";
            this.colConfirmSchedule.Name = "colConfirmSchedule";
            this.colConfirmSchedule.ReadOnly = true;
            this.colConfirmSchedule.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colConfirmSchedule.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.splitContainer1.Size = new System.Drawing.Size(678, 317);
            this.splitContainer1.SplitterDistance = 62;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbfilters
            // 
            this.gbfilters.Controls.Add(this.cbVanues);
            this.gbfilters.Controls.Add(this.cbFacilitators);
            this.gbfilters.Controls.Add(this.lblVanues);
            this.gbfilters.Controls.Add(this.lblFacilitators);
            this.gbfilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbfilters.Location = new System.Drawing.Point(0, 0);
            this.gbfilters.Name = "gbfilters";
            this.gbfilters.Size = new System.Drawing.Size(678, 62);
            this.gbfilters.TabIndex = 0;
            this.gbfilters.TabStop = false;
            this.gbfilters.Text = "Filters";
            // 
            // lblFacilitators
            // 
            this.lblFacilitators.AutoSize = true;
            this.lblFacilitators.Location = new System.Drawing.Point(6, 34);
            this.lblFacilitators.Name = "lblFacilitators";
            this.lblFacilitators.Size = new System.Drawing.Size(55, 13);
            this.lblFacilitators.TabIndex = 0;
            this.lblFacilitators.Text = "Facilitator:";
            // 
            // lblVanues
            // 
            this.lblVanues.AutoSize = true;
            this.lblVanues.Location = new System.Drawing.Point(411, 31);
            this.lblVanues.Name = "lblVanues";
            this.lblVanues.Size = new System.Drawing.Size(41, 13);
            this.lblVanues.TabIndex = 1;
            this.lblVanues.Text = "Venue:";
            // 
            // cbFacilitators
            // 
            this.cbFacilitators.FormattingEnabled = true;
            this.cbFacilitators.Location = new System.Drawing.Point(67, 26);
            this.cbFacilitators.Name = "cbFacilitators";
            this.cbFacilitators.Size = new System.Drawing.Size(186, 21);
            this.cbFacilitators.TabIndex = 2;
            // 
            // cbVanues
            // 
            this.cbVanues.FormattingEnabled = true;
            this.cbVanues.Location = new System.Drawing.Point(458, 23);
            this.cbVanues.Name = "cbVanues";
            this.cbVanues.Size = new System.Drawing.Size(208, 21);
            this.cbVanues.TabIndex = 3;
            // 
            // frmScheduleApprience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 317);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacilitator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVanue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaximum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentlyScheduled;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewLinkColumn colConfirmSchedule;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbfilters;
        private System.Windows.Forms.ComboBox cbVanues;
        private System.Windows.Forms.ComboBox cbFacilitators;
        private System.Windows.Forms.Label lblVanues;
        private System.Windows.Forms.Label lblFacilitators;
    }
}