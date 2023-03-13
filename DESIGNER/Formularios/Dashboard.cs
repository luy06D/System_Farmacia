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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas ventas = new FrmVentas();
            ventas.MdiParent = this;    
            ventas.WindowState = FormWindowState.Maximized; 
            ventas.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos producto = new FrmProductos();
            producto.MdiParent = this;
            producto.WindowState = FormWindowState.Maximized;
            producto.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario inventario = new FrmInventario();
            inventario.MdiParent = this;
            inventario.WindowState = FormWindowState.Maximized;
            inventario.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
       
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
