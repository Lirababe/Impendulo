namespace Impendulo.StudentEngineeringCourseErollment.Devlopment
{
    partial class frmEnrollmentMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDepartmentsForInProgressEnrollment = new System.Windows.Forms.ComboBox();
            this.lookupDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEquriyIDForInprogressEnrollment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnrollmentIDForInProgreesEnrollment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupDepartmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "In-Progress Enrollment Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboDepartmentsForInProgressEnrollment);
            this.groupBox1.Controls.Add(this.txtEquriyIDForInprogressEnrollment);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEnrollmentIDForInProgreesEnrollment);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set In-Progress Form Parameters ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Department";
            // 
            // cboDepartmentsForInProgressEnrollment
            // 
            this.cboDepartmentsForInProgressEnrollment.DataSource = this.lookupDepartmentBindingSource;
            this.cboDepartmentsForInProgressEnrollment.DisplayMember = "DepartmentName";
            this.cboDepartmentsForInProgressEnrollment.FormattingEnabled = true;
            this.cboDepartmentsForInProgressEnrollment.Location = new System.Drawing.Point(89, 78);
            this.cboDepartmentsForInProgressEnrollment.Name = "cboDepartmentsForInProgressEnrollment";
            this.cboDepartmentsForInProgressEnrollment.Size = new System.Drawing.Size(152, 21);
            this.cboDepartmentsForInProgressEnrollment.TabIndex = 5;
            this.cboDepartmentsForInProgressEnrollment.ValueMember = "DepartmentID";
            // 
            // lookupDepartmentBindingSource
            // 
            this.lookupDepartmentBindingSource.DataSource = typeof(Impendulo.Data.Models.LookupDepartment);
            // 
            // txtEquriyIDForInprogressEnrollment
            // 
            this.txtEquriyIDForInprogressEnrollment.Location = new System.Drawing.Point(89, 52);
            this.txtEquriyIDForInprogressEnrollment.Name = "txtEquriyIDForInprogressEnrollment";
            this.txtEquriyIDForInprogressEnrollment.Size = new System.Drawing.Size(100, 20);
            this.txtEquriyIDForInprogressEnrollment.TabIndex = 4;
            this.txtEquriyIDForInprogressEnrollment.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enquiry ID";
            // 
            // txtEnrollmentIDForInProgreesEnrollment
            // 
            this.txtEnrollmentIDForInProgreesEnrollment.Location = new System.Drawing.Point(89, 26);
            this.txtEnrollmentIDForInProgreesEnrollment.Name = "txtEnrollmentIDForInProgreesEnrollment";
            this.txtEnrollmentIDForInProgreesEnrollment.Size = new System.Drawing.Size(100, 20);
            this.txtEnrollmentIDForInProgreesEnrollment.TabIndex = 2;
            this.txtEnrollmentIDForInProgreesEnrollment.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enrrolment ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Schedule Enrollment Coures";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Enrollment Exception";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmEnrollmentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEnrollmentMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEnrollmentMenu";
            this.Load += new System.EventHandler(this.frmEnrollmentMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupDepartmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEnrollmentIDForInProgreesEnrollment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEquriyIDForInprogressEnrollment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDepartmentsForInProgressEnrollment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource lookupDepartmentBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}