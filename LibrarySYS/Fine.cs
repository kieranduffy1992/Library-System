using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
    class Fine
    {
        private int id;
        private decimal amount;
        private String fineDate;

        public Fine(int id, decimal amount, String fineDate)
        {
            this.id = id;
            this.amount = amount;
            this.fineDate = fineDate;
        }

        public int getId()
        {
            return id;
        }

        public decimal getAmount()
        {
            return amount;
        }

        public void setAmount(decimal amount)
        {
            this.amount = amount;
        }

        public String getFineDate()
        {
            return fineDate;
        }

        public void setFineDate(String fineDate)
        {
            this.fineDate = fineDate;
        }

        public static int getNextID()
        {
            int nextId = 0;

            String strSQL = "SELECT MAX(FINEID) FROM FINES";

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
        public void addFine()
        {
            String strSQL = "INSERT INTO FINES VALUES (" + this.id + "," + this.amount + ",'" + this.fineDate +"')";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataTable getFineDetails(String year)
        {

            String strSQL = "SELECT SUM(Amount), to_Char(Fine_Date,'MM') FROM Fines WHERE EXTRACT(YEAR FROM fine_date) = " + year + " GROUP BY to_Char(Fine_Date,'MM') ORDER BY to_char(Fine_Date,'MM')";
            DataTable dt = new DataTable();

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(dt);
            conn.Close();
            
            return dt;
        }

        public static Double getTotalFine(DataTable dt) 
        {
            if (dt.Rows.Count > 0)
            {
                /*****************************************************
                    *    Title: Compute method of Datatable not working
                    *    Author: Steve
                    *    Site owner/sponsor: stackoverflow.com
                    *    Date: 2014
                    *    Code version: edited Oct 28 2014 at 10:14
                    *    Availability: http://stackoverflow.com/questions/26605543/compute-method-of-datatable-not-working (Accessed 03 April 2021)
                    
                    *****************************************************/

                object totalFines = dt.Compute("Sum([SUM(AMOUNT)])", "");

                return Convert.ToDouble(totalFines);
            }

            return 0;               
        }

        public static void populateMonths(String[] months)
        {
            for (int i = 0; i < 12; i++)
            {
                months[i] = Fine.getMonth(Convert.ToInt32(i + 1));
                
            }
        }

        public static void populateRevenue(decimal[] revenue, DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                revenue[Convert.ToInt32(dt.Rows[i][1]) - 1] = Convert.ToDecimal(dt.Rows[i][0]);
            }
        }

        public static String getMonth(int month)
        {
            switch (month)
            {
                case 1:
                    {
                        return "JAN";

                    }
                case 2:
                    {
                        return "FEB";

                    }
                case 3:
                    {
                        return "MAR";

                    }
                case 4:
                    {
                        return "APR";

                    }
                case 5:
                    {
                        return "MAY";

                    }
                case 6:
                    {
                        return "JUN";

                    }
                case 7:
                    {
                        return "JUL";

                    }
                case 8:
                    {
                        return "AUG";

                    }
                case 9:
                    {
                        return "SEP";

                    }
                case 10:
                    {
                        return "OCT";

                    }
                case 11:
                    {
                        return "NOV";

                    }
                case 12:
                    {
                        return "DEC";

                    }
                default: return "OTH";

            }
        }
    }
}
