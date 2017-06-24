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

namespace Impendulo.Wizard.Development
{
    public partial class FrmWizardTemplateMenu : MetroForm
    {
        public FrmWizardTemplateMenu()
        {
            InitializeComponent();
        }

        private void FrmWizardTemplateMenu_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            using (frmWizardTemplateV2 frm = new frmWizardTemplateV2())
            {
                frm.ShowDialog();
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            using (frmWizardTemplate frm = new frmWizardTemplate())
            {
                frm.ShowDialog();
            }
        }
    }
}
