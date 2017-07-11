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
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace GridViewDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {
                enquiryBindingSource.DataSource = (from a in Dbconnection.Enquiries select a)
                                    .Include("Individuals")
                                    .Include("Individuals.ContactDetails")
                                    .Include("CurriculumEnquiries")
                                                   .ToList();

            };
        }

        private void TEst()
        {
            //Do something here



        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {
                using (System.Data.Entity.DbContextTransaction dbTran = Dbconnection.Database.BeginTransaction())
                {
                    try
                    {
                        //CRUD Operations
                        Student newStudent = new Student()
                        {
                            StudentID = 0,
                            StudentIDNumber = "",
                            Individual = new Individual()
                            {
                                IndividualFirstName = "sdafsadfdsa",
                                IndividualSecondName = "sdf",
                                IndividualLastname = "4324"
                            }
                        };

                        Dbconnection.Students.Add(newStudent);
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

        }
    }
}
