using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmListPopularBooks : Form
    {
        public frmListPopularBooks()
        {
            InitializeComponent();
        }

        private void ListPopularBooks_Load(object sender, EventArgs e)
        {
            //load years into combo box
            Utility.loadYears(cboYear);
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedItem != null)
            {
                DataTable dt = Book.mostPopularBooks(cboYear.Text);

                if (dt.Rows.Count > 2)
                {
                    //Top 3 most popular Books
                    Book no1Book = new Book();
                    Book no2Book = new Book();
                    Book no3Book = new Book();

                    //using the get book method and the BOOKID column in the returned datatable to access details about each book(eg title) 
                    no1Book.getBook(int.Parse(dt.Rows[0]["BOOKID"].ToString()));
                    no2Book.getBook(int.Parse(dt.Rows[1]["BOOKID"].ToString()));
                    no3Book.getBook(int.Parse(dt.Rows[2]["BOOKID"].ToString()));

                    chtBooks.Titles.Clear();
                    chtBooks.Titles.Add("Top 3 Books of " + cboYear.Text);
                    chtBooks.Series["PopularBooks"].Points.Clear();

                    /*COUNT(LOAN_ITEMS.BOOKID) is the column which counts the number of times a bookID appears in the loan_items table.  
                     *The following code accesses the column in the returned dataset and adds the result to the Pie Chart*/ 
                    chtBooks.Series["PopularBooks"].Points.AddXY(no1Book.getTitle() + " (" + dt.Rows[0]["COUNT(LOAN_ITEMS.BOOKID)"] + ")", dt.Rows[0]["COUNT(LOAN_ITEMS.BOOKID)"]);
                    chtBooks.Series["PopularBooks"].Points.AddXY(no2Book.getTitle() + " (" + dt.Rows[1]["COUNT(LOAN_ITEMS.BOOKID)"] + ")", dt.Rows[1]["COUNT(LOAN_ITEMS.BOOKID)"]);
                    chtBooks.Series["PopularBooks"].Points.AddXY(no3Book.getTitle() + " (" + dt.Rows[2]["COUNT(LOAN_ITEMS.BOOKID)"] + ")", dt.Rows[2]["COUNT(LOAN_ITEMS.BOOKID)"]);

                    chtBooks.Visible = true;

                }
                else
                {
                    MessageBox.Show("Cannot Display Top 3 most popular books as there have been less than 3 books loaned out in " + cboYear.Text, "Analysis Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chtBooks.Visible = false;
                    return;
                }

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
