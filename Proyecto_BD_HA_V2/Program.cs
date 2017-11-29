using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// Proyecto: GamesScore

namespace Proyecto_BD_HA_V2
{
    static class Program
    {

        private static readonly ILog LOGGER = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            bool isNew = false;

            Mutex mtx = new Mutex(true, "BD_HA_V2", out isNew);

            LOGGER.Info("Verificamos que solo exista una aplicación abierta.");
            if (!isNew)
                return;

            LOGGER.Info("Aqui estamos llamando a la funcionn de Obtener conexion");
            BDConexion.ObtenerConexion();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignIn());
        }
    }
}
