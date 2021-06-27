namespace LibrarySYS
{
    partial class frmRemoveMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveMember));
            this.grpDeleteMember = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMembers = new System.Windows.Forms.GroupBox();
            this.grdMembers = new System.Windows.Forms.DataGridView();
            this.grpRemoveMember = new System.Windows.Forms.GroupBox();
            this.grpMemberDetails = new System.Windows.Forms.GroupBox();
            this.grpDeleteMember.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            this.grpMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
            this.grpRemoveMember.SuspendLayout();
            this.grpMemberDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDeleteMember
            // 
            this.grpDeleteMember.BackColor = System.Drawing.Color.MintCream;
            this.grpDeleteMember.Controls.Add(this.txtEmail);
            this.grpDeleteMember.Controls.Add(this.lblEmail);
            this.grpDeleteMember.Controls.Add(this.lblTown);
            this.grpDeleteMember.Controls.Add(this.txtTown);
            this.grpDeleteMember.Controls.Add(this.btnDelete);
            this.grpDeleteMember.Controls.Add(this.txtStreet);
            this.grpDeleteMember.Controls.Add(this.lblStreet);
            this.grpDeleteMember.Controls.Add(this.txtID);
            this.grpDeleteMember.Controls.Add(this.txtFirstName);
            this.grpDeleteMember.Controls.Add(this.txtLastName);
            this.grpDeleteMember.Controls.Add(this.txtTelephone);
            this.grpDeleteMember.Controls.Add(this.txtDOB);
            this.grpDeleteMember.Controls.Add(this.txtCounty);
            this.grpDeleteMember.Controls.Add(this.lblFirstName);
            this.grpDeleteMember.Controls.Add(this.lblLastName);
            this.grpDeleteMember.Controls.Add(this.lblDOB);
            this.grpDeleteMember.Controls.Add(this.lblTelephone);
            this.grpDeleteMember.Controls.Add(this.lblCounty);
            this.grpDeleteMember.Controls.Add(this.lblID);
            this.grpDeleteMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDeleteMember.Location = new System.Drawing.Point(57, 389);
            this.grpDeleteMember.Name = "grpDeleteMember";
            this.grpDeleteMember.Size = new System.Drawing.Size(937, 381);
            this.grpDeleteMember.TabIndex = 22;
            this.grpDeleteMember.TabStop = false;
            this.grpDeleteMember.Text = "Remove Member";
            this.grpDeleteMember.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(645, 152);
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
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(136, 267);
            this.lblTown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(85, 29);
            this.lblTown.TabIndex = 30;
            this.lblTown.Text = "Town:";
            // 
            // txtTown
            // 
            this.txtTown.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTown.Enabled = false;
            this.txtTown.Location = new System.Drawing.Point(239, 271);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(218, 26);
            this.txtTown.TabIndex = 29;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(411, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 35);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStreet.Enabled = false;
            this.txtStreet.Location = new System.Drawing.Point(239, 209);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(218, 26);
            this.txtStreet.TabIndex = 27;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(131, 206);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(90, 29);
            this.lblStreet.TabIndex = 26;
            this.lblStreet.Text = "Street:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(239, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(72, 26);
            this.txtID.TabIndex = 25;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(239, 95);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(218, 26);
            this.txtFirstName.TabIndex = 24;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(239, 152);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(218, 26);
            this.txtLastName.TabIndex = 23;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTelephone.Enabled = false;
            this.txtTelephone.Location = new System.Drawing.Point(645, 95);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(257, 26);
            this.txtTelephone.TabIndex = 22;
            // 
            // txtDOB
            // 
            this.txtDOB.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDOB.Enabled = false;
            this.txtDOB.Location = new System.Drawing.Point(645, 209);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(119, 26);
            this.txtDOB.TabIndex = 21;
            // 
            // txtCounty
            // 
            this.txtCounty.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCounty.Enabled = false;
            this.txtCounty.Location = new System.Drawing.Point(645, 42);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(257, 26);
            this.txtCounty.TabIndex = 20;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(73, 95);
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
            this.lblLastName.Location = new System.Drawing.Point(77, 148);
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
            this.lblID.Location = new System.Drawing.Point(176, 42);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(45, 29);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(638, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 35);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(362, 50);
            this.txtLName.MaxLength = 25;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(258, 28);
            this.txtLName.TabIndex = 19;
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
            this.lblLName.TabIndex = 18;
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
            // grpMembers
            // 
            this.grpMembers.BackColor = System.Drawing.Color.MintCream;
            this.grpMembers.Controls.Add(this.grdMembers);
            this.grpMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMembers.Location = new System.Drawing.Point(138, 102);
            this.grpMembers.Name = "grpMembers";
            this.grpMembers.Size = new System.Drawing.Size(800, 264);
            this.grpMembers.TabIndex = 41;
            this.grpMembers.TabStop = false;
            this.grpMembers.Text = "Select Member to Remove";
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
            this.grdMembers.Location = new System.Drawing.Point(58, 25);
            this.grdMembers.Name = "grdMembers";
            this.grdMembers.RowHeadersWidth = 62;
            this.grdMembers.RowTemplate.Height = 28;
            this.grdMembers.Size = new System.Drawing.Size(686, 221);
            this.grdMembers.TabIndex = 0;
            this.grdMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMembers_CellClick);
            // 
            // grpRemoveMember
            // 
            this.grpRemoveMember.BackColor = System.Drawing.Color.MintCream;
            this.grpRemoveMember.Controls.Add(this.grpMemberDetails);
            this.grpRemoveMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRemoveMember.Location = new System.Drawing.Point(341, 118);
            this.grpRemoveMember.Name = "grpRemoveMember";
            this.grpRemoveMember.Size = new System.Drawing.Size(1111, 868);
            this.grpRemoveMember.TabIndex = 42;
            this.grpRemoveMember.TabStop = false;
            this.grpRemoveMember.Text = "Remove Member";
            // 
            // grpMemberDetails
            // 
            this.grpMemberDetails.Controls.Add(this.lblLName);
            this.grpMemberDetails.Controls.Add(this.grpMembers);
            this.grpMemberDetails.Controls.Add(this.grpDeleteMember);
            this.grpMemberDetails.Controls.Add(this.txtLName);
            this.grpMemberDetails.Controls.Add(this.btnSearch);
            this.grpMemberDetails.Location = new System.Drawing.Point(30, 58);
            this.grpMemberDetails.Name = "grpMemberDetails";
            this.grpMemberDetails.Size = new System.Drawing.Size(1053, 792);
            this.grpMemberDetails.TabIndex = 13;
            this.grpMemberDetails.TabStop = false;
            this.grpMemberDetails.Text = "Member Details:";
            // 
            // frmRemoveMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1492, 1035);
            this.Controls.Add(this.grpRemoveMember);
            this.Controls.Add(this.mnuMenu);
            this.Name = "frmRemoveMember";
            this.Text = "RemoveMember";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpDeleteMember.ResumeLayout(false);
            this.grpDeleteMember.PerformLayout();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.grpMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
            this.grpRemoveMember.ResumeLayout(false);
            this.grpMemberDetails.ResumeLayout(false);
            this.grpMemberDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDeleteMember;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpMembers;
        private System.Windows.Forms.DataGridView grdMembers;
        private System.Windows.Forms.GroupBox grpRemoveMember;
        private System.Windows.Forms.GroupBox grpMemberDetails;
    }
}