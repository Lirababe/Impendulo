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
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmSchedule)).BeginInit();
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
            this.dgvConfirmSchedule.Size = new System.Drawing.Size(678, 317);
            this.dgvConfirmSchedule.TabIndex = 0;
            this.dgvConfirmSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfirmSchedule_CellContentClick);
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
            // frmScheduleApprience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 317);
            this.Controls.Add(this.dgvConfirmSchedule);
            this.Name = "frmScheduleApprience";
            this.Text = "frmScheduleApprience";
            this.Load += new System.EventHandler(this.frmScheduleApprience_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmSchedule)).EndInit();
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
    }
}