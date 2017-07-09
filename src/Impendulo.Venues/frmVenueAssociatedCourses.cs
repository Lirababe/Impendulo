using Impendulo.Data.Models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.Venues
{
    public partial class frmVenueAssociatedCourses : MetroForm
    {
        public frmVenueAssociatedCourses()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.refreshVenues();
            this.refreshDepartments();
            this.refreshDepartmentCourses();
            this.refreshVenueCourses();
        }

        #region Refresh Methods
        private void refreshVenueCourses()
        {
            if(venueBindingSource.Count > 0)
            {
                int _VenueID = 0;
                
                    _VenueID = ((Venue)venueBindingSource.Current).VenueID;
               
                this.populateVenueCourses(VenueID: _VenueID);
            }
           
        }
        private void refreshDepartmentCourses()
        {
            if(lookupDepartmentBindingSource.Count > 0)
            {
                int _DepartmentID = 0;
                int _VenueID = 0;
                //if (cboSelectedDepartments.SelectedValue != null && cboSelectedVenues.SelectedValue != null)
                //{
                    _DepartmentID = ((LookupDepartment)lookupDepartmentBindingSource.Current).DepartmentID;
                    _VenueID = ((Venue)venueBindingSource.Current).VenueID;
                //}
                this.populateDepartmentCourses(DepartmentID: _DepartmentID, VenueID: _VenueID);

            }
            
        }
        private void refreshDepartments()
        {
            this.populateDepartments();
        }
        private void refreshVenues()
        {
            populateVenues();
        }

        #endregion


        #region Populate Methods
        private void populateVenueCourses(int VenueID)
        {

            using (var Dbconnection = new MCDEntities())
            {
                venueAssociatedCourseBindingSource.DataSource = (from a in Dbconnection.VenueAssociatedCourses
                                                                 where a.VenueID == VenueID
                                                                 select a)
                                                                 .Include(a => a.Course)
                                                                 .Include(a => a.Course.LookupDepartment)
                                                                 .ToList<VenueAssociatedCourse>();
            };

        }
        private void populateDepartmentCourses(int DepartmentID, int VenueID)
        {
            List<Course> CC;
            using (var Dbconnection = new MCDEntities())
            {

                //&& 
                CC = (from a in Dbconnection.Courses
                      where a.DepartmentID == DepartmentID

                      select a).Except(from a in Dbconnection.VenueAssociatedCourses
                                       where a.VenueID == VenueID
                                       select a.Course).ToList<Course>();
            };

            courseBindingSource.DataSource = (from a in CC
                                              where a.CourseName.ToLower().Contains(txtFilterList.Text.ToLower())
                                              select a).ToList<Course>();

        }
        private void populateDepartments()
        {

            using (var Dbconnection = new MCDEntities())
            {
                this.lookupDepartmentBindingSource.DataSource = (from a in Dbconnection.LookupDepartments
                                                                 orderby a.DepartmentName
                                                                 select a).ToList<LookupDepartment>();
            };
        }
        private void populateVenues()
        {

            using (var Dbconnection = new MCDEntities())
            {
                venueBindingSource.DataSource = (from a in Dbconnection.Venues
                                                 select a)
                                                 .ToList<Venue>();
            };
        }
        #endregion
        #region Add Edit Venues

        #region Control Event Methods
        private void btnUpdateVenueFromForm_Click(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {
                using (System.Data.Entity.DbContextTransaction dbTran = Dbconnection.Database.BeginTransaction())
                {
                    try
                    {
                        //CRUD Operations
                        Venue CurrentVenue = (Venue)venueBindingSource.Current;
                        CurrentVenue.VenueName = this.txtVenueName.Text;

                        Dbconnection.Entry(CurrentVenue).State = System.Data.Entity.EntityState.Modified;
                        ////saves all above operations within one transaction
                        Dbconnection.SaveChanges();

                        //commit transaction
                        dbTran.Commit();
                        this.hideAddEditVenues();
                    }
                    catch (Exception ex)
                    {
                        if (ex is DbEntityValidationException)
                        {
                            foreach (DbEntityValidationResult entityErr in ((DbEntityValidationException)ex).EntityValidationErrors)
                            {
                                foreach (DbValidationError error in entityErr.ValidationErrors)
                                {
                                    MessageBox.Show(error.ErrorMessage, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //Rollback transaction if exception occurs
                        dbTran.Rollback();
                    }
                }
            };


            refreshVenues();
        }

        private void btnAddVenueFromForm_Click(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {
                using (System.Data.Entity.DbContextTransaction dbTran = Dbconnection.Database.BeginTransaction())
                {
                    try
                    {
                        //CRUD Operations
                        Venue newVenue = new Venue()
                        {
                            VenueName = this.txtVenueName.Text,
                            VenueMaxCapacity = 0
                        };
                        Dbconnection.Venues.Add(newVenue);
                        ////saves all above operations within one transaction
                        Dbconnection.SaveChanges();

                        //commit transaction
                        dbTran.Commit();
                        this.hideAddEditVenues();
                    }
                    catch (Exception ex)
                    {
                        if (ex is DbEntityValidationException)
                        {
                            foreach (DbEntityValidationResult entityErr in ((DbEntityValidationException)ex).EntityValidationErrors)
                            {
                                foreach (DbValidationError error in entityErr.ValidationErrors)
                                {
                                    MessageBox.Show(error.ErrorMessage, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //Rollback transaction if exception occurs
                        dbTran.Rollback();
                    }
                }
            };


            refreshVenues();
        }

        private void hideAddEditVenues()
        {


            splitContainerEditVenue.Panel1Collapsed = false;
            splitContainerEditVenue.Panel2Collapsed = true;
        }
        private void showAddEditVenues()
        {
            splitContainerEditVenue.Panel1Collapsed = true;
            splitContainerEditVenue.Panel2Collapsed = false;
        }
        private void btnCancelAddUpdate_Click(object sender, EventArgs e)
        {
            this.hideAddEditVenues();

        }

        private void btnAddVenue_Click(object sender, EventArgs e)
        {
            this.txtVenueName.Clear();
            btnAddVenueFromForm.Visible = true;
            btnUpdateVenueFromForm.Visible = false;
            showAddEditVenues();
        }

        private void btnRemoveVenue_Click(object sender, EventArgs e)
        {
            DialogResult Rtn = MessageBox.Show("Are you sure as this will remove all information Associated with this Venue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rtn == DialogResult.Yes)
            {

                using (var Dbconnection = new MCDEntities())
                {
                    using (System.Data.Entity.DbContextTransaction dbTran = Dbconnection.Database.BeginTransaction())
                    {
                        try
                        {
                            //CRUD Operations
                            Venue CurrentVenue = (Venue)venueBindingSource.Current;
                            
                            Dbconnection.Entry(CurrentVenue).State = System.Data.Entity.EntityState.Deleted;

                            ////saves all above operations within one transaction
                            Dbconnection.SaveChanges();

                            //commit transaction
                            dbTran.Commit();
                        }
                        catch (Exception ex)
                        {
                            if (ex is DbEntityValidationException)
                            {
                                foreach (DbEntityValidationResult entityErr in ((DbEntityValidationException)ex).EntityValidationErrors)
                                {
                                    foreach (DbValidationError error in entityErr.ValidationErrors)
                                    {
                                        MessageBox.Show(error.ErrorMessage, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            //Rollback transaction if exception occurs
                            dbTran.Rollback();
                        }
                    }
                };

                refreshVenues();
            }
        }

        private void btnUpdateVenue_Click(object sender, EventArgs e)
        {
            Venue currentVenue = (Venue)venueBindingSource.Current;
            txtVenueName.Text = currentVenue.VenueName;
            btnAddVenueFromForm.Visible = false;
            btnUpdateVenueFromForm.Visible = true;
            this.showAddEditVenues();
        }
        #endregion

        #endregion

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnLinkVenueCourse_Click(object sender, EventArgs e)
        {
            if (courseBindingSource.Count > 0)
            {
                int _CourseID = 0;
                int _VenueID = 0;

                _CourseID = ((Course)courseBindingSource.Current).CourseID;
                _VenueID = ((Venue)venueBindingSource.Current).VenueID;

                using (var Dbconnection = new MCDEntities())
                {

                    VenueAssociatedCourse newVenueAssociatedCourse = new VenueAssociatedCourse()
                    {
                        CourseID = _CourseID,
                        VenueID = _VenueID,
                        VenueMaxCapacity = (int)nudVuenueCapacity.Value
                    };

                    Dbconnection.VenueAssociatedCourses.Add(newVenueAssociatedCourse);
                    Dbconnection.SaveChanges();

                };
                nudVuenueCapacity.Value = 1;
                this.refreshDepartmentCourses();
                this.refreshVenueCourses();
            }

        }

        private void btnREmoveVenueCourse_Click(object sender, EventArgs e)
        {
            if (venueAssociatedCourseBindingSource.Count > 0)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    VenueAssociatedCourse VenueAssociatedCourseToRemove = ((VenueAssociatedCourse)venueAssociatedCourseBindingSource.Current);
                    Dbconnection.Entry(VenueAssociatedCourseToRemove).State = EntityState.Deleted;
                    Dbconnection.SaveChanges();
                };
                this.refreshDepartmentCourses();
                this.refreshVenueCourses();
            }

        }

        private void lookupDepartmentBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.refreshDepartmentCourses();
            this.refreshVenueCourses();
        }

        private void venueBindingSource_PositionChanged(object sender, EventArgs e)
        {
           
        }

        private void venueBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           
            this.refreshVenueCourses();
            this.refreshDepartmentCourses();
        }

        private void venueAssociatedCoursesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    VenueAssociatedCourse VenueAssociatedCourseObj = (VenueAssociatedCourse)row.DataBoundItem;
                    row.Cells[colCourseName.Index].Value = VenueAssociatedCourseObj.Course.CourseName.ToString();
                    row.Cells[colDepartment.Index].Value = VenueAssociatedCourseObj.Course.LookupDepartment.DepartmentName.ToString();


                }
            }
        }

        private void btnFilterList_Click(object sender, EventArgs e)
        {
            this.refreshDepartmentCourses();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            this.txtFilterList.Clear();
            this.refreshDepartmentCourses();
        }
    }
}
