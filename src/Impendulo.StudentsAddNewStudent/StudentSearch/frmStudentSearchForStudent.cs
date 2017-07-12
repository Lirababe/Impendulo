using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Impendulo.Data.Models;
using System.Data.Entity;
using Impendulo.Development.Students;

namespace Impendulo.StudentForms.Development
{
    public partial class frmStudentSearchForStudent : MetroFramework.Forms.MetroForm
    {
        public List<Student> StudentExpceptionList { get; set; }
        public frmStudentSearchForStudent()
        {
            InitializeComponent();
        }

        private string SearchStudentNumber { get; set; }
        private string SearchStudentIDNumber { get; set; }
        private string SearchStudentFirstName { get; set; }
        private string SearchStudentLastName { get; set; }

        public Student CurrentSelectedStudent { get; set; }

        // public frmStudentCourseEnrollment StudentCourseEnrollmentForm { get; set; }
        public frmStudentSearchForStudent StudentSearchForm { get; set; }
        //public MCDMainForm frmParentForm { get; set; }








        private void frmStudentSearchForStudent_Load(object sender, EventArgs e)
        {
            if (StudentExpceptionList == null)
            {
                StudentExpceptionList = new List<Student>();
            }
            this.LoadSearchSuggestions();
            SearchStudentNumber = "0";
            this.setSearchVariables();
            this.SearchForStudent();

        }
        private void LoadSearchSuggestions()
        {

            AutoCompleteStringCollection allowedIDNumbers = new AutoCompleteStringCollection();
            AutoCompleteStringCollection allowedFirstNames = new AutoCompleteStringCollection();
            AutoCompleteStringCollection allowedLastNames = new AutoCompleteStringCollection();
            AutoCompleteStringCollection allowedStudentNumbers = new AutoCompleteStringCollection();

            List<Data.Models.Student> x = new List<Data.Models.Student>();

            using (var Dbconnection = new MCDEntities())
            {
                x = (from a in Dbconnection.Students
                     select a)
                     .Include("Individual")
                     .ToList<Data.Models.Student>();


            };
            foreach (Student StudentObj in x)
            {
                allowedIDNumbers.Add(StudentObj.StudentIDNumber.ToString());
                allowedFirstNames.Add(StudentObj.Individual.IndividualFirstName);
                allowedLastNames.Add(StudentObj.Individual.IndividualLastname);
                //allowedStudentNumbers.Add(StudentObj.StudentID.ToString());
            }

            txtStudentIdNumber.AutoCompleteCustomSource = allowedIDNumbers;
            txtStudentIdNumber.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtStudentIdNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtFirstName.AutoCompleteCustomSource = allowedFirstNames;
            txtFirstName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtFirstName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtLastName.AutoCompleteCustomSource = allowedLastNames;
            txtLastName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtLastName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //txtStudentNumber.AutoCompleteCustomSource = allowedLastNames;
            //txtLastName.AutoCompleteMode = AutoCompleteMode.Suggest;
            //txtLastName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.setSearchVariables();
            this.SearchForStudent();
        }
        private void setSearchVariables()
        {
            this.SearchStudentIDNumber = this.txtStudentIdNumber.Text;
            this.SearchStudentFirstName = this.txtFirstName.Text;
            this.SearchStudentLastName = txtLastName.Text;
            this.SearchStudentNumber = txtStudentNumber.Text;

        }
        private void setAddStudentButtonVisablity()
        {
            if (studentBindingSource.Count == 0)
            {
                picbtnAddStudent.Visible = true;
            }
            else
            {
                picbtnAddStudent.Visible = false;
            }
        }
        private void SearchForStudent()
        {

            using (var DbConnection = new MCDEntities())
            {
                int CurrentStudentNumber = 0;
                if (SearchStudentNumber.Length > 0)
                {
                    CurrentStudentNumber = Convert.ToInt32(this.SearchStudentNumber);
                }

                List<Student> resultByFilter = new List<Student>();
                if (txtStudentNumber.Text.Length > 0)
                {
                    Student x = (DbConnection.Students.Find(CurrentStudentNumber));
                    if (x != null) { resultByFilter.Add(x); }

                }
                else
                {
                    resultByFilter = (from a in DbConnection.Students
                                      where
                                      a.Individual.IndividualFirstName.Contains(this.SearchStudentFirstName) &&
                                      a.Individual.IndividualLastname.Contains(this.SearchStudentLastName) &&
                                      a.StudentIDNumber.Contains(this.SearchStudentIDNumber)
                                      select a).Take<Student>(50).ToList<Student>();
                }
                List<Student> FinalListOfStudentsFromSearch = new List<Student>();
                Boolean IsStudentExemptFromSearch = false;
                foreach (Student StudentObj in resultByFilter)
                {
                    IsStudentExemptFromSearch = false;
                    foreach (Student StduentExempt in StudentExpceptionList)
                    {
                        if (StudentObj.StudentID == StduentExempt.StudentID)
                        {
                            IsStudentExemptFromSearch = true;
                        }
                    }
                    if (!IsStudentExemptFromSearch)
                    {
                        FinalListOfStudentsFromSearch.Add(StudentObj);
                    }
                }


                studentBindingSource.DataSource = FinalListOfStudentsFromSearch;
            };
            this.setAddStudentButtonVisablity();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtStudentIdNumber.Text = "";
            this.txtFirstName.Text = "";
            txtLastName.Text = "";
            this.txtStudentNumber.Clear();
            this.setSearchVariables();
            SearchForStudent();
        }

        private void dgvStudentSearchResults_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var StudentObj = (Student)(row.DataBoundItem);
                    var IndividualObj = StudentObj.Individual;

                    row.Cells[colStudentFirstName.Index].Value = IndividualObj.IndividualFirstName;
                    row.Cells[colStudentLastName.Index].Value = IndividualObj.IndividualLastname;
                }
            }
        }

        private void dgvStudentSearchResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                CurrentSelectedStudent = (Student)(senderGrid.Rows[e.RowIndex].DataBoundItem);
                Close();
                //TODO - Button Clicked - Execute Code Here
                Student stud = (Student)(senderGrid.Rows[e.RowIndex].DataBoundItem);
                //if (StudentCourseEnrollmentForm != null)
                //{
                //    StudentCourseEnrollmentForm.StudentID = stud.StudentID;
                //    StudentCourseEnrollmentForm.txtStudentFullName.Text = stud.Individual.IndividualFirstName + " " + stud.Individual.IndividualSecondName + " " + stud.Individual.IndividualLastname;
                //    StudentCourseEnrollmentForm.txtStudentIdNumber.Text = stud.StudentIDNumber;
                //    StudentCourseEnrollmentForm.txtStudentNumber.Text = stud.StudentID.ToString(); ;
                //    this.Close();
                //}
                //////if (this.frmParentForm != null)
                //////{
                //////    foreach (Form f in frmParentForm.MdiChildren)
                //////    {
                //////        if (f.GetType() == typeof(frmAddUpdateStudent))
                //////        {
                //////            f.Activate();
                //////            f.WindowState = FormWindowState.Maximized;
                //////            this.Close();
                //////            return;
                //////        }
                //////    }

                //////    frmAddUpdateStudent frm = new frmAddUpdateStudent();
                //////    frm.StudentID = stud.StudentID;
                //////    frm.MdiParent = frmParentForm;
                //////    frm.Show();
                //////    this.Close();
                //////}
                //MessageBox.Show(stud.StudentID.ToString());

            }
        }

        private void picbtnAddStudent_Click(object sender, EventArgs e)
        {
            frmStudentAddUpdate frm = new frmStudentAddUpdate(0);
            //frm.CurrentStudentID = 0;
            frm.ShowDialog();
            if (frm.CurrentStudentID != 0)
            {
                this.txtStudentIdNumber.Text = frm.CurrentSelectedStudent.StudentIDNumber;
                this.txtFirstName.Text = frm.CurrentSelectedStudent.Individual.IndividualFirstName;
                this.txtLastName.Text = frm.CurrentSelectedStudent.Individual.IndividualLastname;
                this.txtStudentNumber.Text = frm.CurrentSelectedStudent.StudentID.ToString();
            }
            this.setSearchVariables();
            this.SearchForStudent();

        }

    }
}
