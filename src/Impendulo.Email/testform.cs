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

namespace Impendulo.Email
{
    public partial class testform : MetroFramework.Forms.MetroForm
    {
        public testform()
        {
            InitializeComponent();
        }

        private void testform_Load(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {
                individualBindingSource.DataSource = (from a in Dbconnection.Individuals
                                                      select a).ToList<Individual>();
            };

        }
    }
}
