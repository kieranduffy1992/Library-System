namespace LibrarySYS
{
    partial class frmUpdateMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateMember));
            this.grpUpdateMember = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.grpMembers = new System.Windows.Forms.GroupBox();
            this.grdMembers = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMemberUpdate = new System.Windows.Forms.GroupBox();
            this.grpMemberDetails = new System.Windows.Forms.GroupBox();
            this.grpUpdateMember.SuspendLayout();
            this.grpMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
            this.mnuMenu.SuspendLayout();
            this.grpMemberUpdate.SuspendLayout();
            this.grpMemberDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUpdateMember
            // 
            this.grpUpdateMember.BackColor = System.Drawing.Color.MintCream;
            this.grpUpdateMember.Controls.Add(this.dtpDOB);
            this.grpUpdateMember.Controls.Add(this.txtEmail);
            this.grpUpdateMember.Controls.Add(this.lblEmail);
            this.grpUpdateMember.Controls.Add(this.txtTown);
            this.grpUpdateMember.Controls.Add(this.lblTown);
            this.grpUpdateMember.Controls.Add(this.btnUpdate);
            this.grpUpdateMember.Controls.Add(this.txtStreet);
            this.grpUpdateMember.Controls.Add(this.lblStreet);
            this.grpUpdateMember.Controls.Add(this.txtID);
            this.grpUpdateMember.Controls.Add(this.txtFirstName);
            this.grpUpdateMember.Controls.Add(this.txtLastName);
            this.grpUpdateMember.Controls.Add(this.txtTelephone);
            this.grpUpdateMember.Controls.Add(this.txtCounty);
            this.grpUpdateMember.Controls.Add(this.lblFirstName);
            this.grpUpdateMember.Controls.Add(this.lblLastName);
            this.grpUpdateMember.Controls.Add(this.lblDOB);
            this.grpUpdateMember.Controls.Add(this.lblTelephone);
            this.grpUpdateMember.Controls.Add(this.lblCounty);
            this.grpUpdateMember.Controls.Add(this.lblID);
            this.grpUpdateMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateMember.Location = new System.Drawing.Point(57, 389);
            this.grpUpdateMember.Name = "grpUpdateMember";
            this.grpUpdateMember.Size = new System.Drawing.Size(966, 365);
            this.grpUpdateMember.TabIndex = 28;
            this.grpUpdateMember.TabStop = false;
            this.grpUpdateMember.Text = "Member Details";
            this.grpUpdateMember.Visible = false;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(661, 207);
            this.dtpDOB.MaxDate = new System.DateTime(2021, 2, 25, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(262, 26);
            this.dtpDOB.TabIndex = 38;
            this.dtpDOB.Value = new System.DateTime(2021, 2, 25, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtEmail.Location = new System.Drawing.Point(661, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 26);
            this.txtEmail.TabIndex = 32;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(552, 152);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(86, 29);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email:";
            // 
            // txtTown
            // 
            this.txtTown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTown.Location = new System.Drawing.Point(195, 261);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(257, 26);
            this.txtTown.TabIndex = 30;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(87, 258);
            this.lblTown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(85, 29);
            this.lblTown.TabIndex = 29;
            this.lblTown.Text = "Town:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(411, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 35);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtStreet.Location = new System.Drawing.Point(195, 207);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(257, 26);
            this.txtStreet.TabIndex = 27;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(82, 205);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(90, 29);
            this.lblStreet.TabIndex = 26;
            this.lblStreet.Text = "Street:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(195, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(78, 26);
            this.txtID.TabIndex = 25;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFirstName.Location = new System.Drawing.Point(195, 99);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(257, 26);
            this.txtFirstName.TabIndex = 24;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtLastName.Location = new System.Drawing.Point(195, 152);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(257, 26);
            this.txtLastName.TabIndex = 23;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTelephone.Location = new System.Drawing.Point(661, 99);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(257, 26);
            this.txtTelephone.TabIndex = 22;
            // 
            // txtCounty
            // 
            this.txtCounty.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCounty.Location = new System.Drawing.Point(661, 48);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(257, 26);
            this.txtCounty.TabIndex = 20;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(24, 95);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(148, 29);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(28, 152);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(144, 29);
            this.lblLastName.TabIndex = 18;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(563, 209);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(75, 29);
            this.lblDOB.TabIndex = 16;
            this.lblDOB.Text = "DOB:";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(491, 95);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(147, 29);
            this.lblTelephone.TabIndex = 15;
            this.lblTelephone.Text = "Telephone:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(538, 42);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(100, 29);
            this.lblCounty.TabIndex = 14;
            this.lblCounty.Text = "County:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(127, 44);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(45, 29);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID:";
            // 
            // grpMembers
            // 
            this.grpMembers.BackColor = System.Drawing.Color.MintCream;
            this.grpMembers.Controls.Add(this.grdMembers);
            this.grpMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMembers.Location = new System.Drawing.Point(138, 102);
            this.grpMembers.Name = "grpMembers";
            this.grpMembers.Size = new System.Drawing.Size(757, 241);
            this.grpMembers.TabIndex = 27;
            this.grpMembers.TabStop = false;
            this.grpMembers.Text = "Select Member to Update";
            this.grpMembers.Visible = false;
            // 
            // grdMembers
            // 
            this.grdMembers.AllowUserToAddRows = false;
            this.grdMembers.AllowUserToDeleteRows = false;
            this.grdMembers.AllowUserToResizeColumns = false;
            this.grdMembers.AllowUserToResizeRows = false;
            this.grdMembers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMembers.Location = new System.Drawing.Point(35, 25);
            this.grdMembers.Name = "grdMembers";
            this.grdMembers.RowHeadersWidth = 62;
            this.grdMembers.RowTemplate.Height = 28;
            this.grdMembers.Size = new System.Drawing.Size(687, 194);
            this.grdMembers.TabIndex = 1;
            this.grdMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMembers_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(639, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 35);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(361, 50);
            this.txtLName.MaxLength = 25;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(258, 28);
            this.txtLName.TabIndex = 25;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.MintCream;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(254, 55);
            this.lblLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(100, 20);
            this.lblLName.TabIndex = 24;
            this.lblLName.Text = "Last Name:";
            // 
            // mnuMenu
            // 
            this.mnuMenu.AutoSize = false;
            this.mnuMenu.BackColor = System.Drawing.Color.MintCream;
            this.mnuMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuMenu.GripMargin = new System.Windows.Forms.Padding(10);
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.mnuExit});
            this.mnuMenu.Location = new System.Drawing.Point(9, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Padding = new System.Windows.Forms.Padding(9, 0, 0, 3);
            this.mnuMenu.Size = new System.Drawing.Size(159, 46);
            this.mnuMenu.Stretch = false;
            this.mnuMenu.TabIndex = 40;
            this.mnuMenu.TabStop = true;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mnuHome
            // 
            this.mnuHome.BackColor = System.Drawing.Color.White;
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Padding = new System.Windows.Forms.Padding(6, 0, 6, 20);
            this.mnuHome.Size = new System.Drawing.Size(77, 43);
            this.mnuHome.Text = "Home";
            this.mnuHome.Click += new System.EventHandler(this.mnuHome_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Padding = new System.Windows.Forms.Padding(6, 0, 6, 20);
            this.mnuExit.Size = new System.Drawing.Size(55, 43);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // grpMemberUpdate
            // 
            this.grpMemberUpdate.BackColor = System.Drawing.Color.MintCream;
            this.grpMemberUpdate.Controls.Add(this.grpMemberDetails);
            this.grpMemberUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMemberUpdate.Location = new System.Drawing.Point(341, 118);
            this.grpMemberUpdate.Name = "grpMemberUpdate";
            this.grpMemberUpdate.Size = new System.Drawing.Size(1111, 868);
            this.grpMemberUpdate.TabIndex = 43;
            this.grpMemberUpdate.TabStop = false;
            this.grpMemberUpdate.Text = "Update Member";
            // 
            // grpMemberDetails
            // 
            this.grpMemberDetails.Controls.Add(this.lblLName);
            this.grpMemberDetails.Controls.Add(this.txtLName);
            this.grpMemberDetails.Controls.Add(this.btnSearch);
            this.grpMemberDetails.Controls.Add(this.grpUpdateMember);
            this.grpMemberDetails.Controls.Add(this.grpMembers);
            this.grpMemberDetails.Location = new System.Drawing.Point(30, 58);
            this.grpMemberDetails.Name = "grpMemberDetails";
            this.grpMemberDetails.Size = new System.Drawing.Size(1053, 792);
            this.grpMemberDetails.TabIndex = 13;
            this.grpMemberDetails.TabStop = false;
            this.grpMemberDetails.Text = "Member Details:";
            // 
            // frmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1492, 1035);
            this.Controls.Add(this.grpMemberUpdate);
            this.Controls.Add(this.mnuMenu);
            this.Name = "frmUpdateMember";
            this.Text = "UpdateMember";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUpdateMember_Load);
            this.grpUpdateMember.ResumeLayout(false);
            this.grpUpdateMember.PerformLayout();
            this.grpMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.grpMemberUpdate.ResumeLayout(false);
            this.grpMemberDetails.ResumeLayout(false);
            this.grpMemberDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUpdateMember;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox grpMembers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.DataGridView grdMembers;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.GroupBox grpMemberUpdate;
        private System.Windows.Forms.GroupBox grpMemberDetails;
    }
}