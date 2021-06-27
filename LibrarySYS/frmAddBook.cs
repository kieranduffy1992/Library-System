using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace LibrarySYS
{
    public partial class frmAddBook : Form
    {
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {

            txtID.Text = Book.getNextID().ToString("0000");

            //load categories from database to combobox
            Utility.loadCategories(cboCategories);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {            

            if (txtTitle.Text.Equals(""))
            {
                Book.titleError();
                txtTitle.Focus();
                return;
            }
            if (Utility.isValidSurname(txtAuthor.Text) == false) //using surname validation because it can contain spaces
            {
                Book.authorError();
                txtAuthor.Focus();
                return;
            }
            if (Utility.isValidISBN(txtISBN.Text) == false)
            {
                Book.isbnError();
                txtISBN.Focus();
                return;
            }
            if (cboCategories.Text.Equals(""))
            {
                Book.categoryError();
                cboCategories.Focus();
                return;
            }


            Book aBook = new Book(Convert.ToInt32(txtID.Text), txtTitle.Text.ToUpper(), txtAuthor.Text.ToUpper(), txtISBN.Text,
                cboCategories.Text.Substring(0, 2), "A");
            
            aBook.addBook();

            MessageBox.Show(txtTitle.Text.ToUpper() + " Added to the Library Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetUI();
            
        }

        private void resetUI()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtISBN.Clear();
            cboCategories.SelectedIndex = -1;
            txtID.Text = Book.getNextID().ToString("0000");
            txtTitle.Focus();

        }

        private void mnuHome_Click(object sender, EventArgs e)
        {
            //method which navigates to main menu
            Utility.navigateHome(this);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            //method which closes and exits application
            Utility.exitApplication();
        }

    }
}
