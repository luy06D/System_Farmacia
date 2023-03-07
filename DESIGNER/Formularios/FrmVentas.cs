using BOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER.Formularios
{
    public partial class FrmVentas : Form
    {
        Ventas ventas = new Ventas();
        DataTable table = new DataTable();
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {

        }

        private DialogResult preguntar(string textPregunta)
        {
            return MessageBox.Show(textPregunta, "Sistema farmacia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(txtdni.Text != "")
                {

                    table = ventas.buscarPersona(Convert.ToInt32(txtdni.Text));

                    txtdatos.Text =  table.Rows[0][1].ToString();
              
                }
            }
        }
    }
}
