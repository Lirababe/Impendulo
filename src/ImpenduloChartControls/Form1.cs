using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpenduloChartControls
{
    /// <summary>
    /// Links to learn Chart Control
    /// http://www.c-sharpcorner.com/UploadFile/1e050f/chart-control-in-windows-form-application/
    /// https://msdn.microsoft.com/en-us/library/dd456753.aspx
    /// https://msdn.microsoft.com/en-us/library/dd489237.aspx
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillChart();
        }
        //fillChart method  
        private void fillChart()
        {
            //AddXY value in chart1 in series named as Salary  
            chart1.Series["Salary"].Points.AddXY("Ajay", "10000");
            chart1.Series["Salary"].Points.AddXY("Ramesh", "8000");
            chart1.Series["Salary"].Points.AddXY("Ankit", "7000");
            chart1.Series["Salary"].Points.AddXY("Gurmeet", "10000");
            chart1.Series["Salary"].Points.AddXY("Suresh", "8500");
            //chart title  
            chart1.Titles.Add("Salary Chart");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
