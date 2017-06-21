namespace Impendulo.Enquiry.Development.ViewHistory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label dateEnquiryUpdatedLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label enqueryHistoryIDLabel;
            System.Windows.Forms.Label enquiryNotesLabel;
            System.Windows.Forms.Label fullNameLabel;
            this.equiryHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equiryHistoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.equiryHistoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dateEnquiryUpdatedTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.enqueryHistoryIDTextBox = new System.Windows.Forms.TextBox();
            this.enquiryNotesTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            dateEnquiryUpdatedLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            enqueryHistoryIDLabel = new System.Windows.Forms.Label();
            enquiryNotesLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equiryHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiryHistoryBindingNavigator)).BeginInit();
            this.equiryHistoryBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // equiryHistoryBindingSource
            // 
            this.equiryHistoryBindingSource.DataSource = typeof(Impendulo.Data.Models.EquiryHistory);
            // 
            // equiryHistoryBindingNavigator
            // 
            this.equiryHistoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.equiryHistoryBindingNavigator.BindingSource = this.equiryHistoryBindingSource;
            this.equiryHistoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.equiryHistoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.equiryHistoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.equiryHistoryBindingNavigatorSaveItem});
            this.equiryHistoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.equiryHistoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.equiryHistoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.equiryHistoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.equiryHistoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.equiryHistoryBindingNavigator.Name = "equiryHistoryBindingNavigator";
            this.equiryHistoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.equiryHistoryBindingNavigator.Size = new System.Drawing.Size(639, 25);
            this.equiryHistoryBindingNavigator.TabIndex = 0;
            this.equiryHistoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // equiryHistoryBindingNavigatorSaveItem
            // 
            this.equiryHistoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.equiryHistoryBindingNavigatorSaveItem.Enabled = false;
            this.equiryHistoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("equiryHistoryBindingNavigatorSaveItem.Image")));
            this.equiryHistoryBindingNavigatorSaveItem.Name = "equiryHistoryBindingNavigatorSaveItem";
            this.equiryHistoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.equiryHistoryBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // dateEnquiryUpdatedLabel
            // 
            dateEnquiryUpdatedLabel.AutoSize = true;
            dateEnquiryUpdatedLabel.Location = new System.Drawing.Point(64, 81);
            dateEnquiryUpdatedLabel.Name = "dateEnquiryUpdatedLabel";
            dateEnquiryUpdatedLabel.Size = new System.Drawing.Size(115, 13);
            dateEnquiryUpdatedLabel.TabIndex = 1;
            dateEnquiryUpdatedLabel.Text = "Date Enquiry Updated:";
            // 
            // dateEnquiryUpdatedTextBox
            // 
            this.dateEnquiryUpdatedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiryHistoryBindingSource, "DateEnquiryUpdated", true));
            this.dateEnquiryUpdatedTextBox.Location = new System.Drawing.Point(185, 78);
            this.dateEnquiryUpdatedTextBox.Name = "dateEnquiryUpdatedTextBox";
            this.dateEnquiryUpdatedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateEnquiryUpdatedTextBox.TabIndex = 2;
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(64, 107);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 3;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiryHistoryBindingSource, "EmployeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(185, 104);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeeIDTextBox.TabIndex = 4;
            // 
            // enqueryHistoryIDLabel
            // 
            enqueryHistoryIDLabel.AutoSize = true;
            enqueryHistoryIDLabel.Location = new System.Drawing.Point(64, 133);
            enqueryHistoryIDLabel.Name = "enqueryHistoryIDLabel";
            enqueryHistoryIDLabel.Size = new System.Drawing.Size(98, 13);
            enqueryHistoryIDLabel.TabIndex = 5;
            enqueryHistoryIDLabel.Text = "Enquery History ID:";
            // 
            // enqueryHistoryIDTextBox
            // 
            this.enqueryHistoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiryHistoryBindingSource, "EnqueryHistoryID", true));
            this.enqueryHistoryIDTextBox.Location = new System.Drawing.Point(185, 130);
            this.enqueryHistoryIDTextBox.Name = "enqueryHistoryIDTextBox";
            this.enqueryHistoryIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.enqueryHistoryIDTextBox.TabIndex = 6;
            // 
            // enquiryNotesLabel
            // 
            enquiryNotesLabel.AutoSize = true;
            enquiryNotesLabel.Location = new System.Drawing.Point(64, 159);
            enquiryNotesLabel.Name = "enquiryNotesLabel";
            enquiryNotesLabel.Size = new System.Drawing.Size(76, 13);
            enquiryNotesLabel.TabIndex = 7;
            enquiryNotesLabel.Text = "Enquiry Notes:";
            // 
            // enquiryNotesTextBox
            // 
            this.enquiryNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiryHistoryBindingSource, "EnquiryNotes", true));
            this.enquiryNotesTextBox.Location = new System.Drawing.Point(185, 156);
            this.enquiryNotesTextBox.Name = "enquiryNotesTextBox";
            this.enquiryNotesTextBox.Size = new System.Drawing.Size(100, 20);
            this.enquiryNotesTextBox.TabIndex = 8;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(122, 188);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 9;
            fullNameLabel.Text = "Full Name:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiryHistoryBindingSource, "Employee.Individual.FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(185, 185);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fullNameTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 259);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(dateEnquiryUpdatedLabel);
            this.Controls.Add(this.dateEnquiryUpdatedTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(enqueryHistoryIDLabel);
            this.Controls.Add(this.enqueryHistoryIDTextBox);
            this.Controls.Add(enquiryNotesLabel);
            this.Controls.Add(this.enquiryNotesTextBox);
            this.Controls.Add(this.equiryHistoryBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equiryHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiryHistoryBindingNavigator)).EndInit();
            this.equiryHistoryBindingNavigator.ResumeLayout(false);
            this.equiryHistoryBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource equiryHistoryBindingSource;
        private System.Windows.Forms.BindingNavigator equiryHistoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton equiryHistoryBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dateEnquiryUpdatedTextBox;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.TextBox enqueryHistoryIDTextBox;
        private System.Windows.Forms.TextBox enquiryNotesTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
    }
}