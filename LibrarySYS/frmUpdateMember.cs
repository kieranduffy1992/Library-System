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
    public partial class frmUpdateMember : Form
    {
        Member aMember = new Member();
        public frmUpdateMember()
        {
            InitializeComponent();
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Now.AddYears(-5);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(Utility.isValidSurname(txtLName.Text)==false)
            {
                Member.surnameError();
                txtLName.Focus();
                return;
            }

            String lastName = txtLName.Text.ToUpper();

            //Get a summary of all Members with last name like user input
            grdMembers.DataSource = Member.getSummaryMembers(lastName).Tables["MS"];

            if (grdMembers.Rows.Count == 0)
            {
                MessageBox.Show("No Members Match User input", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);

                txtLName.Focus();
                return;
            }

            grpMembers.Visible = true;
            
        }

        private void grdMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value.ToString());

            aMember.getMember(Id);

            txtID.Text = aMember.getId().ToString("0000");
            txtFirstName.Text = aMember.getFirstName().ToString();
            txtLastName.Text = aMember.getLastName().ToString();
            txtStreet.Text = aMember.getStreet().ToString();
            txtTown.Text = aMember.getTown().ToString();
            txtCounty.Text = aMember.getCounty().ToString();
            txtTelephone.Text = aMember.getTelNo().ToString();
            txtEmail.Text = aMember.getEmail().ToString();
            dtpDOB.Value = Convert.ToDateTime(aMember.getDateOfBirth());

            grpUpdateMember.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (Utility.isValidFirstName(txtFirstName.Text) == false)
            {
                Member.firstNameError();
                txtFirstName.Focus();
                return;
            }
            if (Utility.isValidSurname(txtLastName.Text) == false)
            {
                Member.surnameError();
                txtLastName.Focus();
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

            aMember.setFirstName(txtFirstName.Text.ToUpper());
            aMember.setLastName(txtLastName.Text.ToUpper());
            aMember.setStreet(txtStreet.Text.ToUpper());
            aMember.setTown(txtTown.Text.ToUpper());
            aMember.setCounty(txtCounty.Text.ToUpper());
            aMember.setTelNo(txtTelephone.Text.ToUpper());
            aMember.setEmail(txtEmail.Text.ToUpper());
            String dateAsString = String.Format("{0:dd-MMM-yy}", dtpDOB.Value);
            aMember.setDateOfBirth(dateAsString);

            aMember.updateMember();

            MessageBox.Show("Member: " + txtFirstName.Text + " " + txtLastName.Text + " Updated", "Success!",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            grpMembers.Visible = false;
            grpUpdateMember.Visible = false;
            txtLName.Clear();
            txtLName.Focus();
            dtpDOB.MaxDate = DateTime.Now.AddYears(-5);
        }
    }
}
