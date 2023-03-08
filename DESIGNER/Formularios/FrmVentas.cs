using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;

namespace DESIGNER.Formularios
{
    public partial class FrmVentas : Form
    {
        Productos productos = new Productos();
        DataTable dt = new DataTable();
        
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dt = productos.buscarBarCode(Convert.ToString(txtBarcode.Text));

                txtDescripcion.Text = dt.Rows[0][0].ToString();
                txtStock.Text = dt.Rows[0][1].ToString();
                txtPrecio.Text = dt.Rows[0][2].ToString();
      
             
            }
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
