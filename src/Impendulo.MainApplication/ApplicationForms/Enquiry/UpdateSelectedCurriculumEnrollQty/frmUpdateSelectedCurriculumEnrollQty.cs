﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impendulo.Data.Models;
using MetroFramework.Forms;

namespace Impendulo.Enquiry.UpdateSelectedCurriculumEnrollQty.Deployment
{
    public partial class frmUpdateSelectedCurriculumEnrollQty : MetroForm
    {

        public CurriculumEnquiry CurrentCurriculumEnquiry { get; set; }
        public frmUpdateSelectedCurriculumEnrollQty()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUpdateSelectedCurriculumEnrollQty_Load(object sender, EventArgs e)
        {
            if (CurrentCurriculumEnquiry != null)
            {
                //if (this.nudQtyToEnroll.Minimum > )
                //{

                //}
                //this.nudQtyToEnroll.Value = CurrentCurriculumEnquiry.EnrollmentQuanity;
            }else
            {
                this.nudQtyToEnroll.Value = 1;
            }
        }

        private void btnUpdateSelectedCurriculum_Click(object sender, EventArgs e)
        {
            CurrentCurriculumEnquiry.EnrollmentQuanity = (int)this.nudQtyToEnroll.Value;
            this.Close();
        }
    }
}
