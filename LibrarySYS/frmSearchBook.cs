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
    public partial class frmSearchBook : Form
    {
        Book aBook = new Book();
        public frmSearchBook()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnterTitle.Text.Equals(""))
            {
                Book.titleError();
                txtEnterTitle.Focus();
                return;
            }

            String title = txtEnterTitle.Text.ToUpper();

            grdBooks.DataSource = Book.getSummaryBooks(title).Tables["BS"];

            if (grdBooks.Rows.Count == 0)
            {
                Book.noMatch();
                txtEnterTitle.Focus();
                txtEnterTitle.Clear();
                grpBooks.Visible = false;
                grpBookDetails.Visible = false;
                return;
            }

            Utility.formatGrid(grdBooks);

            grpBooks.Visible = true;

        }

        private void grdBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpBookDetails.Visible = true;

            int Id = Convert.ToInt32(grdBooks.Rows[grdBooks.CurrentCell.RowIndex].Cells[0].Value.ToString());

            aBook.getBook(Id);

            txtID.Text = aBook.getId().ToString("0000");
            txtTitle.Text = aBook.getTitle().ToString();
            txtAuthor.Text = aBook.getAuthor().ToString();
            txtISBN.Text = aBook.getISBN().ToString();
            txtCategory.Text = aBook.getCategory().ToString();
            txtStatus.Text = aBook.getStatus().ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            resetUI();
        }

        private void mnuHome_Click(object sender, EventArgs e)
        {
            Utility.navigateHome(this);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Utility.exitApplication();
        }

        private void resetUI()
        {
            txtEnterTitle.Clear();
            grpBooks.Visible = false;
            txtTitle.Clear();
            grpBookDetails.Visible = false;
            txtEnterTitle.Focus();
        }
    }
}
