using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Login_e_Inicio;

namespace PagoAgilFrba
{

    /*TODO: No se cierra la app al cerrar todas las ventanas*/
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Log());
        }
    }
}
