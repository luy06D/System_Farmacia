using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DESIGNER.Formularios
{
    public partial class Ventana_Inicio : Form
    {
        public Ventana_Inicio()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(object form)
        {
            
            if(this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form ventana = form as Form;
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(ventana);
            this.panelContenedor.Tag = ventana;
            ventana.Show(); 
            
        }


        private void btnVenta_Click(object sender, EventArgs e)
        {

            AbrirFormulario(new FrmVentas());

        }

    

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            //Cierra la ventana
            Application.Exit();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
