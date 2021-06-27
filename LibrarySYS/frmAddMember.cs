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
    public partial class frmAddMember : Form
    {
        public frmAddMember()
        {
            InitializeComponent();
        }

        private void frmAddMember_Load(object sender, EventArgs e)
        {
            txtID.Text = Member.getNextID().ToString("0000");
            dtpDOB.MaxDate = DateTime.Now.AddYears(-5);
            dtpDOB.Value = DateTime.Now.AddYears(-15);           
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {

            if (Utility.isValidFirstName(txtFName.Text) == false)
            {
                Member.firstNameError();
                txtFName.Focus();
                return;
            }
            if (Utility.isValidSurname(txtLName.Text) == false)
            {
                Member.surnameError();
                txtLName.Focus();
                return;
            }
            if (Utility.isValidTelephone(txtTelephone.Text) == false)
            {
                Member.telephoneError();
                txtTelephone.Focus();
                return;
            }
            if (Utility.isVaildEmail(txtEmail.Text) == false)
            {
                Member.emailError();
                txtEmail.Focus();
                return;
            }
            if (txtStreet.Text.Equals(""))
            {
                Member.streetError();
                txtStreet.Focus();
                return;
            }
            if (Utility.isValidWord(txtTown.Text) == false)
            {
                Member.townError();
                txtTown.Focus();
                return;
            }
            if (Utility.isValidWord(txtCounty.Text) == false)
            {
                Member.countyError();
                txtCounty.Focus();
                return;
            }

            String dateAsString = String.Format("{0:dd-MMM-yy}", dtpDOB.Value);

            Member aMember = new Member(Convert.ToInt32(txtID.Text), txtFName.Text.ToUpper(), 
                txtLName.Text.ToUpper(), txtStreet.Text.ToUpper(), txtTown.Text.ToUpper(), 
                txtCounty.Text.ToUpper(), txtTelephone.Text, txtEmail.Text.ToUpper(), dateAsString, 0, "A");

            aMember.addMember();

            MessageBox.Show("Member: " + txtFName.Text.ToUpper() + " " + txtLName.Text.ToUpper() + 
                " Added to Members", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            txtFName.Clear();
            txtLName.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            txtCounty.Clear();
            txtTelephone.Clear();
            txtEmail.Clear();
            txtFName.Focus();
            dtpDOB.MaxDate = DateTime.Now.AddYears(-5);
            dtpDOB.Value = DateTime.Now.AddYears(-15);
            txtID.Text = Member.getNextID().ToString("0000");

        }

    }
}
