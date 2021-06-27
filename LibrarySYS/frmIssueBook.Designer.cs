namespace LibrarySYS
{
    partial class frmIssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueBook));
            this.grpLoanDetails = new System.Windows.Forms.GroupBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.txtLoanID = new System.Windows.Forms.TextBox();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.lblNoBooks = new System.Windows.Forms.Label();
            this.lblLoanID = new System.Windows.Forms.Label();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMemberDetails = new System.Windows.Forms.GroupBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpOverdueBooks = new System.Windows.Forms.GroupBox();
            this.lstOverdueBooks = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpLoanBooks = new System.Windows.Forms.GroupBox();
            this.grpBookDetails = new System.Windows.Forms.GroupBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdBooksSummary = new System.Windows.Forms.DataGridView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpIssueBooks = new System.Windows.Forms.GroupBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpLoanDetails.SuspendLayout();
            this.grpMember.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            this.grpMemberDetails.SuspendLayout();
            this.grpOverdueBooks.SuspendLayout();
            this.grpLoanBooks.SuspendLayout();
            this.grpBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooksSummary)).BeginInit();
            this.grpIssueBooks.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoanDetails
            // 
            this.grpLoanDetails.BackColor = System.Drawing.Color.MintCream;
            this.grpLoanDetails.Controls.Add(this.dtpDueDate);
            this.grpLoanDetails.Controls.Add(this.lblDueDate);
            this.grpLoanDetails.Controls.Add(this.dtpIssueDate);
            this.grpLoanDetails.Controls.Add(this.lblIssueDate);
            this.grpLoanDetails.Controls.Add(this.txtLoanID);
            this.grpLoanDetails.Controls.Add(this.txtMemID);
            this.grpLoanDetails.Controls.Add(this.lblNoBooks);
            this.grpLoanDetails.Controls.Add(this.lblLoanID);
            this.grpLoanDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoanDetails.Location = new System.Drawing.Point(6, 541);
            this.grpLoanDetails.Name = "grpLoanDetails";
            this.grpLoanDetails.Size = new System.Drawing.Size(509, 195);
            this.grpLoanDetails.TabIndex = 37;
            this.grpLoanDetails.TabStop = false;
            this.grpLoanDetails.Text = "Loan Details";
            this.grpLoanDetails.Visible = false;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Enabled = false;
            this.dtpDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Location = new System.Drawing.Point(136, 141);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(270, 26);
            this.dtpDueDate.TabIndex = 49;
            this.dtpDueDate.Value = new System.DateTime(2021, 3, 1, 0, 0, 0, 0);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.Red;
            this.lblDueDate.Location = new System.Drawing.Point(1, 142);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(138, 25);
            this.lblDueDate.TabIndex = 48;
            this.lblDueDate.Text = "**Due Date**";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Enabled = false;
            this.dtpIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDate.Location = new System.Drawing.Point(136, 87);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(267, 26);
            this.dtpIssueDate.TabIndex = 47;
            this.dtpIssueDate.Value = new System.DateTime(2021, 3, 1, 0, 0, 0, 0);
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.Location = new System.Drawing.Point(1, 87);
            this.lblIssueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(122, 25);
            this.lblIssueDate.TabIndex = 46;
            this.lblIssueDate.Text = "Issue Date:";
            // 
            // txtLoanID
            // 
            this.txtLoanID.BackColor = System.Drawing.SystemColors.Control;
            this.txtLoanID.Enabled = false;
            this.txtLoanID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLoanID.Location = new System.Drawing.Point(123, 36);
            this.txtLoanID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoanID.MaxLength = 4;
            this.txtLoanID.Name = "txtLoanID";
            this.txtLoanID.Size = new System.Drawing.Size(75, 26);
            this.txtLoanID.TabIndex = 45;
            // 
            // txtMemID
            // 
            this.txtMemID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMemID.Enabled = false;
            this.txtMemID.Location = new System.Drawing.Point(336, 37);
            this.txtMemID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMemID.MaxLength = 4;
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(70, 26);
            this.txtMemID.TabIndex = 45;
            // 
            // lblNoBooks
            // 
            this.lblNoBooks.AutoSize = true;
            this.lblNoBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBooks.Location = new System.Drawing.Point(235, 36);
            this.lblNoBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoBooks.Name = "lblNoBooks";
            this.lblNoBooks.Size = new System.Drawing.Size(93, 25);
            this.lblNoBooks.TabIndex = 42;
            this.lblNoBooks.Text = "Mem ID:";
            // 
            // lblLoanID
            // 
            this.lblLoanID.AutoSize = true;
            this.lblLoanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanID.Location = new System.Drawing.Point(18, 36);
            this.lblLoanID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanID.Name = "lblLoanID";
            this.lblLoanID.Size = new System.Drawing.Size(94, 25);
            this.lblLoanID.TabIndex = 41;
            this.lblLoanID.Text = "Loan ID:";
            // 
            // grpMember
            // 
            this.grpMember.BackColor = System.Drawing.Color.MintCream;
            this.grpMember.Controls.Add(this.btnEnter);
            this.grpMember.Controls.Add(this.txtMemberID);
            this.grpMember.Controls.Add(this.lblMemberID);
            this.grpMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMember.Location = new System.Drawing.Point(6, 33);
            this.grpMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMember.Name = "grpMember";
            this.grpMember.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMember.Size = new System.Drawing.Size(184, 198);
            this.grpMember.TabIndex = 42;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Enter MemberID";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnEnter.Location = new System.Drawing.Point(23, 103);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Padding = new System.Windows.Forms.Padding(8);
            this.btnEnter.Size = new System.Drawing.Size(119, 45);
            this.btnEnter.TabIndex = 42;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(113, 37);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMemberID.MaxLength = 4;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(50, 26);
            this.txtMemberID.TabIndex = 41;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(8, 37);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(97, 20);
            this.lblMemberID.TabIndex = 39;
            this.lblMemberID.Text = "Member ID";
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
            this.mnuMenu.TabIndex = 43;
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
            // grpMemberDetails
            // 
            this.grpMemberDetails.BackColor = System.Drawing.Color.MintCream;
            this.grpMemberDetails.Controls.Add(this.lblTip);
            this.grpMemberDetails.Controls.Add(this.btnProceed);
            this.grpMemberDetails.Controls.Add(this.txtEmail);
            this.grpMemberDetails.Controls.Add(this.lblEmail);
            this.grpMemberDetails.Controls.Add(this.txtTelNo);
            this.grpMemberDetails.Controls.Add(this.lblTelNo);
            this.grpMemberDetails.Controls.Add(this.txtLastName);
            this.grpMemberDetails.Controls.Add(this.txtFirstName);
            this.grpMemberDetails.Controls.Add(this.lblLastName);
            this.grpMemberDetails.Controls.Add(this.lblFirstName);
            this.grpMemberDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMemberDetails.Location = new System.Drawing.Point(228, 33);
            this.grpMemberDetails.Name = "grpMemberDetails";
            this.grpMemberDetails.Size = new System.Drawing.Size(670, 198);
            this.grpMemberDetails.TabIndex = 47;
            this.grpMemberDetails.TabStop = false;
            this.grpMemberDetails.Text = "Member Details";
            this.grpMemberDetails.Visible = false;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.ForeColor = System.Drawing.Color.Red;
            this.lblTip.Location = new System.Drawing.Point(435, 143);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(212, 20);
            this.lblTip.TabIndex = 51;
            this.lblTip.Text = "**Click Proceed to continue**";
            this.lblTip.Visible = false;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.SystemColors.Control;
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnProceed.Location = new System.Drawing.Point(272, 125);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Padding = new System.Windows.Forms.Padding(8);
            this.btnProceed.Size = new System.Drawing.Size(112, 42);
            this.btnProceed.TabIndex = 50;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(422, 86);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MaxLength = 4;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(231, 26);
            this.txtEmail.TabIndex = 49;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(356, 89);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 20);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "Email:";
            // 
            // txtTelNo
            // 
            this.txtTelNo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTelNo.Enabled = false;
            this.txtTelNo.Location = new System.Drawing.Point(105, 83);
            this.txtTelNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelNo.MaxLength = 4;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(203, 26);
            this.txtTelNo.TabIndex = 47;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelNo.Location = new System.Drawing.Point(7, 86);
            this.lblTelNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(98, 20);
            this.lblTelNo.TabIndex = 46;
            this.lblTelNo.Text = "Telephone:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(422, 31);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.MaxLength = 4;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(231, 26);
            this.txtLastName.TabIndex = 45;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(105, 31);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.MaxLength = 4;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(203, 26);
            this.txtFirstName.TabIndex = 44;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(314, 33);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 20);
            this.lblLastName.TabIndex = 42;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(4, 37);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 20);
            this.lblFirstName.TabIndex = 41;
            this.lblFirstName.Text = "First Name:";
            // 
            // grpOverdueBooks
            // 
            this.grpOverdueBooks.BackColor = System.Drawing.Color.MintCream;
            this.grpOverdueBooks.Controls.Add(this.lstOverdueBooks);
            this.grpOverdueBooks.Controls.Add(this.btnCancel);
            this.grpOverdueBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOverdueBooks.Location = new System.Drawing.Point(921, 33);
            this.grpOverdueBooks.Name = "grpOverdueBooks";
            this.grpOverdueBooks.Size = new System.Drawing.Size(307, 198);
            this.grpOverdueBooks.TabIndex = 48;
            this.grpOverdueBooks.TabStop = false;
            this.grpOverdueBooks.Text = "Overdue Books";
            this.grpOverdueBooks.Visible = false;
            // 
            // lstOverdueBooks
            // 
            this.lstOverdueBooks.Enabled = false;
            this.lstOverdueBooks.ForeColor = System.Drawing.Color.Black;
            this.lstOverdueBooks.FormattingEnabled = true;
            this.lstOverdueBooks.ItemHeight = 20;
            this.lstOverdueBooks.Location = new System.Drawing.Point(6, 25);
            this.lstOverdueBooks.Name = "lstOverdueBooks";
            this.lstOverdueBooks.Size = new System.Drawing.Size(295, 104);
            this.lstOverdueBooks.TabIndex = 54;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnCancel.Location = new System.Drawing.Point(96, 137);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(8);
            this.btnCancel.Size = new System.Drawing.Size(112, 42);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpLoanBooks
            // 
            this.grpLoanBooks.BackColor = System.Drawing.Color.MintCream;
            this.grpLoanBooks.Controls.Add(this.grpBookDetails);
            this.grpLoanBooks.Controls.Add(this.grdBooksSummary);
            this.grpLoanBooks.Controls.Add(this.txtTitle);
            this.grpLoanBooks.Controls.Add(this.label4);
            this.grpLoanBooks.Controls.Add(this.btnSearch);
            this.grpLoanBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoanBooks.Location = new System.Drawing.Point(6, 259);
            this.grpLoanBooks.Name = "grpLoanBooks";
            this.grpLoanBooks.Size = new System.Drawing.Size(985, 249);
            this.grpLoanBooks.TabIndex = 49;
            this.grpLoanBooks.TabStop = false;
            this.grpLoanBooks.Text = "Loan Available Books";
            this.grpLoanBooks.Visible = false;
            // 
            // grpBookDetails
            // 
            this.grpBookDetails.BackColor = System.Drawing.Color.MintCream;
            this.grpBookDetails.Controls.Add(this.txtCategory);
            this.grpBookDetails.Controls.Add(this.label7);
            this.grpBookDetails.Controls.Add(this.txtISBN);
            this.grpBookDetails.Controls.Add(this.txtAuthor);
            this.grpBookDetails.Controls.Add(this.txtBookTitle);
            this.grpBookDetails.Controls.Add(this.label6);
            this.grpBookDetails.Controls.Add(this.label5);
            this.grpBookDetails.Controls.Add(this.label3);
            this.grpBookDetails.Controls.Add(this.label1);
            this.grpBookDetails.Controls.Add(this.btnAddBook);
            this.grpBookDetails.Controls.Add(this.txtID);
            this.grpBookDetails.Controls.Add(this.label2);
            this.grpBookDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookDetails.Location = new System.Drawing.Point(642, 20);
            this.grpBookDetails.Name = "grpBookDetails";
            this.grpBookDetails.Size = new System.Drawing.Size(337, 223);
            this.grpBookDetails.TabIndex = 46;
            this.grpBookDetails.TabStop = false;
            this.grpBookDetails.Text = "Book Details";
            this.grpBookDetails.Visible = false;
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCategory.Enabled = false;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(84, 186);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategory.MaxLength = 4;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(68, 23);
            this.txtCategory.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Author";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.SystemColors.Menu;
            this.txtISBN.Enabled = false;
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(84, 146);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtISBN.MaxLength = 4;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(176, 23);
            this.txtISBN.TabIndex = 55;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(84, 103);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAuthor.MaxLength = 4;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(176, 23);
            this.txtAuthor.TabIndex = 54;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBookTitle.Enabled = false;
            this.txtBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTitle.Location = new System.Drawing.Point(84, 61);
            this.txtBookTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookTitle.MaxLength = 4;
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(176, 23);
            this.txtBookTitle.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Book Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(127, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 49;
            this.label1.Visible = false;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAddBook.Location = new System.Drawing.Point(228, 176);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Padding = new System.Windows.Forms.Padding(8);
            this.btnAddBook.Size = new System.Drawing.Size(102, 42);
            this.btnAddBook.TabIndex = 46;
            this.btnAddBook.Text = "Add to Loan";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(84, 27);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.MaxLength = 4;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(68, 23);
            this.txtID.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Book ID";
            // 
            // grdBooksSummary
            // 
            this.grdBooksSummary.AllowUserToAddRows = false;
            this.grdBooksSummary.AllowUserToDeleteRows = false;
            this.grdBooksSummary.AllowUserToResizeColumns = false;
            this.grdBooksSummary.AllowUserToResizeRows = false;
            this.grdBooksSummary.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdBooksSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBooksSummary.Location = new System.Drawing.Point(22, 70);
            this.grdBooksSummary.Name = "grdBooksSummary";
            this.grdBooksSummary.RowHeadersWidth = 62;
            this.grdBooksSummary.RowTemplate.Height = 28;
            this.grdBooksSummary.Size = new System.Drawing.Size(614, 149);
            this.grdBooksSummary.TabIndex = 45;
            this.grdBooksSummary.Visible = false;
            this.grdBooksSummary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBooksSummary_CellClick);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(58, 30);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.MaxLength = 4;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(199, 26);
            this.txtTitle.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Title:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSearch.Location = new System.Drawing.Point(273, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(8);
            this.btnSearch.Size = new System.Drawing.Size(112, 42);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpIssueBooks
            // 
            this.grpIssueBooks.BackColor = System.Drawing.Color.MintCream;
            this.grpIssueBooks.Controls.Add(this.grpDetails);
            this.grpIssueBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIssueBooks.Location = new System.Drawing.Point(185, 154);
            this.grpIssueBooks.Name = "grpIssueBooks";
            this.grpIssueBooks.Size = new System.Drawing.Size(1295, 825);
            this.grpIssueBooks.TabIndex = 50;
            this.grpIssueBooks.TabStop = false;
            this.grpIssueBooks.Text = "Issue Books";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lblCart);
            this.grpDetails.Controls.Add(this.lstCart);
            this.grpDetails.Controls.Add(this.btnCheckout);
            this.grpDetails.Controls.Add(this.grpMember);
            this.grpDetails.Controls.Add(this.btnRemove);
            this.grpDetails.Controls.Add(this.grpLoanBooks);
            this.grpDetails.Controls.Add(this.grpMemberDetails);
            this.grpDetails.Controls.Add(this.grpOverdueBooks);
            this.grpDetails.Controls.Add(this.grpLoanDetails);
            this.grpDetails.Location = new System.Drawing.Point(24, 41);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(1249, 761);
            this.grpDetails.TabIndex = 31;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details:";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.Color.Maroon;
            this.lblCart.Location = new System.Drawing.Point(792, 541);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(61, 29);
            this.lblCart.TabIndex = 53;
            this.lblCart.Text = "Cart";
            this.lblCart.Visible = false;
            // 
            // lstCart
            // 
            this.lstCart.ForeColor = System.Drawing.Color.Maroon;
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 22;
            this.lstCart.Location = new System.Drawing.Point(667, 580);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(324, 136);
            this.lstCart.TabIndex = 50;
            this.lstCart.Visible = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.SystemColors.Control;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnCheckout.Location = new System.Drawing.Point(998, 653);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Padding = new System.Windows.Forms.Padding(8);
            this.btnCheckout.Size = new System.Drawing.Size(112, 42);
            this.btnCheckout.TabIndex = 52;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Visible = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnRemove.Location = new System.Drawing.Point(998, 601);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(8);
            this.btnRemove.Size = new System.Drawing.Size(112, 42);
            this.btnRemove.TabIndex = 51;
            this.btnRemove.Text = "Remove Book";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmIssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1492, 1035);
            this.Controls.Add(this.grpIssueBooks);
            this.Controls.Add(this.mnuMenu);
            this.Name = "frmIssueBook";
            this.Text = "IssueBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIssueBook_Load);
            this.grpLoanDetails.ResumeLayout(false);
            this.grpLoanDetails.PerformLayout();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.grpMemberDetails.ResumeLayout(false);
            this.grpMemberDetails.PerformLayout();
            this.grpOverdueBooks.ResumeLayout(false);
            this.grpLoanBooks.ResumeLayout(false);
            this.grpLoanBooks.PerformLayout();
            this.grpBookDetails.ResumeLayout(false);
            this.grpBookDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooksSummary)).EndInit();
            this.grpIssueBooks.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpLoanDetails;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.Label lblNoBooks;
        private System.Windows.Forms.Label lblLoanID;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.TextBox txtLoanID;
        private System.Windows.Forms.GroupBox grpMemberDetails;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox grpOverdueBooks;
        private System.Windows.Forms.GroupBox grpLoanBooks;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpBookDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdBooksSummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpIssueBooks;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.ListBox lstOverdueBooks;
    }
}