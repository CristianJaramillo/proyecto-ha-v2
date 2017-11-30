using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BD_HA_V2.Store
{
    public class Connection
    {

        private static string config = "server=127.0.0.1; database=herramientasaut_v2; Uid=root; pwd=Tesseract454_;";
        private static MySqlConnection connection;

        /// <summary>
        /// 
        /// </summary>
        public static MySqlConnection GetConnection()
        {

            try
            {
                if (connection == null)
                {
                    connection = new MySqlConnection(config);
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                return connection;
            }
            catch (MySqlException e)
            {
                // MetroFramework.MetroMessageBox.Show(null, e.Message, "Fatal error - PowerDev", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                System.Windows.Forms.MessageBox.Show(e.Message);
                Close();
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        public static MySqlDataAdapter GetDataAdapter(string query)
        {
            return new MySqlDataAdapter(query, GetConnection());
        }
        

        /// <summary>
        /// 
        /// </summary>
        public static void Close()
        {
            try
            {
                if(connection != null)
                    connection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static MySqlCommand GetCommand(string query)
        {
            return new MySqlCommand(query, GetConnection());
        }

    }
}
