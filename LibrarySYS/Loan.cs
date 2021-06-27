using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;

namespace LibrarySYS
{
    class Loan
    {
        private int loanId;
        private String issueDate;
        private String dueDate;
        private int memberId;

        public Loan(int loanId, string issueDate, string dueDate, int memberId)
        {
            this.loanId = loanId;
            this.issueDate = issueDate;
            this.dueDate = dueDate;
            this.memberId = memberId;
        }

        public int getloanId()
        {
            return loanId;
        }

        public String getIssueDate()
        {
            return issueDate;
        }

        public void setIssueDate(String issueDate)
        {
            this.issueDate = issueDate;
        }

        public String getDueDate()
        {
            return dueDate;
        }

        public void setDueDate(String dueDate)
        {
            this.dueDate = dueDate;
        }

        public int getMemberId()
        {
            return memberId;
        }

        public void setMemberId(int memberId)
        {
            this.memberId = memberId;
        }

        public static int getNextID()
        {
            int nextId = 0;

            String strSQL = "SELECT MAX(LoanID) FROM LOANS";

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

        public void createLoan()
        {
            String strSQL = "INSERT INTO LOANS VALUES (" + this.loanId + ",'" + this.issueDate + "','" +
                this.dueDate + "'," + this.memberId + ")";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet getSummaryLoans(int id)
        {

            String strSQL = "SELECT LOANS.due_date, LOAN_ITEMS.ITEMID, books.id, books.title FROM LOANS INNER JOIN " + 
                "LOAN_ITEMS ON loan_items.loanid = loans.loanid INNER JOIN books ON loan_items.bookid = books.id " +
                "WHERE LOAN_ITEMS.RETURN_DATE IS NULL AND loans.memberid = " + id;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "LS");

            conn.Close();

            return ds;
        }

        public static float calculateFine(DateTime today, DateTime due)
        {
            float rate = 0.5f; //fine rate of 50c per day

            int days  = (today.Date - due.Date).Days;

            if (days < 0)
                return 0;

            return days * rate;
        }
    }
}
