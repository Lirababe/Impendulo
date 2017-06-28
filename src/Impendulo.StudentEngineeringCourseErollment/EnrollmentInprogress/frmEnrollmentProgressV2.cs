using Impendulo.Common.Enum;
using Impendulo.Data.Models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.StudentEngineeringCourseErollment.Devlopment.EnrollmentInprogress
{
    public partial class frmEnrollmentProgressV2 : MetroForm
    {

        /*Diff Modes that the form can be loaded
         1. Listed by current Enquiry - which list all enrollments for the the specific enquiry
         2. Lists by current Equiry and Enrollment which lists only current enrollemnt associated with the a specific enquiry
         3. All Enrollments (First 50)
         4. Enrolment filter by search page.
         */
        private Boolean IsLoadingPreRequisiteEnrollment = false;
        public EnumDepartments CurrentSelectedDepartment { get; set; }
        public Employee CurrentEmployeeLoggedIn { get; set; }
        public int CurrentEnrollmentID { get; set; }
        public int CurrentEquiryID { get; set; }
        public frmEnrollmentProgressV2()
        {
            InitializeComponent();
        }

        private void frmEnrollmentProgressV2_Load(object sender, EventArgs e)
        {
            RefreshEnrollment();
        }

        #region Resfresh Methods

        private void RefreshEnrollment()
        {


        }
        #endregion

        #region Populate Methods

        private void populateEnrollment()
        {

        }

        #endregion

        #region Controls Event Methods

        #endregion
    }
}
