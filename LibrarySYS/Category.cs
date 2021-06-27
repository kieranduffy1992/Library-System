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
    class Category
    {
        private String code;
        private String category;

        public Category(string code, string category)
        {
            this.code = code;
            this.category = category;
        }

        public static DataSet getCategories()
        {

            String strSQL = "SELECT * FROM CATEGORIES ORDER BY CATEGORY";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "CS");

            conn.Close();

            return ds;
        }
    }
}
