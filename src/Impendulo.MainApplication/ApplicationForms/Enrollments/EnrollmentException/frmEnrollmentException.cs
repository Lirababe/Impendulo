﻿using Impendulo.Common.Enum;
using Impendulo.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.StudentEngineeringCourseErollment.Deployment.EnrollmentException
{
    public partial class frmEnrollmentException : Form
    {
        public frmEnrollmentException()
        {
            InitializeComponent();
            EnquiryID = 0;
        }

        public Employee CurrentEmployeeLoggedIn { get; set; }
        public Enrollment SelectedEnrollment { get; set; }

        public int EnquiryID { get; set; }

        private void btnPropcessException_Click(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {
                try
                {
                    Dbconnection.Enrollments.Attach(SelectedEnrollment);
                    SelectedEnrollment.LookupEnrollmentProgressStateID = (int)EnumEnrollmentProgressStates.Excempt;
                    Dbconnection.Entry(SelectedEnrollment).State = System.Data.Entity.EntityState.Modified;
                    Dbconnection.SaveChanges();
                   
                    EquiryHistory hist = new EquiryHistory
                    {
                        EnquiryID = EnquiryID,
                        EmployeeID = this.CurrentEmployeeLoggedIn.EmployeeID,
                        LookupEquiyHistoryTypeID = (int)EnumEquiryHistoryTypes.Enrollment_Course_PreRequisite_Was_Except,
                        DateEnquiryUpdated = DateTime.Now,
                        EnquiryNotes = "For Enrollment : " + EnquiryID.ToString() + "\n\nThe following Curriculum: " + SelectedEnrollment.Curriculum.CurriculumName.ToString() + " Has Been Excempt.\n\nEnrollment Ref:\n" + SelectedEnrollment.EnrollmentID + "\n\nNotes:" + txtExceptionNotes.Text.ToString()
                    };
                    Dbconnection.EquiryHistories.Add(hist);
                    int IsSaved = Dbconnection.SaveChanges();
                    //SelectedEnrollment.LookupEnrollmentProgressState = null;
                    Dbconnection.Entry(SelectedEnrollment).Reference("LookupEnrollmentProgressState").Load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Close();
                }


            };
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEnrollmentException_Load(object sender, EventArgs e)
        {
            if (CurrentEmployeeLoggedIn == null)
            {

                using (var Dbconnection = new MCDEntities())
                {
                    CurrentEmployeeLoggedIn = (from a in Dbconnection.Employees
                                               where a.EmployeeID == 11075
                                               select a).FirstOrDefault<Employee>();
                };
            }
        }
    }
}
