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

namespace Impendulo.Development.Students
{
    public partial class frmStudentAddUpdate : MetroForm
    {
        public int CurrentPosition { get; set; }
        public Boolean IsSuccessfullySaved { get; set; }

        private Boolean MustSaveItems = false;

        public Employee CurrentEmployeeLoggedIn
        {
            get;
            set;
        }

        public frmStudentAddUpdate()
        {
            InitializeComponent();
            IsSuccessfullySaved = false;

        }

        private void frmStudentAddUpdate_Load(object sender, EventArgs e)
        {
            if (CurrentEmployeeLoggedIn == null)
            {
                /*
             * Thismust be Commmented out or removed in the production version this is just for Develpoement Testing.
             */
                using (var Dbconnection = new MCDEntities())
                {
                    CurrentEmployeeLoggedIn = (from a in Dbconnection.Employees
                                               select a).FirstOrDefault<Employee>();
                };

                /***************************************************************************************/
                // MessageBox.Show("It is Required that you be logged in to use the feature.\n Login and try again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // this.Close();

            }


            CurrentPosition = 0;
            this.setCenterDisplayPanels();
            this.setNavigationControls();
            this.loadupStep();
        }

        #region Wizard Comopnents
        #region "Navigation Controls"
        private void navigateForward()
        {
            if (ValidateStep())
            {
                if (CurrentPosition + 1 < MainflowLayoutPanel.Controls.Count)
                {
                    //if step validation is passed the next window is display by incrementing the CurrentPosition Counter.
                    CurrentPosition++;
                }
                else
                {
                    //on last step which will close if the finish b=button is selected.
                    DialogResult res = MessageBox.Show("Are Details Correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (DialogResult.Yes == res)
                    {
                        MustSaveItems = true;
                        this.Close();
                    }
                }
                this.setCenterDisplayPanels();
                this.setNavigationControls();
                this.loadupStep();
            }
        }
        private void navigateBackwards()
        {
            if (CurrentPosition - 1 >= 0)
            {
                CurrentPosition--;
            }
            else
            {

                //CurrentPosition = 5;
            }
            //Hide All Panels inside the MainFlowPanel
            //MainflowLayoutPanel
            this.setCenterDisplayPanels();
            this.setNavigationControls();
            this.loadupStep();
        }


        private void setNavigationControls()
        {
            if (CurrentPosition == 0)
            {
                btnPreviousSection.Visible = false;
                btnNextSection.Text = "Next";
            }
            else
            {
                if (CurrentPosition == MainflowLayoutPanel.Controls.Count - 1)
                {
                    btnNextSection.Text = "Save";

                }
                else
                {
                    btnNextSection.Text = "Next";

                }
                btnPreviousSection.Visible = true;
            }
            int iAmountOfSteps = 0;
            foreach (var Control in tableLayoutPanel5.Controls)
            {
                if (Control is Label)
                {
                    iAmountOfSteps++;
                    //NavigationPanel
                    var lblObj = (Label)Control;
                    if (Convert.ToInt32(lblObj.Tag.ToString()) == CurrentPosition)
                    {
                        lblObj.Font = new Font(lblObj.Font, FontStyle.Bold);
                        lblObj.Margin = new Padding(6, 7, 3, 3);
                    }
                    else
                    {
                        lblObj.Font = new Font(lblObj.Font, FontStyle.Regular);
                        lblObj.Margin = new Padding(3, 7, 3, 3);
                    }
                }
            }
            double dblPercentageComplete = (((Convert.ToDouble(CurrentPosition + 1) / Convert.ToDouble(iAmountOfSteps))) * 100);
            wizardStepProgressBar.Value = Convert.ToInt32(dblPercentageComplete);

        }
        private void setCenterDisplayPanels()
        {
            foreach (Control gbControl in MainflowLayoutPanel.Controls)
            {
                if (gbControl is GroupBox)
                {
                    var gbObj = (GroupBox)gbControl;
                    gbObj.Hide();
                }
            }
            foreach (Control Control in MainflowLayoutPanel.Controls)
            {
                if (Control is GroupBox)
                {
                    var gbObj = (GroupBox)Control;
                    if (Convert.ToInt32(gbObj.Tag.ToString()) == CurrentPosition)
                    {
                        gbObj.Show();
                        gbObj.Width = MainflowLayoutPanel.Width;
                        gbObj.Height = MainflowLayoutPanel.Height;
                    }
                    else
                    {
                        gbObj.Hide();
                        gbObj.Width = 0;
                        gbObj.Height = 0;
                    }
                }
            }
        }
        #endregion

        #region Wizard Methods
        private void loadupStep()
        {
            switch (CurrentPosition)
            {
                case 0:
                    this.loadupStepOne();
                    break;
                case 1:
                    this.loadupStepTwo();
                    break;
                case 2:
                    this.loadupStepThree();
                    break;
                case 3:
                    this.loadupStepFour();
                    break;
                case 4:
                    this.loadupStepFive();
                    break;
                case 5:
                    this.loadupStepSix();
                    break;
                case 6:
                    this.loadupStepSeven();
                    break;
                case 7:
                    this.loadupStepEight();
                    break;
                default:

                    break;
            }

        }
        private void btnPreviousSection_Click(object sender, EventArgs e)
        {
            navigateBackwards();
        }

        private void btnNextSection_Click(object sender, EventArgs e)
        {
            navigateForward();
        }
        private Boolean ValidateStep()
        {

            Boolean bRtn = true;
            switch (CurrentPosition)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;

                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;

                default:
                    bRtn = false;
                    break;
            }

            return bRtn;
        }

        #region "Each Wizard Page Loadup"
        private void loadupStepOne()
        {


        }
        private void loadupStepTwo()
        {





        }
        private void loadupStepThree()
        {



        }


        private void loadupStepFour()
        {

        }
        private void loadupStepFive()
        {

        }
        private void loadupStepSix()
        {

        }
        private void loadupStepSeven()
        {

        }
        private void loadupStepEight()
        {

        }

        #endregion

        #endregion

        #endregion
    }
}
