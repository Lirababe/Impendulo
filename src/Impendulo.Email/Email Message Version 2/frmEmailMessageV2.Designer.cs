namespace Impendulo.Email.Email_Message_Version_2
{
    partial class frmEmailMessageV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmailMessageV2));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMessageCcAddress = new System.Windows.Forms.TextBox();
            this.txtMessageBccAddress = new System.Windows.Forms.TextBox();
            this.txMessageBody = new System.Windows.Forms.RichTextBox();
            this.txtMessageSubject = new System.Windows.Forms.TextBox();
            this.txtMessageToAddress = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dgvMessageAttachments = new System.Windows.Forms.DataGridView();
            this.colRemoveAttachments = new System.Windows.Forms.DataGridViewLinkColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddAttachment = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnToAddress = new MetroFramework.Controls.MetroButton();
            this.btnBCCddress = new MetroFramework.Controls.MetroButton();
            this.btnCCAddress = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessageAttachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metroLabel1);
            this.groupBox4.Controls.Add(this.metroTile1);
            this.groupBox4.Controls.Add(this.btnCCAddress);
            this.groupBox4.Controls.Add(this.btnBCCddress);
            this.groupBox4.Controls.Add(this.btnToAddress);
            this.groupBox4.Controls.Add(this.txtMessageCcAddress);
            this.groupBox4.Controls.Add(this.txtMessageBccAddress);
            this.groupBox4.Controls.Add(this.txMessageBody);
            this.groupBox4.Controls.Add(this.txtMessageSubject);
            this.groupBox4.Controls.Add(this.txtMessageToAddress);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(683, 286);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // txtMessageCcAddress
            // 
            this.txtMessageCcAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageCcAddress.Location = new System.Drawing.Point(190, 51);
            this.txtMessageCcAddress.Name = "txtMessageCcAddress";
            this.txtMessageCcAddress.Size = new System.Drawing.Size(481, 20);
            this.txtMessageCcAddress.TabIndex = 14;
            // 
            // txtMessageBccAddress
            // 
            this.txtMessageBccAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageBccAddress.Location = new System.Drawing.Point(190, 80);
            this.txtMessageBccAddress.Name = "txtMessageBccAddress";
            this.txtMessageBccAddress.Size = new System.Drawing.Size(481, 20);
            this.txtMessageBccAddress.TabIndex = 12;
            // 
            // txMessageBody
            // 
            this.txMessageBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txMessageBody.Location = new System.Drawing.Point(6, 133);
            this.txMessageBody.Name = "txMessageBody";
            this.txMessageBody.Size = new System.Drawing.Size(665, 147);
            this.txMessageBody.TabIndex = 10;
            this.txMessageBody.Text = "";
            // 
            // txtMessageSubject
            // 
            this.txtMessageSubject.Location = new System.Drawing.Point(190, 107);
            this.txtMessageSubject.Name = "txtMessageSubject";
            this.txtMessageSubject.Size = new System.Drawing.Size(481, 20);
            this.txtMessageSubject.TabIndex = 6;
            // 
            // txtMessageToAddress
            // 
            this.txtMessageToAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageToAddress.Location = new System.Drawing.Point(190, 22);
            this.txtMessageToAddress.Name = "txtMessageToAddress";
            this.txtMessageToAddress.Size = new System.Drawing.Size(481, 20);
            this.txtMessageToAddress.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.toolStripContainer1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(683, 180);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "List Of Attachments";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvMessageAttachments);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(677, 136);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 16);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(677, 161);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.bindingNavigator1);
            // 
            // dgvMessageAttachments
            // 
            this.dgvMessageAttachments.AllowUserToAddRows = false;
            this.dgvMessageAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessageAttachments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRemoveAttachments,
            this.FileName,
            this.FilePath});
            this.dgvMessageAttachments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMessageAttachments.Location = new System.Drawing.Point(0, 0);
            this.dgvMessageAttachments.Name = "dgvMessageAttachments";
            this.dgvMessageAttachments.Size = new System.Drawing.Size(677, 136);
            this.dgvMessageAttachments.TabIndex = 0;
            // 
            // colRemoveAttachments
            // 
            this.colRemoveAttachments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRemoveAttachments.HeaderText = "";
            this.colRemoveAttachments.Name = "colRemoveAttachments";
            this.colRemoveAttachments.Text = "Remove";
            this.colRemoveAttachments.Width = 5;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.Width = 79;
            // 
            // FilePath
            // 
            this.FilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FilePath.HeaderText = "Path";
            this.FilePath.Name = "FilePath";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAddAttachment,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(677, 25);
            this.bindingNavigator1.Stretch = true;
            this.bindingNavigator1.TabIndex = 0;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddAttachment
            // 
            this.btnAddAttachment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAttachment.Image")));
            this.btnAddAttachment.Name = "btnAddAttachment";
            this.btnAddAttachment.RightToLeftAutoMirrorImage = true;
            this.btnAddAttachment.Size = new System.Drawing.Size(115, 22);
            this.btnAddAttachment.Text = "Add Attachment";
            this.btnAddAttachment.ToolTipText = "Add New Attachment";
            this.btnAddAttachment.Click += new System.EventHandler(this.btnAddAttachment_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(136, 22);
            this.toolStripButton1.Text = "Remove Attachment";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Size = new System.Drawing.Size(683, 470);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnToAddress
            // 
            this.btnToAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToAddress.Location = new System.Drawing.Point(119, 19);
            this.btnToAddress.Name = "btnToAddress";
            this.btnToAddress.Size = new System.Drawing.Size(65, 23);
            this.btnToAddress.TabIndex = 15;
            this.btnToAddress.Text = "To...";
            this.toolTip1.SetToolTip(this.btnToAddress, "Select Contact(s) To Send To.");
            this.btnToAddress.Click += new System.EventHandler(this.btnToAddress_Click);
            // 
            // btnBCCddress
            // 
            this.btnBCCddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBCCddress.Location = new System.Drawing.Point(119, 77);
            this.btnBCCddress.Name = "btnBCCddress";
            this.btnBCCddress.Size = new System.Drawing.Size(65, 23);
            this.btnBCCddress.TabIndex = 16;
            this.btnBCCddress.Text = "Bcc...";
            this.toolTip1.SetToolTip(this.btnBCCddress, "Select Contact(s) To Blind  to Send a Copy");
            this.btnBCCddress.Click += new System.EventHandler(this.btnBCCddress_Click);
            // 
            // btnCCAddress
            // 
            this.btnCCAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCCAddress.Location = new System.Drawing.Point(119, 48);
            this.btnCCAddress.Name = "btnCCAddress";
            this.btnCCAddress.Size = new System.Drawing.Size(65, 23);
            this.btnCCAddress.TabIndex = 17;
            this.btnCCAddress.Text = "Cc...";
            this.toolTip1.SetToolTip(this.btnCCAddress, "Select Contact(s) To Carbon Copy.");
            this.btnCCAddress.Click += new System.EventHandler(this.btnCCAddress_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(6, 19);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(107, 108);
            this.metroTile1.TabIndex = 18;
            this.metroTile1.Text = "Send Message";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.metroTile1, "Send Email Mesage");
            this.metroTile1.UseTileImage = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(126, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Subject :";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 250;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmEmailMessageV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 550);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmEmailMessageV2";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Text = "New Email Message";
            this.Load += new System.EventHandler(this.frmEmailMessageV2_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessageAttachments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.RichTextBox txMessageBody;
        public System.Windows.Forms.TextBox txtMessageSubject;
        public System.Windows.Forms.TextBox txtMessageToAddress;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dgvMessageAttachments;
        private System.Windows.Forms.DataGridViewLinkColumn colRemoveAttachments;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnAddAttachment;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TextBox txtMessageCcAddress;
        public System.Windows.Forms.TextBox txtMessageBccAddress;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private MetroFramework.Controls.MetroButton btnToAddress;
        private MetroFramework.Controls.MetroButton btnCCAddress;
        private MetroFramework.Controls.MetroButton btnBCCddress;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}