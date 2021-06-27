using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LibrarySYS
{
    class Utility
    {
        public static void formatGrid(DataGridView dg)
        {

            dg.Columns["ID"].ReadOnly = true;
            dg.Columns["ID"].Width = 50;
            dg.Columns["ID"].DefaultCellStyle.Format = "0000";
            dg.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["Title"].ReadOnly = true;
            dg.Columns["Title"].Width = 160;
            dg.Columns["Title"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dg.Columns["Author"].ReadOnly = true;
            dg.Columns["Author"].Width = 140;
            dg.Columns["Author"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Author"].DefaultCellStyle.Format = "N2";

         }
        public static void formatBookGrid(DataGridView dg)
        {

            dg.Columns["ID"].ReadOnly = true;
            dg.Columns["ID"].Width = 50;
            dg.Columns["ID"].DefaultCellStyle.Format = "0000";
            dg.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["ITEMID"].ReadOnly = true;
            dg.Columns["ITEMID"].Width = 50;
            dg.Columns["ITEMID"].DefaultCellStyle.Format = "0000";
            dg.Columns["ITEMID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns["Title"].ReadOnly = true;
            dg.Columns["Title"].Width = 160;
            dg.Columns["Title"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dg.Columns["DUE_DATE"].ReadOnly = true;
            dg.Columns["DUE_DATE"].Width = 140;
            dg.Columns["DUE_DATE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        }

        public static void loadYears(ComboBox cbo)
        {
            int year = DateTime.Now.Year;

            for (int i = 1; i < 4; i++)
            {
                cbo.Items.Add(year.ToString());
                year = year - 1;
            }

        }

        public static void loadCategories(ComboBox cbo)
        {
            DataSet ds = Category.getCategories();

            for (int i = 0; i < ds.Tables["CS"].Rows.Count; i++)
                cbo.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " - " +
                ds.Tables[0].Rows[i][1].ToString());
        }

        public static void styleChart(Chart chart)
        {
            chart.Titles.Clear();
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Fine in €";
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart.Series[0].IsVisibleInLegend = false;            
            chart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

        }

        public static Boolean isValidTelephone(String number)
        {
            Boolean valid = false;
            int numberHyphens = 0;
            int i ;

            if(number.Equals(""))
                return valid;

            if (number[0] == '0')
            {
                for(i=0;i<number.Length;i++)
                {
                    if (number[i] == '-')
                        numberHyphens++;
                    if (!Char.IsDigit(number[i]) && number[i] != '-')
                        break;
                }

                if (numberHyphens <= 1 && i == number.Length)
                    valid = true;

            }

            return valid;
        }

        public static Boolean isVaildEmail(String email)
        {
            Boolean valid = false;
            int numAt = 0;
            int numDots = 0;

            if (email.Equals(""))
                return valid;

            for (int i=0; i<email.Length; i++)
            {
                if (email[i] == '@')
                    numAt++;
                if (email[i] == '.')
                    numDots++;
            }

            if (numDots >= 1 && numAt == 1)
                valid = true;

            return valid;
        }

        public static Boolean isValidISBN(String isbn)
        {
            Boolean valid = false;
            int i;

            if (isbn.Equals(""))
                return valid;

            if (isbn.Length != 13)
                return valid;

            for(i=0; i<isbn.Length; i++)
            {
                if (!Char.IsDigit(isbn[i]))
                    break;
            }

            if (i == isbn.Length)
                valid = true;

            return valid;
        }

        public static Boolean isValidFirstName(String name)
        {
            if (name.Equals(""))
                return false;

            /*****************************************************
                    *    Title: Regular Expression for First name
                    *    Author: Wiktor Stribiżew
                    *    Site owner/sponsor: stackoverflow.com
                    *    Date: 2017
                    *    Code version: edited Dec 08 2017 at 19:14
                    *    Availability: https://stackoverflow.com/questions/47718784/regular-expression-for-first-name (Accessed 23 Feburary 2021)
                    
                    *****************************************************/

            if (!Regex.IsMatch(name, @"^(?=.{1,40}$)[a-zA-Z]+(?:[-'\s][a-zA-Z]+)*$"))
            {
                return false;
            }

            return true;

        }
        public static Boolean isValidSurname(String name)
        {
            if (name.Equals(""))
                return false;

            /*****************************************************
                    *    Title: Regular Expression issue matching string pattern “A-Za-z-A-Za-z_”
                    *    Author: Beny23
                    *    Site owner/sponsor: stackoverflow.com
                    *    Date: 2012
                    *    Code version: edited April 19 2012 at 09:44
                    *    Availability: https://stackoverflow.com/questions/10225422/regular-expression-issue-matching-string-pattern-a-za-z-a-za-z (Accessed 23 Feburary 2021)
                    
                    *****************************************************/

            if (!Regex.IsMatch(name, @"^[a-zA-Z'][a-zA-Z' - ]*[a-zA-Z']?$"))
            {
                return false;
            }

            return true;
        }

        public static Boolean isValidWord(String word)
        {
            if (word.Equals(""))
            {
                return false;
            }
 
            for (int i = 0; i < word.Length; i++)
            {
                
                if (Char.IsLetter(word[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }

        public static Boolean isValidMemberID(String id)
        {
            if (id.Equals(""))
            {
                return false;
            }

            for (int i = 0; i < id.Length; i++)
            {

                if (Char.IsDigit(id[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }

        public static void navigateHome(Form frm)
        {
            frm.Hide();
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.ShowDialog();
            frm.Close();
        }

        public static void exitApplication()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit LibrarySYS?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
