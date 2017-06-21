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

namespace Impendulo.Enquiry.Development.ViewHistory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {
                equiryHistoryBindingSource.DataSource = (from a in Dbconnection.EquiryHistories



                                                             // .Include("LookupEquiryHistoryType")
                                                             //from b in a.LookupEquiryHistoryType
                                                         where a.EnquiryID == 7181
                                                         select a)
                                                       //.Include("Employee")
                                                       //.Include("Employee.Individual")
                                                       //.Include("Employee")
                                                       //.Include("Employee")
                                                       //.Include("Employee")
                                                       .ToList<EquiryHistory>();

                /*   rhiwoo1010
                   0782555379
                   clientclieny
                   coenie@rhino

   */

            };
        }
    }
}
