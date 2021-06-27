namespace LibrarySYS
{
    partial class frmSearchBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchBook));
            this.grpBookDetails = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEnterTitle = new System.Windows.Forms.TextBox();
            this.lblEnterTitle = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBooks = new System.Windows.Forms.GroupBox();
            this.grdBooks = new System.Windows.Forms.DataGridView();
            this.grpSearchBook = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBookDetails.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            this.grpBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            this.grpSearchBook.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBookDetails
            // 
            this.grpBookDetails.BackColor = System.Drawing.Color.MintCream;
            this.grpBookDetails.Controls.Add(this.btnExit);
            this.grpBookDetails.Controls.Add(this.txtID);
            this.grpBookDetails.Controls.Add(this.txtTitle);
            this.grpBookDetails.Controls.Add(this.txtAuthor);
            this.grpBookDetails.Controls.Add(this.txtCategory);
            this.grpBookDetails.Controls.Add(this.txtStatus);
            this.grpBookDetails.Controls.Add(this.txtISBN);
            this.grpBookDetails.Controls.Add(this.lblTitle);
            this.grpBookDetails.Controls.Add(this.lblAuthor);
            this.grpBookDetails.Controls.Add(this.lblStatus);
            this.grpBookDetails.Controls.Add(this.lblCategory);
            this.grpBookDetails.Controls.Add(this.lblISBN);
            this.grpBookDetails.Controls.Add(this.lblID);
            this.grpBookDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookDetails.Location = new System.Drawing.Point(62, 364);
            this.grpBookDetails.Name = "grpBookDetails";
            this.grpBookDetails.Size = new System.Drawing.Size(937, 284);
            this.grpBookDetails.TabIndex = 22;
            this.grpBookDetails.TabStop = false;
            this.grpBookDetails.Text = "Book Details";
            this.grpBookDetails.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(350, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 35);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(123, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(78, 26);
            this.txtID.TabIndex = 25;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(123, 95);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(256, 26);
            this.txtTitle.TabIndex = 24;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(123, 152);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(256, 26);
            this.txtAuthor.TabIndex = 23;
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(552, 95);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(78, 26);
            this.txtCategory.TabIndex = 22;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(552, 152);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(78, 26);
            this.txtStatus.TabIndex = 21;
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.SystemColors.Menu;
            this.txtISBN.Enabled = false;
            this.txtISBN.Location = new System.Drawing.Point(552, 42);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(256, 26);
            this.txtISBN.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(43, 91);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(73, 29);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(21, 148);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(95, 29);
            this.lblAuthor.TabIndex = 18;
            this.lblAuthor.Text = "Author:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(453, 148);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(92, 29);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(420, 91);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(125, 29);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "Category:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(465, 39);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(80, 29);
            this.lblISBN.TabIndex = 14;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(71, 39);
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
            this.btnSearch.Location = new System.Drawing.Point(633, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 35);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEnterTitle
            // 
            this.txtEnterTitle.Location = new System.Drawing.Point(358, 50);
            this.txtEnterTitle.MaxLength = 50;
            this.txtEnterTitle.Name = "txtEnterTitle";
            this.txtEnterTitle.Size = new System.Drawing.Size(258, 28);
            this.txtEnterTitle.TabIndex = 19;
            // 
            // lblEnterTitle
            // 
            this.lblEnterTitle.AutoSize = true;
            this.lblEnterTitle.BackColor = System.Drawing.Color.MintCream;
            this.lblEnterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterTitle.Location = new System.Drawing.Point(254, 55);
            this.lblEnterTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterTitle.Name = "lblEnterTitle";
            this.lblEnterTitle.Size = new System.Drawing.Size(97, 20);
            this.lblEnterTitle.TabIndex = 18;
            this.lblEnterTitle.Text = "Enter Title:";
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
            // grpBooks
            // 
            this.grpBooks.BackColor = System.Drawing.Color.MintCream;
            this.grpBooks.Controls.Add(this.grdBooks);
            this.grpBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBooks.Location = new System.Drawing.Point(196, 128);
            this.grpBooks.Name = "grpBooks";
            this.grpBooks.Size = new System.Drawing.Size(647, 217);
            this.grpBooks.TabIndex = 41;
            this.grpBooks.TabStop = false;
            this.grpBooks.Text = "Select Book to Search";
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
            this.grdBooks.Location = new System.Drawing.Point(12, 40);
            this.grdBooks.Name = "grdBooks";
            this.grdBooks.RowHeadersWidth = 62;
            this.grdBooks.RowTemplate.Height = 28;
            this.grdBooks.Size = new System.Drawing.Size(614, 160);
            this.grdBooks.TabIndex = 0;
            this.grdBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBooks_CellClick);
            // 
            // grpSearchBook
            // 
            this.grpSearchBook.BackColor = System.Drawing.Color.MintCream;
            this.grpSearchBook.Controls.Add(this.groupBox1);
            this.grpSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchBook.Location = new System.Drawing.Point(339, 194);
            this.grpSearchBook.Name = "grpSearchBook";
            this.grpSearchBook.Size = new System.Drawing.Size(1111, 756);
            this.grpSearchBook.TabIndex = 42;
            this.grpSearchBook.TabStop = false;
            this.grpSearchBook.Text = "Search Book";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEnterTitle);
            this.groupBox1.Controls.Add(this.grpBooks);
            this.groupBox1.Controls.Add(this.grpBookDetails);
            this.groupBox1.Controls.Add(this.txtEnterTitle);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(30, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1053, 673);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details:";
            // 
            // frmSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1492, 1035);
            this.Controls.Add(this.grpSearchBook);
            this.Controls.Add(this.mnuMenu);
            this.Name = "frmSearchBook";
            this.Text = "SearchBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpBookDetails.ResumeLayout(false);
            this.grpBookDetails.PerformLayout();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.grpBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            this.grpSearchBook.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBookDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEnterTitle;
        private System.Windows.Forms.Label lblEnterTitle;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpBooks;
        private System.Windows.Forms.DataGridView grdBooks;
        private System.Windows.Forms.GroupBox grpSearchBook;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}