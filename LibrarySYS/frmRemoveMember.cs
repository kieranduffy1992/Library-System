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
    public partial class frmRemoveMember : Form
    {
        Member aMember = new Member();
        public frmRemoveMember()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Utility.isValidSurname(txtLName.Text)==false)  
            {
                Member.surnameError();
                txtLName.Focus();
                return;
            }

            String lastName = txtLName.Text.ToUpper();

            grdMembers.DataSource = Member.getSummaryMembers(lastName).Tables["MS"];

            if (grdMembers.Rows.Count == 0)
            {
                MessageBox.Show("No Members Match User input", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                txtDOB.Text = aMember.getDateOfBirth().ToString();

                grpDeleteMember.Visible = true;            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove Member: " + 
                txtFirstName.Text.ToUpper() + " " + txtLastName.Text.ToUpper() + " from LibrarySYS?", 
                "Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Member.removeMember(txtID.Text);

                MessageBox.Show(txtFirstName.Text.ToUpper() + " " + txtLastName.Text.ToUpper() + 
                    " has been removed from LibrarySYS and is no longer an active member", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            txtLName.Clear();
            grpMembers.Visible = false;
            grpDeleteMember.Visible = false;
            txtLName.Focus();
        }

    }
}
