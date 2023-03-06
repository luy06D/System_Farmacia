using BOL;
using ENTITIES;
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

<<<<<<< HEAD
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void txtdnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtdni.Text != "")
                {

                    table = ventas.buscarPersona(Convert.ToInt32(txtdni.Text));

                    txtdatos.Text = table.Rows[0][1].ToString();

                }
            }
        }
=======
   
>>>>>>> f0ec7d0eedd8a0bc2ee24e92faa4ca12920e83d8
    }
}
