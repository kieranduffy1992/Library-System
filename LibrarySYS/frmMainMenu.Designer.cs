namespace LibrarySYS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.lblLibrarySYS = new System.Windows.Forms.Label();
            this.lblQuote1 = new System.Windows.Forms.Label();
            this.lblQuote2 = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoans = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIssueBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalyseFines = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPopularBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLibrarySYS
            // 
            this.lblLibrarySYS.AutoSize = true;
            this.lblLibrarySYS.BackColor = System.Drawing.Color.Transparent;
            this.lblLibrarySYS.Font = new System.Drawing.Font("MingLiU-ExtB", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarySYS.ForeColor = System.Drawing.Color.MintCream;
            this.lblLibrarySYS.Location = new System.Drawing.Point(763, 321);
            this.lblLibrarySYS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibrarySYS.Name = "lblLibrarySYS";
            this.lblLibrarySYS.Size = new System.Drawing.Size(437, 72);
            this.lblLibrarySYS.TabIndex = 35;
            this.lblLibrarySYS.Text = "Library SYS";
            // 
            // lblQuote1
            // 
            this.lblQuote1.AutoSize = true;
            this.lblQuote1.BackColor = System.Drawing.Color.Transparent;
            this.lblQuote1.Font = new System.Drawing.Font("MingLiU-ExtB", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote1.ForeColor = System.Drawing.Color.MintCream;
            this.lblQuote1.Location = new System.Drawing.Point(550, 470);
            this.lblQuote1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuote1.Name = "lblQuote1";
            this.lblQuote1.Size = new System.Drawing.Size(831, 32);
            this.lblQuote1.TabIndex = 36;
            this.lblQuote1.Text = "The only thing that you absolutely have to know,";
            // 
            // lblQuote2
            // 
            this.lblQuote2.AutoSize = true;
            this.lblQuote2.BackColor = System.Drawing.Color.Transparent;
            this.lblQuote2.Font = new System.Drawing.Font("MingLiU-ExtB", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote2.ForeColor = System.Drawing.Color.MintCream;
            this.lblQuote2.Location = new System.Drawing.Point(521, 522);
            this.lblQuote2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuote2.Name = "lblQuote2";
            this.lblQuote2.Size = new System.Drawing.Size(878, 32);
            this.lblQuote2.TabIndex = 37;
            this.lblQuote2.Text = " is the location of the library.  – Albert Einstein";
            // 
            // mnuMenu
            // 
            this.mnuMenu.AutoSize = false;
            this.mnuMenu.BackColor = System.Drawing.Color.MintCream;
            this.mnuMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuMenu.GripMargin = new System.Windows.Forms.Padding(10);
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBooks,
            this.mnuMembers,
            this.mnuLoans,
            this.mnuAnalysis,
            this.mnuExit});
            this.mnuMenu.Location = new System.Drawing.Point(9, 9);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Padding = new System.Windows.Forms.Padding(9, 0, 0, 3);
            this.mnuMenu.Size = new System.Drawing.Size(447, 46);
            this.mnuMenu.Stretch = false;
            this.mnuMenu.TabIndex = 38;
            this.mnuMenu.TabStop = true;
            this.mnuMenu.Text = "menuStrip";
            // 
            // mnuBooks
            // 
            this.mnuBooks.BackColor = System.Drawing.Color.White;
            this.mnuBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBook,
            this.mnuRemoveBook,
            this.mnuSearchBook});
            this.mnuBooks.Name = "mnuBooks";
            this.mnuBooks.Padding = new System.Windows.Forms.Padding(6, 0, 6, 20);
            this.mnuBooks.Size = new System.Drawing.Size(77, 43);
            this.mnuBooks.Text = "Books";
            // 
            // mnuAddBook
            // 
            this.mnuAddBook.Name = "mnuAddBook";
            this.mnuAddBook.Size = new System.Drawing.Size(270, 34);
            this.mnuAddBook.Text = "Add Book";
            this.mnuAddBook.Click += new System.EventHandler(this.mnuAddBook_Click);
            // 
            // mnuRemoveBook
            // 
            this.mnuRemoveBook.Name = "mnuRemoveBook";
            this.mnuRemoveBook.Size = new System.Drawing.Size(270, 34);
            this.mnuRemoveBook.Text = "Remove Book";
            this.mnuRemoveBook.Click += new System.EventHandler(this.mnuRemoveBook_Click);
            // 
            // mnuSearchBook
            // 
            this.mnuSearchBook.Name = "mnuSearchBook";
            this.mnuSearchBook.Size = new System.Drawing.Size(270, 34);
            this.mnuSearchBook.Text = "Search Book";
            this.mnuSearchBook.Click += new System.EventHandler(this.mnuSearchBook_Click);
            // 
            // mnuMembers
            // 
            this.mnuMembers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMember,
            this.mnuRemoveMember,
            this.mnuUpdateMember});
            this.mnuMembers.Name = "mnuMembers";
            this.mnuMembers.Padding = new System.Windows.Forms.Padding(6, 0, 6, 20);
            this.mnuMembers.Size = new System.Drawing.Size(103, 43);
            this.mnuMembers.Text = "Members";
            // 
            // mnuAddMember
            // 
            this.mnuAddMember.Name = "mnuAddMember";
            this.mnuAddMember.Size = new System.Drawing.Size(250, 34);
            this.mnuAddMember.Text = "Add Member";
            this.mnuAddMember.Click += new System.EventHandler(this.mnuAddMember_Click);
            // 
            // mnuRemoveMember
            // 
            this.mnuRemoveMember.Name = "mnuRemoveMember";
            this.mnuRemoveMember.Size = new System.Drawing.Size(250, 34);
            this.mnuRemoveMember.Text = "Remove Member";
            this.mnuRemoveMember.Click += new System.EventHandler(this.mnuRemoveMember_Click);
            // 
            // mnuUpdateMember
            // 
            this.mnuUpdateMember.Name = "mnuUpdateMember";
            this.mnuUpdateMember.Size = new System.Drawing.Size(250, 34);
            this.mnuUpdateMember.Text = "Update Member";
            this.mnuUpdateMember.Click += new System.EventHandler(this.mnuUpdateMember_Click);
            // 
            // mnuLoans
            // 
            this.mnuLoans.BackColor = System.Drawing.Color.White;
            this.mnuLoans.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIssueBook,
            this.mnuReturnBook});
            this.mnuLoans.Name = "mnuLoans";
            this.mnuLoans.Padding = new System.Windows.Forms.Padding(6, 0, 6, 20);
            this.mnuLoans.Size = new System.Drawing.Size(74, 43);
            this.mnuLoans.Text = "Loans";
            // 
            // mnuIssueBook
            // 
            this.mnuIssueBook.Name = "mnuIssueBook";
            this.mnuIssueBook.Size = new System.Drawing.Size(270, 34);
            this.mnuIssueBook.Text = "Issue Book";
            this.mnuIssueBook.Click += new System.EventHandler(this.mnuIssueBook_Click);
            // 
            // mnuReturnBook
            // 
            this.mnuReturnBook.Name = "mnuReturnBook";
            this.mnuReturnBook.Size = new System.Drawing.Size(270, 34);
            this.mnuReturnBook.Text = "Return Book";
            this.mnuReturnBook.Click += new System.EventHandler(this.mnuReturnBook_Click);
            // 
            // mnuAnalysis
            // 
            this.mnuAnalysis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAnalyseFines,
            this.mnuPopularBooks});
            this.mnuAnalysis.Name = "mnuAnalysis";
            this.mnuAnalysis.Padding = new System.Windows.Forms.Padding(6, 0, 6, 20);
            this.mnuAnalysis.Size = new System.Drawing.Size(92, 43);
            this.mnuAnalysis.Text = "Analysis";
            // 
            // mnuAnalyseFines
            // 
            this.mnuAnalyseFines.Name = "mnuAnalyseFines";
            this.mnuAnalyseFines.Size = new System.Drawing.Size(228, 34);
            this.mnuAnalyseFines.Text = "Analyse Fines";
            this.mnuAnalyseFines.Click += new System.EventHandler(this.mnuAnalyseFines_Click);
            // 
            // mnuPopularBooks
            // 
            this.mnuPopularBooks.Name = "mnuPopularBooks";
            this.mnuPopularBooks.Size = new System.Drawing.Size(228, 34);
            this.mnuPopularBooks.Text = "Popular Books";
            this.mnuPopularBooks.Click += new System.EventHandler(this.mnuPopularBooks_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.BackColor = System.Drawing.Color.White;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(55, 43);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1492, 1035);
            this.Controls.Add(this.mnuMenu);
            this.Controls.Add(this.lblQuote2);
            this.Controls.Add(this.lblQuote1);
            this.Controls.Add(this.lblLibrarySYS);
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLibrarySYS;
        private System.Windows.Forms.Label lblQuote1;
        private System.Windows.Forms.Label lblQuote2;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuBooks;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBook;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveBook;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchBook;
        private System.Windows.Forms.ToolStripMenuItem mnuMembers;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMember;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveMember;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMember;
        private System.Windows.Forms.ToolStripMenuItem mnuLoans;
        private System.Windows.Forms.ToolStripMenuItem mnuIssueBook;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnBook;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalyseFines;
        private System.Windows.Forms.ToolStripMenuItem mnuPopularBooks;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}