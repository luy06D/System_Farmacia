using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER
{
    public class dialogo
    {
        public static void imformar(string mensaje)
        {
            MessageBox.Show(mensaje, "Hotel versión 1.1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Alerta tipo error

        public static void Error(string mensaje)
        {
            MessageBox.Show(mensaje, "Hotel versión 1.1", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult Preguntar(string mensaje)
        {
            return MessageBox.Show(mensaje, "Hotel versión 1.1", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
