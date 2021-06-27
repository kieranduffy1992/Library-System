namespace LibrarySYS
{
    partial class frmListPopularBooks
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListPopularBooks));
            this.grpPopularBooks = new System.Windows.Forms.GroupBox();
            this.grpChart = new System.Windows.Forms.GroupBox();
            this.chtBooks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPopularBooks.SuspendLayout();
            this.grpChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtBooks)).BeginInit();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPopularBooks
            // 
            this.grpPopularBooks.BackColor = System.Drawing.Color.MintCream;
            this.grpPopularBooks.Controls.Add(this.grpChart);
            this.grpPopularBooks.Controls.Add(this.lblYear);
            this.grpPopularBooks.Controls.Add(this.cboYear);
            this.grpPopularBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPopularBooks.Location = new System.Drawing.Point(339, 194);
            this.grpPopularBooks.Name = "grpPopularBooks";
            this.grpPopularBooks.Size = new System.Drawing.Size(1111, 756);
            this.grpPopularBooks.TabIndex = 31;
            this.grpPopularBooks.TabStop = false;
            this.grpPopularBooks.Text = "Popular Books";
            // 
            // grpChart
            // 
            this.grpChart.Controls.Add(this.chtBooks);
            this.grpChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChart.Location = new System.Drawing.Point(24, 63);
            this.grpChart.Name = "grpChart";
            this.grpChart.Size = new System.Drawing.Size(1038, 658);
            this.grpChart.TabIndex = 31;
            this.grpChart.TabStop = false;
            this.grpChart.Text = "Chart";
            // 
            // chtBooks
            // 
            this.chtBooks.BackColor = System.Drawing.Color.MintCream;
            this.chtBooks.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            this.chtBooks.BorderlineWidth = 4;
            chartArea1.Name = "ChartArea1";
            this.chtBooks.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtBooks.Legends.Add(legend1);
            this.chtBooks.Location = new System.Drawing.Point(33, 56);
            this.chtBooks.Name = "chtBooks";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "PopularBooks";
            this.chtBooks.Series.Add(series1);
            this.chtBooks.Size = new System.Drawing.Size(1018, 571);
            this.chtBooks.TabIndex = 1;
            this.chtBooks.Text = "chart1";
            this.chtBooks.Visible = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.MintCream;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(138, 24);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(53, 22);
            this.lblYear.TabIndex = 30;
            this.lblYear.Text = "Year:";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(203, 19);
            this.cboYear.Margin = new System.Windows.Forms.Padding(8);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(116, 33);
            this.cboYear.TabIndex = 29;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
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
            this.mnuMenu.Location = new System.Drawing.Point(20, 0);
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
            // frmListPopularBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1492, 1035);
            this.Controls.Add(this.mnuMenu);
            this.Controls.Add(this.grpPopularBooks);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListPopularBooks";
            this.Text = "ListPopularBooks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListPopularBooks_Load);
            this.grpPopularBooks.ResumeLayout(false);
            this.grpPopularBooks.PerformLayout();
            this.grpChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtBooks)).EndInit();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpPopularBooks;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtBooks;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.GroupBox grpChart;
    }
}