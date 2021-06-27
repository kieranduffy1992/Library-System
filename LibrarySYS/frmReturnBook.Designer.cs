namespace LibrarySYS
{
    partial class frmReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnBook));
            this.grpLoanedBook = new System.Windows.Forms.GroupBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grpBooks = new System.Windows.Forms.GroupBox();
            this.grdBooks = new System.Windows.Forms.DataGridView();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMemberDetails = new System.Windows.Forms.GroupBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.grpReturnBooks = new System.Windows.Forms.GroupBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.grpLoanedBook.SuspendLayout();
            this.grpBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            this.mnuMenu.SuspendLayout();
            this.grpMemberDetails.SuspendLayout();
            this.grpMember.SuspendLayout();
            this.grpReturnBooks.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoanedBook
            // 
            this.grpLoanedBook.BackColor = System.Drawing.Color.MintCream;
            this.grpLoanedBook.Controls.Add(this.txtDueDate);
            this.grpLoanedBook.Controls.Add(this.lblDueDate);
            this.grpLoanedBook.Controls.Add(this.txtFine);
            this.grpLoanedBook.Controls.Add(this.label1);
            this.grpLoanedBook.Controls.Add(this.txtAuthor);
            this.grpLoanedBook.Controls.Add(this.txtTitle);
            this.grpLoanedBook.Controls.Add(this.txtBookID);
            this.grpLoanedBook.Controls.Add(this.lblTitle);
            this.grpLoanedBook.Controls.Add(this.lblBookID);
            this.grpLoanedBook.Controls.Add(this.lblAuthor);
            this.grpLoanedBook.Controls.Add(this.btnReturn);
            this.grpLoanedBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoanedBook.Location = new System.Drawing.Point(193, 482);
            this.grpLoanedBook.Name = "grpLoanedBook";
            this.grpLoanedBook.Size = new System.Drawing.Size(688, 198);
            this.grpLoanedBook.TabIndex = 22;
            this.grpLoanedBook.TabStop = false;
            this.grpLoanedBook.Text = "Loaned Book Details";
            this.grpLoanedBook.Visible = false;
            // 
            // txtDueDate
            // 
            this.txtDueDate.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDueDate.Enabled = false;
            this.txtDueDate.Location = new System.Drawing.Point(470, 44);
            this.txtDueDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDueDate.MaxLength = 4;
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(177, 26);
            this.txtDueDate.TabIndex = 49;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(368, 43);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(102, 25);
            this.lblDueDate.TabIndex = 48;
            this.lblDueDate.Text = "Due Date";
            // 
            // txtFine
            // 
            this.txtFine.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFine.Enabled = false;
            this.txtFine.Location = new System.Drawing.Point(511, 91);
            this.txtFine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFine.MaxLength = 4;
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(136, 26);
            this.txtFine.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(368, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "**Fine Due**";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(122, 141);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAuthor.MaxLength = 4;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(178, 26);
            this.txtAuthor.TabIndex = 45;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(123, 91);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.MaxLength = 4;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(177, 26);
            this.txtTitle.TabIndex = 44;
            // 
            // txtBookID
            // 
            this.txtBookID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBookID.Enabled = false;
            this.txtBookID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBookID.Location = new System.Drawing.Point(123, 42);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookID.MaxLength = 4;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(77, 26);
            this.txtBookID.TabIndex = 43;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(27, 92);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(54, 25);
            this.lblTitle.TabIndex = 42;
            this.lblTitle.Text = "Title";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(27, 43);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(88, 25);
            this.lblBookID.TabIndex = 41;
            this.lblBookID.Text = "Book ID";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(27, 140);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(76, 25);
            this.lblAuthor.TabIndex = 40;
            this.lblAuthor.Text = "Author";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(511, 141);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(140, 35);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grpBooks
            // 
            this.grpBooks.BackColor = System.Drawing.Color.MintCream;
            this.grpBooks.Controls.Add(this.grdBooks);
            this.grpBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBooks.Location = new System.Drawing.Point(173, 247);
            this.grpBooks.Name = "grpBooks";
            this.grpBooks.Size = new System.Drawing.Size(717, 213);
            this.grpBooks.TabIndex = 21;
            this.grpBooks.TabStop = false;
            this.grpBooks.Text = "Select Book to Return";
            this.grpBooks.Visible = false;
            // 
            // grdBooks
            // 
            this.grdBooks.AllowUserToAddRows = false;
            this.grdBooks.AllowUserToDeleteRows = false;
            this.grdBooks.AllowUserToResizeColumns = false;
            this.grdBooks.AllowUserToResizeRows = false;
            this.grdBooks.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBooks.Location = new System.Drawing.Point(13, 27);
            this.grdBooks.Name = "grdBooks";
            this.grdBooks.RowHeadersWidth = 62;
            this.grdBooks.RowTemplate.Height = 28;
            this.grdBooks.Size = new System.Drawing.Size(690, 180);
            this.grdBooks.TabIndex = 0;
            this.grdBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBooks_CellClick);
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
            // grpMemberDetails
            // 
            this.grpMemberDetails.BackColor = System.Drawing.Color.MintCream;
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
            this.grpMemberDetails.Location = new System.Drawing.Point(359, 51);
            this.grpMemberDetails.Name = "grpMemberDetails";
            this.grpMemberDetails.Size = new System.Drawing.Size(670, 169);
            this.grpMemberDetails.TabIndex = 48;
            this.grpMemberDetails.TabStop = false;
            this.grpMemberDetails.Text = "Member Details";
            this.grpMemberDetails.Visible = false;
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
            this.txtTelNo.Location = new System.Drawing.Point(103, 83);
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
            this.txtFirstName.Location = new System.Drawing.Point(103, 31);
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
            // grpMember
            // 
            this.grpMember.BackColor = System.Drawing.Color.MintCream;
            this.grpMember.Controls.Add(this.btnEnter);
            this.grpMember.Controls.Add(this.txtMemberID);
            this.grpMember.Controls.Add(this.lblMemberID);
            this.grpMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMember.Location = new System.Drawing.Point(42, 51);
            this.grpMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMember.Name = "grpMember";
            this.grpMember.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMember.Size = new System.Drawing.Size(247, 167);
            this.grpMember.TabIndex = 49;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Enter MemberID";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnEnter.Location = new System.Drawing.Point(55, 83);
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
            this.txtMemberID.Location = new System.Drawing.Point(141, 27);
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
            this.lblMemberID.Location = new System.Drawing.Point(17, 30);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(97, 20);
            this.lblMemberID.TabIndex = 39;
            this.lblMemberID.Text = "Member ID";
            // 
            // grpReturnBooks
            // 
            this.grpReturnBooks.BackColor = System.Drawing.Color.MintCream;
            this.grpReturnBooks.Controls.Add(this.grpDetails);
            this.grpReturnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReturnBooks.Location = new System.Drawing.Point(185, 154);
            this.grpReturnBooks.Name = "grpReturnBooks";
            this.grpReturnBooks.Size = new System.Drawing.Size(1124, 792);
            this.grpReturnBooks.TabIndex = 51;
            this.grpReturnBooks.TabStop = false;
            this.grpReturnBooks.Text = "Return Books";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.grpMember);
            this.grpDetails.Controls.Add(this.grpMemberDetails);
            this.grpDetails.Controls.Add(this.grpLoanedBook);
            this.grpDetails.Controls.Add(this.grpBooks);
            this.grpDetails.Location = new System.Drawing.Point(24, 41);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(1067, 723);
            this.grpDetails.TabIndex = 31;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details:";
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1492, 1035);
            this.Controls.Add(this.grpReturnBooks);
            this.Controls.Add(this.mnuMenu);
            this.Name = "frmReturnBook";
            this.Text = "ReturnBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpLoanedBook.ResumeLayout(false);
            this.grpLoanedBook.PerformLayout();
            this.grpBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.grpMemberDetails.ResumeLayout(false);
            this.grpMemberDetails.PerformLayout();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.grpReturnBooks.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoanedBook;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox grpBooks;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.DataGridView grdBooks;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.GroupBox grpMemberDetails;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.GroupBox grpReturnBooks;
        private System.Windows.Forms.GroupBox grpDetails;
    }
}