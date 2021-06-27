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
    class LoanItem
    {
        private int itemId;
        private int loanId;
        private int bookId;
        private String returnDate;

        public LoanItem(int itemId, int loanId, int bookId, string returnDate)
        {
            this.itemId = itemId;
            this.loanId = loanId;
            this.bookId = bookId;
            this.returnDate = returnDate;
        }

        public int getItemId()
        {
            return itemId;
        }
        public int getLoanId()
        {
            return loanId;
        }
        public int getBookId()
        {
            return bookId;
        }
        public String getReturnDate()
        {
            return returnDate;
        }
        public void setReturnDate(String returnDate)
        {
            this.returnDate = returnDate;
        }

        public static int getNextID()
        {
            int nextId = 0;

            String strSQL = "SELECT MAX(ITEMID) FROM LOAN_ITEMS";

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

        public void createLoanItem()
        {
            String strSQL = "INSERT INTO LOAN_ITEMS VALUES (" + LoanItem.getNextID() + "," + this.loanId + "," + this.bookId + ",'" +
                this.returnDate + "')";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void setReturnDate(int id)
        {
            DateTime todaysDate = DateTime.Now;
            String dateAsString = todaysDate.ToString("dd/MMM/yy");

            String strSQL = "UPDATE LOAN_ITEMS SET RETURN_DATE = '" + dateAsString + "' WHERE RETURN_DATE IS NULL AND BOOKID = " + id ;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
