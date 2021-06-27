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
    public partial class frmIssueBook : Form
    {
        Member aMember = new Member();
        Book book = new Book();
        int noBooks;
        int itemId;
        //ArrayList is being used to store LoanItems incase member wants more than one book. 
        List<LoanItem> allLoanItems = new List<LoanItem>();
        public frmIssueBook()
        {
            InitializeComponent();
        }
        private void frmIssueBook_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(800, 650);
            txtLoanID.Text = Loan.getNextID().ToString("0000");
            itemId = LoanItem.getNextID();
            dtpIssueDate.Value = DateTime.Now;
            //A loan is 21 days in length
            dtpDueDate.Value = DateTime.Now.AddDays(21);            
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

            int memberID = Convert.ToInt32(txtMemberID.Text);

            aMember.getMember(memberID);

            if(aMember.getStatus().Equals("R"))
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
            
            noBooks = aMember.getNoBooks();

            if (noBooks > 2)
            {
                MessageBox.Show("Member: " + memberID.ToString() + " has already reached MAX books(3)", 
                    "Error" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                grpMemberDetails.Visible = false;
                grpOverdueBooks.Visible = false;
                txtMemberID.Clear();
                txtMemberID.Focus();
                return;
            }

            Member.getOverdueBooks(lstOverdueBooks, memberID);

            //Greater than one because listbox already contains title and due date header
            if (lstOverdueBooks.Items.Count > 1)
            {
                MessageBox.Show("Member: " + memberID.ToString() + 
                    " has Overdue books, Select cancel when finished viewing", "Overdue Books", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                grpOverdueBooks.Visible = true;
                btnProceed.Visible = false;
                btnEnter.Visible = false;
            }
            else
                lblTip.Visible = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            resetUI();
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This member may loan up to " + (3 - noBooks) + " books", 
                "Number of available loans", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtMemID.Text = aMember.getId().ToString("0000");
            grpLoanDetails.Visible = true;
            grpLoanBooks.Visible = true;
            btnProceed.Visible = false;
            btnEnter.Visible = false;
            lblTip.Visible = false;
            displayCart();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Equals(""))
            {
                Book.titleError();
                txtTitle.Focus();
                grdBooksSummary.Visible = false;
                grpBookDetails.Visible = false;
                return;
            }

            String title = txtTitle.Text.ToUpper();

            grdBooksSummary.DataSource = Book.getSummaryBooks(title).Tables["BS"];

            Utility.formatGrid(grdBooksSummary);

            if (grdBooksSummary.Rows.Count==0)
            {
                Book.noMatch();
                txtTitle.Focus();
                txtTitle.Clear();
                grdBooksSummary.Visible = false;
                grpBookDetails.Visible = false;
                return;
            }

            grdBooksSummary.Visible = true;
            
        }

        private void grdBooksSummary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpBookDetails.Visible = true;
            Book aBook = new Book();

            int Id = Convert.ToInt32(grdBooksSummary.Rows[grdBooksSummary.CurrentCell.RowIndex].Cells[0].Value.ToString());

            aBook.getBook(Id);

            txtID.Text = aBook.getId().ToString("0000");
            txtBookTitle.Text = aBook.getTitle().ToString();
            txtAuthor.Text = aBook.getAuthor().ToString();
            txtISBN.Text = aBook.getISBN().ToString();
            txtCategory.Text = aBook.getCategory().ToString();

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
                       
            int bookid = Convert.ToInt32(txtID.Text);

            book.getBook(bookid);

            //the first argument is set to zero as its value is declared in the createLoanItem method in the LoanItem Class
            LoanItem loanItem = new LoanItem(0 , Convert.ToInt32(txtLoanID.Text), Convert.ToInt32(txtID.Text), "");
            allLoanItems.Add(loanItem);
            lstCart.Items.Add(book.getId().ToString("0000") + " - " + book.getTitle());
           
            //set book status to 'U'(unavailable)
            book.loanBook();
                       
            noBooks++;
            aMember.setNoBooks(noBooks);
            aMember.updateMember();

            if (aMember.getNoBooks() > 2)
            {
                MessageBox.Show("Max books reached. Checkout/Remove from cart to continue ", "Max books reached ", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAddBook.Visible = false;
            }
            else
            {
                grpBookDetails.Visible = false;
                grdBooksSummary.Visible = false;
                txtTitle.Clear();
                txtTitle.Focus();
                return;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Book first!", "Please Select ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                btnAddBook.Visible = true;

                int index = lstCart.SelectedIndex;

                //Get the bookID part of the selected item 
                string text = lstCart.Items[index].ToString().Substring(0, 4);

                int id = Int32.Parse(text);

                //remove selected item from array
                allLoanItems.RemoveAt(lstCart.SelectedIndex);

                //remove selected item from cart
                lstCart.Items.RemoveAt(lstCart.SelectedIndex);
                                
                noBooks--;
                aMember.setNoBooks(noBooks);
                aMember.updateMember();

                Book newBook = new Book();
                newBook.getBook(id);
                newBook.setStatus("A");
                newBook.updateBook();

                grpBookDetails.Visible = false;
                grdBooksSummary.Visible = false;
                txtTitle.Clear();
                txtTitle.Focus();

            }
                
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if(lstCart.Items.Count == 0)
            {
                MessageBox.Show("No Books currently in cart - Please add books to checkout", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                String issueDateAsString = String.Format("{0:dd-MMM-yy}", dtpIssueDate.Value);
                String dueDateAsString = String.Format("{0:dd-MMM-yy}", dtpDueDate.Value);

                Loan aLoan = new Loan(Convert.ToInt32(txtLoanID.Text), issueDateAsString, dueDateAsString,
                    Convert.ToInt32(txtMemID.Text));
                aLoan.createLoan();

                /*Loop to insert all loan items in the arraylist to the database. This can be done only after a loan has 
                 * been created due to loanid being a foreign key in the loan items table*/
                for (int i = 0; i < allLoanItems.Count; i++)
                {
                    allLoanItems[i].createLoanItem();
                }

                MessageBox.Show("Books have been issued\n**IMPORTANT** - Inform Member that Due date is " +
                    dueDateAsString, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                resetUI();

            }
            
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
            allLoanItems.Clear();
            lstCart.Items.Clear();
            grpLoanDetails.Visible = false;
            grpBookDetails.Visible = false;
            grdBooksSummary.Visible = false;
            grpMemberDetails.Visible = false;
            grpLoanBooks.Visible = false;
            grpOverdueBooks.Visible = false;
            lstOverdueBooks.Items.Clear();
            lstCart.Items.Clear();
            lblTip.Visible = false;
            lblCart.Visible = false;
            lstCart.Visible = false;
            btnEnter.Visible = true;
            btnProceed.Visible = true;
            btnCheckout.Visible = false;
            btnRemove.Visible = false;
            btnAddBook.Visible = true;
            txtLoanID.Text = Loan.getNextID().ToString("0000");
            itemId++;
            txtTitle.Clear();
            txtMemID.Clear();
            txtMemberID.Clear();
            txtMemberID.Focus();
        }

        private void displayCart()
        {
            lblCart.Visible = true;
            lstCart.Visible = true;
            btnCheckout.Visible = true;
            btnRemove.Visible = true;
        }

        
    }

}
