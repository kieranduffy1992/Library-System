using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibrarySYS
{
    class Book
    {
        private int id;
        private String title;
        private String author;
        private String ISBN;
        private String category;
        private String status;
        public Book()
        {
            id = 0;
            title = "";
            author = "";
            ISBN = "";
            category = "";
            status = "";
        }
        public Book(int id, String title, String author, String ISBN, String category, String status)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.category = category;
            this.status = status;
        }
        public int getId()
        {
            return id;
        }
        public String getTitle()
        {
            return title;
        }
        public void setTitle(String title)
        {
            this.title = title;
        }
        public String getAuthor()
        {
            return author;
        }
        public void setAuthor(String author)
        {
            this.author = author;
        }
        public String getISBN()
        {
            return ISBN;
        }
        public void setISBN(String isbn)
        {
            this.ISBN = isbn;
        }
        public String getCategory()
        {
            return category;
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

            String strSQL = "SELECT MAX(ID) FROM BOOKS";

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

        public void addBook()
        {
            String strSQL = "INSERT INTO Books VALUES (" + this.id + ",'" + this.title + "','" +
                this.author + "','" + this.ISBN + "','" + this.category + "','" + this.status + "')";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet getSummaryBooks(String title)
        {

            String strSQL = "SELECT ID, TITLE, AUTHOR FROM BOOKS WHERE STATUS = 'A' AND TITLE LIKE '" + title + "%'";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "BS");

            conn.Close();

            return ds;
        }

        public void getBook(int id)
        {
            
            String strSQL = "SELECT * FROM Books WHERE Id = " + id;
            
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            
            dr.Read();
            this.id = dr.GetInt32(0);
            this.title = dr.GetString(1);
            this.author = dr.GetString(2);
            this.ISBN = dr.GetString(3);
            this.category = dr.GetString(4);
            this.status = dr.GetString(5);
            
            conn.Close();
        }

        public static void removeBook(String bid)
        {

            Int32.Parse(bid);

            String strSQL = "UPDATE BOOKS SET STATUS = 'R' WHERE ID = '" + bid + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void updateBook()
        {

            String strSQL = "UPDATE BOOKS SET TITLE = '" + this.title + "', AUTHOR = '" + this.author + "', ISBN = '" + this.ISBN + "', CATEGORY = '" + this.category +
                "', STATUS = '" + this.status + "' WHERE ID = " + this.id;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            
            conn.Close();
        }

        public void loanBook()
        {

            String strSQL = "UPDATE BOOKS SET STATUS = 'U' WHERE ID = '" + this.id + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataTable mostPopularBooks(String year)
        {

            String strSQL = "SELECT loan_items.BookID , Count(loan_items.BookID) FROM LOANS INNER JOIN LOAN_ITEMS ON LOANS.LOANID = LOAN_ITEMS.loanid WHERE EXTRACT(YEAR FROM loans.issue_date) = " + year + " GROUP BY loan_items.bookid ORDER BY COUNT(loan_items.BOOKID) DESC";

            DataTable dt = new DataTable();

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(dt);
            conn.Close();

            return dt;
        }

        public static void titleError()
        {
            MessageBox.Show("- A Title must be entered", "Title Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void authorError()
        {
            MessageBox.Show("- An Author must be entered and contain characters only", "Author Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void isbnError()
        {
            MessageBox.Show("- An ISBN must be entered and contain 13 digits", "ISBN Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void categoryError()
        {
            MessageBox.Show("- A Category must be selected", "Category Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void noMatch()
        {
            MessageBox.Show("No Books Match User input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
