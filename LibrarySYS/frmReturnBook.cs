using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmReturnBook : Form
    {
        Member aMember = new Member();
        Book aBook = new Book();
        DateTime todaysDate = DateTime.Now;
        int memberID, bookID;
        public frmReturnBook()
        {
            InitializeComponent();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (Utility.isValidMemberID(txtMemberID.Text) == false)
            {
                Member.invalidIDMessage();
                txtMemberID.Clear();
                txtMemberID.Focus();
                return;
            }

            memberID = Convert.ToInt32(txtMemberID.Text);

            aMember.getMember(memberID);

            if (aMember.getStatus().Equals("R"))
            {
                MessageBox.Show("This member is not active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberID.Clear();
                txtMemberID.Focus();
                return;
            }

            if (aMember.getStatus().Equals(""))
            {
                MessageBox.Show("This member does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberID.Clear();
                txtMemberID.Focus();
                return;
            }

            txtFirstName.Text = aMember.getFirstName();
            txtLastName.Text = aMember.getLastName();
            txtTelNo.Text = aMember.getTelNo();
            txtEmail.Text = aMember.getEmail();
            grpMemberDetails.Visible = true;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            grdBooks.DataSource = Loan.getSummaryLoans(memberID).Tables["LS"];

            if(grdBooks.Rows.Count == 0)
            {
                MessageBox.Show("This member does not currently have any loaned books",
                    "No active loans", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetUI();
                return;
            }

            Utility.formatBookGrid(grdBooks);

            grpBooks.Visible = true;
        }

        private void grdBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpLoanedBook.Visible = true;

            bookID = Convert.ToInt32(grdBooks.Rows[grdBooks.CurrentCell.RowIndex].Cells[2].Value.ToString());

            aBook.getBook(bookID);

            txtBookID.Text = aBook.getId().ToString("0000");
            txtTitle.Text = aBook.getTitle().ToString();
            txtAuthor.Text = aBook.getAuthor().ToString();
            txtDueDate.Text = grdBooks.Rows[grdBooks.CurrentCell.RowIndex].Cells[0].Value.ToString();

            DateTime dueDate = DateTime.Parse(txtDueDate.Text);

            if(dueDate < todaysDate)
            {
                float fine = Loan.calculateFine(todaysDate, dueDate);
                txtFine.Text = fine.ToString("0.00");
            }
            else
            {
                txtFine.Text = "0.00";
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            decimal fineAmount = decimal.Parse(txtFine.Text, CultureInfo.InvariantCulture);
            if (fineAmount > 0)
            {
                int fineID = Fine.getNextID(); 

                MessageBox.Show("Please take payment of €" + txtFine.Text + " for overdue book", 
                    "Take Payment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                String todaysDateAsString = String.Format("{0:dd-MMM-yy}", todaysDate);

                Fine aFine = new Fine(fineID, fineAmount, todaysDateAsString);
                aFine.addFine();

            }

            aBook.setStatus("A");
            aBook.updateBook();
            
            aMember.setNoBooks(aMember.getNoBooks() - 1);
            aMember.updateMember();

            LoanItem.setReturnDate(bookID);

            MessageBox.Show(aBook.getTitle() + " returned to the Library ", "Book Returned", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (aMember.getNoBooks() > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Would this member like to return another book?", 
                    "Return Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {                   
                    grpLoanedBook.Visible = false;
                    grdBooks.DataSource = Loan.getSummaryLoans(memberID).Tables["LS"];
                    return;
                }

            }

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
            txtMemberID.Clear();
            txtAuthor.Clear();
            txtBookID.Clear();
            txtDueDate.Clear();
            txtMemberID.Focus();
            grpLoanedBook.Visible = false;
            grpBooks.Visible = false;
            grpMemberDetails.Visible = false;
        }
    }
}
