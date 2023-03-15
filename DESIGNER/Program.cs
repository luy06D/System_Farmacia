using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Formularios.FrmLogin());
=======
            Application.Run(new Formularios.FrmProductos());
>>>>>>> 25e2f646142d3dd0c8a37e82f600bdecef752875
        }
    }
}
