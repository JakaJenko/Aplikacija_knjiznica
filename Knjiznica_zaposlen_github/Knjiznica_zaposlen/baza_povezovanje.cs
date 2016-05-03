using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica_zaposlen
{
    class baza_povezovanje
    {

        public static MySqlConnection connection;
       // public static string server = "localhost";  // 77.38.93.184
        public static string server = "77.38.93.184";
        //public static string database = "knjiznica";
        public static string database = "jaka";
        //public static string userid = "root";
        public static string userid = "jaka";// 
        //public static string geslo = "";
        public static string geslo = "jaka"; 
        public static int port = 3306;

        public static string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + userid + ";" + "PASSWORD=" + geslo + ";";
        
       // public static string connectionString2 = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + userid + ";" + "PASSWORD=" + geslo + ";";

        public static bool db_povezi()
        {
            connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            try
            {
                connection.Open();

                //MessageBox.Show("DELA!");

                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Povezava z serverjem nemogoča.");
                        break;

                    case 1045:
                        MessageBox.Show("Napačni credential-i.");
                        break;
                }
                return false;
            }
        }

        public static bool db_prekini_povezavo()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
