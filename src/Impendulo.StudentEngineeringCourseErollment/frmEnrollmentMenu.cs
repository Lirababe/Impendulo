using Impendulo.Data.Models;
using Impendulo.Scheduling.Deployment.Courses.Apprenticeship;
using Impendulo.StudentEngineeringCourseErollment.Devlopment.EnrollmentException;
using Impendulo.StudentEngineeringCourseErollment.Devlopment.EnrollmentInprogress;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.StudentEngineeringCourseErollment.Devlopment
{
    public partial class frmEnrollmentMenu : Form
    {
        private Employee CurrentEmployeeLoggedIn = null;
        public frmEnrollmentMenu()
        {
            InitializeComponent();
            using (var Dbconnection = new MCDEntities())
            {
                //Simulates the current Employee that is logged in.
                CurrentEmployeeLoggedIn = (from a in Dbconnection.Employees
                                           select a).FirstOrDefault<Employee>();
                //loads Departments in the drop down
                lookupDepartmentBindingSource.DataSource = (from a in Dbconnection.LookupDepartments
                                                            orderby a.DepartmentName
                                                            select a).ToList<LookupDepartment>();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEnrolmmentInprogress frm = new frmEnrolmmentInprogress();

            Employee CurrentEmployeeLoggedIn = null;

            //Passes the employee object of the currentlly loggin
            frm.CurrentEmployeeLoggedIn = CurrentEmployeeLoggedIn;
            //Sets the parameters for the for to load the correct enrollments
            frm.CurrentEnrollmentID = Convert.ToInt32(txtEnrollmentIDForInProgreesEnrollment.Text);
            frm.CurrentEquiryID = Convert.ToInt32(txtEquriyIDForInprogressEnrollment.Text);
            frm.CurrentSelectedDepartment = (Common.Enum.EnumDepartments)(cboDepartmentsForInProgressEnrollment.SelectedValue);

            frm.ShowDialog();

        }

        private void frmEnrollmentMenu_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmScheduleApprenticeship frm = new frmScheduleApprenticeship();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEnrollmentException frm = new frmEnrollmentException();
            frm.CurrentEmployeeLoggedIn = CurrentEmployeeLoggedIn;

            using (var Dbconnection = new MCDEntities())
            {
                frm.SelectedEnrollment = (from a in Dbconnection.Enrollments
                                          orderby a.EnrollmentID descending
                                          select a).FirstOrDefault<Enrollment>();
                frm.ShowDialog();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (frmEnrollmentInProgressV2 frm = new frmEnrollmentInProgressV2())
            {
                frm.CurrentEmployeeLoggedIn = CurrentEmployeeLoggedIn;
                frm.CurrentEnrollmentID = 5045;
                frm.ShowDialog();
            }
        }
    }
}
