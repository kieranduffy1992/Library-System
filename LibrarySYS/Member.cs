using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibrarySYS
{
    class Member
    {
        private int id;
        private String firstName;
        private String lastName;
        private String street;
        private String town;
        private String county;
        private String telNo;
        private String email;
        private String dateOfBirth;
        private int noBooks;
        private String status;

        public Member()
        {
            id = 0;
            firstName = "";
            lastName = "";
            street = "";
            town = "";
            county = "";
            telNo = "";
            email = "";
            dateOfBirth = "";
            noBooks = 0;
            status = "";
        }

        public Member(int id, string firstName, string lastName, string street, string town, string county, string telNo, string email, string dateOfBirth, int noBooks, string status)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.street = street;
            this.town = town;
            this.county = county;
            this.telNo = telNo;
            this.email = email;
            this.dateOfBirth = dateOfBirth;
            this.noBooks = noBooks;
            this.status = status;
        }

        public int getId()
        {
            return id;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public String getStreet()
        {
            return street;
        }

        public void setStreet(String street)
        {
            this.street = street;
        }

        public String getTown()
        {
            return town;
        }

        public void setTown(String town)
        {
            this.town = town;
        }

        public String getCounty()
        {
            return county;
        }

        public void setCounty(String county)
        {
            this.county = county;
        }

        public String getTelNo()
        {
            return telNo;
        }

        public void setTelNo(String telNo)
        {
            this.telNo = telNo;
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public String getDateOfBirth()
        {
            return dateOfBirth;
        }

        public void setDateOfBirth(String dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

        public int getNoBooks()
        {
            return noBooks;
        }

        public void setNoBooks(int noBooks)
        {
            this.noBooks = noBooks;
        }

        public String getStatus()
        {
            return status;
        }

        public void setStatus(String status)
        {
            this.status = status;
        }
        public static int getNextID()
        {
            int nextId = 0;

            String strSQL = "SELECT MAX(ID) FROM Members";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
                nextId = dr.GetInt32(0) + 1;

            conn.Close();

            return nextId;

        }

        public void addMember()
        {
            String strSQL = "INSERT INTO Members VALUES (" + this.id + ",'" + this.firstName + "','" +
                this.lastName + "','" + this.street + "','" + this.town + "','" + this.county + "','" +
                this.telNo + "','" + this.email + "','" + this.dateOfBirth + "'," + this.noBooks + ",'" + this.status + "')";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet getSummaryMembers(String lastName)
        {

            String strSQL = "SELECT ID, FIRST_NAME, LAST_NAME, DOB FROM MEMBERS WHERE STATUS = 'A' AND LAST_NAME LIKE '%" + lastName + "%'";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "MS");

            conn.Close();

            return ds;
        }

        public static void removeMember(String mid)
        {

            Int32.Parse(mid);

            String strSQL = "UPDATE MEMBERS SET STATUS = 'R' WHERE ID = '" + mid + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void getMember(int id)
        {
            
            String strSQL = "SELECT * FROM Members WHERE Id = " + id;
            
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            
            dr.Read();

            if (dr.HasRows)
            {
                this.id = dr.GetInt32(0);
                this.firstName = dr.GetString(1);
                this.lastName = dr.GetString(2);
                this.street = dr.GetString(3);
                this.town = dr.GetString(4);
                this.county = dr.GetString(5);
                this.telNo = dr.GetString(6);
                this.email = dr.GetString(7);
                this.dateOfBirth = dr.GetString(8);
                this.noBooks = dr.GetInt32(9);
                this.status = dr.GetString(10);

            }
            
            conn.Close();

        }

        public void updateMember()
        {
            String strSQL = "UPDATE Members SET FIRST_NAME = '" + this.firstName + "', LAST_NAME = '" + this.lastName + "', Street = '" + this.street +
                "', TOWN = '" + this.town + "', COUNTY = '" + this.county + "', TEL_NO = '" + this.telNo + "', EMAIL = '" + this.email + "', DOB = '" + this.dateOfBirth +
                "', NOBOOKS = " + this.noBooks + " WHERE ID = " + this.id;
           
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void getOverdueBooks(ListBox lst, int id)
        {
         
            String strSQL = "SELECT LOANS.due_date, books.title FROM LOANS INNER JOIN LOAN_ITEMS ON loan_items.loanid = loans.loanid" +
                " INNER JOIN books ON loan_items.bookid = books.id WHERE LOANS.DUE_DATE < SYSDATE AND loan_items.return_date IS NULL AND loans.memberid = " + id;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            lst.Items.Add("Due Date" + "      " + "Title");

            while (dr.Read())
            {
                lst.Items.Add(dr["DUE_DATE"].ToString().Substring(0, 10) + "   " + dr["TITLE"].ToString());
            }
 
            conn.Close();

        }

        public static void firstNameError()
        {
            MessageBox.Show("- A First Name must be entered and contain relevent characters only", "First Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void surnameError()
        {
            MessageBox.Show("- A Surname must be entered and contain relevent characters only", "Surname Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void telephoneError()
        {
            MessageBox.Show("- Telephone Numbers must begin with '0' and ony contain numbers and/or one '-'", "Telephone Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void emailError()
        {
            MessageBox.Show("- Email must be correct format (contain one '@' and one or more '.')", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void streetError()
        {
            MessageBox.Show("- Street field must not be empty", "Street Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void townError()
        {
            MessageBox.Show("- Town must contain only characters(A-Z)", "Town Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void countyError()
        {
            MessageBox.Show("- County must contain only characters(A-Z)", "County Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void invalidIDMessage()
        {
            MessageBox.Show("Invalid data!! Data must be entered as follows:\n\n" +
                    "-Member ID must be entered\n" +
                    "-Member ID must contain only numeric characters \n",
                    "Invalid Member ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
