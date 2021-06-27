namespace LibrarySYS
{
    partial class frmAnalyseFines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyseFines));
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.grpFines = new System.Windows.Forms.GroupBox();
            this.grpChart = new System.Windows.Forms.GroupBox();
            this.chtFines = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpExtraDetails = new System.Windows.Forms.GroupBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtTotalIncome = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtAverageIncome = new System.Windows.Forms.TextBox();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpFines.SuspendLayout();
            this.grpChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtFines)).BeginInit();
            this.grpExtraDetails.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboYear
            // 
            this.cboYear.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(212, 19);
            this.cboYear.Margin = new System.Windows.Forms.Padding(8);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(116, 33);
            this.cboYear.TabIndex = 26;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(147, 24);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(53, 22);
            this.lblYear.TabIndex = 28;
            this.lblYear.Text = "Year:";
            // 
            // grpFines
            // 
            this.grpFines.BackColor = System.Drawing.Color.MintCream;
            this.grpFines.Controls.Add(this.grpChart);
            this.grpFines.Controls.Add(this.lblYear);
            this.grpFines.Controls.Add(this.cboYear);
            this.grpFines.Controls.Add(this.grpExtraDetails);
            this.grpFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFines.Location = new System.Drawing.Point(339, 194);
            this.grpFines.Name = "grpFines";
            this.grpFines.Size = new System.Drawing.Size(1111, 756);
            this.grpFines.TabIndex = 30;
            this.grpFines.TabStop = false;
            this.grpFines.Text = "Fine Details";
            // 
            // grpChart
            // 
            this.grpChart.BackColor = System.Drawing.Color.MintCream;
            this.grpChart.Controls.Add(this.chtFines);
            this.grpChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChart.Location = new System.Drawing.Point(24, 63);
            this.grpChart.Name = "grpChart";
            this.grpChart.Size = new System.Drawing.Size(1038, 509);
            this.grpChart.TabIndex = 34;
            this.grpChart.TabStop = false;
            this.grpChart.Text = "Chart";
            // 
            // chtFines
            // 
            chartArea1.Name = "ChartArea1";
            this.chtFines.ChartAreas.Add(chartArea1);
            this.chtFines.Enabled = false;
            legend1.Name = "Legend1";
            this.chtFines.Legends.Add(legend1);
            this.chtFines.Location = new System.Drawing.Point(34, 27);
            this.chtFines.Name = "chtFines";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtFines.Series.Add(series1);
            this.chtFines.Size = new System.Drawing.Size(976, 459);
            this.chtFines.TabIndex = 0;
            this.chtFines.Text = "chart1";
            this.chtFines.Visible = false;
            // 
            // grpExtraDetails
            // 
            this.grpExtraDetails.Controls.Add(this.lblAverage);
            this.grpExtraDetails.Controls.Add(this.txtTotalIncome);
            this.grpExtraDetails.Controls.Add(this.lblTotal);
            this.grpExtraDetails.Controls.Add(this.txtAverageIncome);
            this.grpExtraDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExtraDetails.Location = new System.Drawing.Point(76, 598);
            this.grpExtraDetails.Name = "grpExtraDetails";
            this.grpExtraDetails.Size = new System.Drawing.Size(937, 127);
            this.grpExtraDetails.TabIndex = 33;
            this.grpExtraDetails.TabStop = false;
            this.grpExtraDetails.Text = "More Details";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(25, 31);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(269, 22);
            this.lblAverage.TabIndex = 32;
            this.lblAverage.Text = "Average Fine income per month:";
            // 
            // txtTotalIncome
            // 
            this.txtTotalIncome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTotalIncome.Enabled = false;
            this.txtTotalIncome.Location = new System.Drawing.Point(308, 70);
            this.txtTotalIncome.Name = "txtTotalIncome";
            this.txtTotalIncome.Size = new System.Drawing.Size(176, 28);
            this.txtTotalIncome.TabIndex = 29;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(40, 73);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(254, 22);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "Total Fine income for the year:";
            // 
            // txtAverageIncome
            // 
            this.txtAverageIncome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAverageIncome.Enabled = false;
            this.txtAverageIncome.Location = new System.Drawing.Point(308, 27);
            this.txtAverageIncome.Name = "txtAverageIncome";
            this.txtAverageIncome.Size = new System.Drawing.Size(176, 28);
            this.txtAverageIncome.TabIndex = 30;
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
            // frmAnalyseFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1492, 1035);
            this.Controls.Add(this.mnuMenu);
            this.Controls.Add(this.grpFines);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAnalyseFines";
            this.Text = "AnalyseFines";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnalyseFines_Load);
            this.grpFines.ResumeLayout(false);
            this.grpFines.PerformLayout();
            this.grpChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtFines)).EndInit();
            this.grpExtraDetails.ResumeLayout(false);
            this.grpExtraDetails.PerformLayout();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.GroupBox grpFines;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtFines;
        private System.Windows.Forms.GroupBox grpChart;
        private System.Windows.Forms.GroupBox grpExtraDetails;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtTotalIncome;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtAverageIncome;
    }
}