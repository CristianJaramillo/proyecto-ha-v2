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
        private static string version;
        private static MySqlConnection connection;
        private static MySqlCommand cmd;
        private static MySqlDataAdapter data;

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

                cmd = GetMysqlCommand();
                version = Convert.ToString(cmd.ExecuteScalar());

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
        public static void DataAdapter(string query)
        {
            data = new MySqlDataAdapter(query, GetConnection());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static MySqlDataAdapter GetDataAdapter()
        {
            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        public static string Version
        {
            get { return version; }
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
        public static MySqlCommand GetMysqlCommand(string query)
        {
            return new MySqlCommand(query, GetConnection());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static MySqlCommand GetMysqlCommand()
        {
            return new MySqlCommand("SELECT VERSION()", connection);
        }

    }
}
