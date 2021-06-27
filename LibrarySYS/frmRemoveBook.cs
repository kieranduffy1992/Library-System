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
    public partial class frmRemoveBook : Form
    {
        Book aBook = new Book();
        public frmRemoveBook()
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

            //Get summary of all books with title like user input
            grdBooks.DataSource = Book.getSummaryBooks(title).Tables["BS"];

            if(grdBooks.Rows.Count == 0)
            {
                Book.noMatch();
                txtEnterTitle.Focus();
                txtEnterTitle.Clear();
                grpBooks.Visible = false;
                grpDeleteBook.Visible = false;
                return;
            }

            Utility.formatGrid(grdBooks);

            grpBooks.Visible = true;

        }
        
        private void grdBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpDeleteBook.Visible = true;

            int Id = Convert.ToInt32(grdBooks.Rows[grdBooks.CurrentCell.RowIndex].Cells[0].Value.ToString());

            aBook.getBook(Id);

            txtID.Text = aBook.getId().ToString("0000");
            txtTitle.Text = aBook.getTitle().ToString();
            txtAuthor.Text = aBook.getAuthor().ToString();
            txtISBN.Text = aBook.getISBN().ToString();
            txtCategory.Text = aBook.getCategory().ToString();
 
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove " + txtTitle.Text + " from LibrarySYS?", "Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Book.removeBook(txtID.Text);

                MessageBox.Show(txtTitle.Text + " has been removed from LibrarySYS and is no longer available to loan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                resetUI();
            }
            
        }
        private void resetUI()
        {
            txtEnterTitle.Clear();
            grpBooks.Visible = false;
            txtTitle.Clear();
            grpDeleteBook.Visible = false;
            txtEnterTitle.Focus();
        }

        private void mnuHome_Click(object sender, EventArgs e)
        {           
            Utility.navigateHome(this);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Utility.exitApplication();
        }

    }
}
