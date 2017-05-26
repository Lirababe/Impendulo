using Impendulo.Data.Models;
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
                                           where a.EmployeeID == 11075
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
    }
}
