using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamically_Set_Connection_String.Database_Enumeration
{
    public partial class frmDatabaseEnumeration : Form
    {
        public frmDatabaseEnumeration()
        {
            InitializeComponent();
        }

        private void frmDatabaseEnumeration_Load(object sender, EventArgs e)
        {
            // Retrieve the enumerator instance and then the data.  
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();

            // Display the contents of the table.  
            DisplayData(table);

            //Console.WriteLine("Press any key to continue.");
            //Console.ReadKey();
            //txtRichTextBox.Text = "";
        }
        private void DisplayData(System.Data.DataTable table)
        {
            foreach (System.Data.DataRow row in table.Rows)
            {
                //ServerName
                txtRichTextBox.Text +=  row["ServerName"] + "\n";
                //foreach (System.Data.DataColumn col in table.Columns) 
                //{
                //    //Console.WriteLine("{0} = {1}", col.ColumnName, row[col]);
                //    txtRichTextBox.Text += col.ColumnName + " " + row[col] + "\n";
                //}
               
            }
        }
    }
}
