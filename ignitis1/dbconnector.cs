using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ignitis1
{
    internal class dbconnector
    {
        static public string DBConnect = "server =localhost; user=root; password=iVeHq5:%3(a,>m;database=db1";
        static public MySqlDataAdapter msDataAdapter;
        static MySqlConnection myconnect;
        static public MySqlCommand msCommand;

        public static bool Connectiondb()
        {
            try
            {
                myconnect = new MySqlConnection(DBConnect);
                myconnect.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = myconnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch
            {
                MessageBox.Show("Didele klaida",
                 "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static void CloseDB()
        {
            myconnect.Close();
        }

        public MySqlConnection GetSqlConnection()
        {
            return myconnect;
        }
        public static MySqlConnection GetConnection()
        {
            return myconnect;
        }

    }
}