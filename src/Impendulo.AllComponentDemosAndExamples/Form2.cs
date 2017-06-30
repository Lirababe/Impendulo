using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.AllComponentDemosAndExamples
{
    public partial class Form2 : Form
    {

        public int YoutID { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the value of the ID you passed to this form is - " + YoutID, "Conformation", MessageBoxButtons.OK);
        }
    }
}
