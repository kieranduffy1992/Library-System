namespace LibrarySYS
{
    partial class frmRemoveBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveBook));
            this.lblEnterTitle = new System.Windows.Forms.Label();
            this.txtEnterTitle = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpBooks = new System.Windows.Forms.GroupBox();
            this.grdBooks = new System.Windows.Forms.DataGridView();
            this.grpDeleteBook = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRemoveBook = new System.Windows.Forms.GroupBox();
            this.grpBookDetails = new System.Windows.Forms.GroupBox();
            this.grpBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            this.grpDeleteBook.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            this.grpRemoveBook.SuspendLayout();
            this.grpBookDetails.SuspendLayout();
            this.SuspendLayout();
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
            this.lblEnterTitle.TabIndex = 12;
            this.lblEnterTitle.Text = "Enter Title:";
            // 
            // txtEnterTitle
            // 
            this.txtEnterTitle.Location = new System.Drawing.Point(358, 50);
            this.txtEnterTitle.MaxLength = 50;
            this.txtEnterTitle.Name = "txtEnterTitle";
            this.txtEnterTitle.Size = new System.Drawing.Size(258, 28);
            this.txtEnterTitle.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(638, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 35);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpBooks
            // 
            this.grpBooks.BackColor = System.Drawing.Color.MintCream;
            this.grpBooks.Controls.Add(this.grdBooks);
            this.grpBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBooks.Location = new System.Drawing.Point(196, 128);
            this.grpBooks.Name = "grpBooks";
            this.grpBooks.Size = new System.Drawing.Size(647, 217);
            this.grpBooks.TabIndex = 15;
            this.grpBooks.TabStop = false;
            this.grpBooks.Text = "Select Book to Remove";
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
            // grpDeleteBook
            // 
            this.grpDeleteBook.BackColor = System.Drawing.Color.MintCream;
            this.grpDeleteBook.Controls.Add(this.btnDelete);
            this.grpDeleteBook.Controls.Add(this.txtID);
            this.grpDeleteBook.Controls.Add(this.txtTitle);
            this.grpDeleteBook.Controls.Add(this.txtAuthor);
            this.grpDeleteBook.Controls.Add(this.txtCategory);
            this.grpDeleteBook.Controls.Add(this.txtISBN);
            this.grpDeleteBook.Controls.Add(this.lblTitle);
            this.grpDeleteBook.Controls.Add(this.lblAuthor);
            this.grpDeleteBook.Controls.Add(this.lblCategory);
            this.grpDeleteBook.Controls.Add(this.lblISBN);
            this.grpDeleteBook.Controls.Add(this.lblID);
            this.grpDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDeleteBook.Location = new System.Drawing.Point(62, 364);
            this.grpDeleteBook.Name = "grpDeleteBook";
            this.grpDeleteBook.Size = new System.Drawing.Size(937, 292);
            this.grpDeleteBook.TabIndex = 16;
            this.grpDeleteBook.TabStop = false;
            this.grpDeleteBook.Text = "Remove Book";
            this.grpDeleteBook.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(396, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 35);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(114, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(78, 26);
            this.txtID.TabIndex = 25;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(114, 94);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(256, 26);
            this.txtTitle.TabIndex = 24;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(114, 152);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(256, 26);
            this.txtAuthor.TabIndex = 23;
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(535, 95);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(73, 26);
            this.txtCategory.TabIndex = 22;
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.SystemColors.Menu;
            this.txtISBN.Enabled = false;
            this.txtISBN.Location = new System.Drawing.Point(535, 42);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(278, 26);
            this.txtISBN.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(41, 91);
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
            this.lblAuthor.Location = new System.Drawing.Point(19, 149);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(95, 29);
            this.lblAuthor.TabIndex = 18;
            this.lblAuthor.Text = "Author:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(410, 91);
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
            this.lblISBN.Location = new System.Drawing.Point(455, 42);
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
            this.lblID.Location = new System.Drawing.Point(69, 38);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(45, 29);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID:";
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
            // grpRemoveBook
            // 
            this.grpRemoveBook.BackColor = System.Drawing.Color.MintCream;
            this.grpRemoveBook.Controls.Add(this.grpBookDetails);
            this.grpRemoveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRemoveBook.Location = new System.Drawing.Point(339, 194);
            this.grpRemoveBook.Name = "grpRemoveBook";
            this.grpRemoveBook.Size = new System.Drawing.Size(1111, 756);
            this.grpRemoveBook.TabIndex = 41;
            this.grpRemoveBook.TabStop = false;
            this.grpRemoveBook.Text = "Remove Book";
            // 
            // grpBookDetails
            // 
            this.grpBookDetails.Controls.Add(this.lblEnterTitle);
            this.grpBookDetails.Controls.Add(this.txtEnterTitle);
            this.grpBookDetails.Controls.Add(this.grpDeleteBook);
            this.grpBookDetails.Controls.Add(this.btnSearch);
            this.grpBookDetails.Controls.Add(this.grpBooks);
            this.grpBookDetails.Location = new System.Drawing.Point(30, 58);
            this.grpBookDetails.Name = "grpBookDetails";
            this.grpBookDetails.Size = new System.Drawing.Size(1053, 673);
            this.grpBookDetails.TabIndex = 13;
            this.grpBookDetails.TabStop = false;
            this.grpBookDetails.Text = "Book Details:";
            // 
            // frmRemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1492, 1035);
            this.Controls.Add(this.grpRemoveBook);
            this.Controls.Add(this.mnuMenu);
            this.Name = "frmRemoveBook";
            this.Text = "RemoveBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            this.grpDeleteBook.ResumeLayout(false);
            this.grpDeleteBook.PerformLayout();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.grpRemoveBook.ResumeLayout(false);
            this.grpBookDetails.ResumeLayout(false);
            this.grpBookDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEnterTitle;
        private System.Windows.Forms.TextBox txtEnterTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpBooks;
        private System.Windows.Forms.GroupBox grpDeleteBook;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.DataGridView grdBooks;
        private System.Windows.Forms.GroupBox grpRemoveBook;
        private System.Windows.Forms.GroupBox grpBookDetails;
    }
}