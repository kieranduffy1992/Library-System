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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuAddBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddBook addBook = new frmAddBook();
            addBook.ShowDialog();
            this.Close();

        }

        private void mnuRemoveBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveBook removeBook = new frmRemoveBook();
            removeBook.ShowDialog();
            this.Close();

        }

        private void mnuSearchBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSearchBook searchBook = new frmSearchBook();
            searchBook.ShowDialog();
            this.Close();

        }

        private void mnuAddMember_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmAddMember addMember = new frmAddMember();
            addMember.ShowDialog();
            this.Close();

        }

        private void mnuRemoveMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveMember removeMember = new frmRemoveMember();
            removeMember.ShowDialog();
            this.Close();

        }

        private void mnuUpdateMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateMember updateMember = new frmUpdateMember();
            updateMember.ShowDialog();
            this.Close();

        }

        private void mnuIssueBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIssueBook issueBook = new frmIssueBook();
            issueBook.ShowDialog();
            this.Close();

        }

        private void mnuReturnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnBook returnBook = new frmReturnBook();
            returnBook.ShowDialog();
            this.Close();

        }

        private void mnuAnalyseFines_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnalyseFines analyseFines = new frmAnalyseFines();
            analyseFines.ShowDialog();
            this.Close();

        }

        private void mnuPopularBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListPopularBooks popularBooks = new frmListPopularBooks();
            popularBooks.ShowDialog();
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
