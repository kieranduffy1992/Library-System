using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmAnalyseFines : Form
    {
        public frmAnalyseFines()
        {
            InitializeComponent();
        }

        private void frmAnalyseFines_Load(object sender, EventArgs e)
        {
            Utility.loadYears(cboYear);
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedItem != null)
            {
                DataTable dt = Fine.getFineDetails(cboYear.Text);

                string[] months = new string[12];
                decimal[] fineRevenue = new decimal[12];

                Fine.populateMonths(months);
                Fine.populateRevenue(fineRevenue, dt);

                //Change appearence/properties of the chart
                Utility.styleChart(chtFines);
                chtFines.Titles.Add("Fine Income for " + cboYear.Text);

                chtFines.Series[0].Points.DataBindXY(months, fineRevenue);
                chtFines.Visible = true;
               
                //Total fine income for the year
                txtTotalIncome.Text = Fine.getTotalFine(dt).ToString("€0.00");
                //Average fine income per month 
                txtAverageIncome.Text = (Fine.getTotalFine(dt) / 12).ToString("€0.00");                

            }
        }
        
        private void mnuHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit LibrarySYS?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
