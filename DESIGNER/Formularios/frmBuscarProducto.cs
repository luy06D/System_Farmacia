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
    public partial class frmBuscarProducto : Form
    {
        Productos productos = new Productos();
        DataTable dt = new DataTable();
        DataView dataView;

        //Datos se pasaran al frmventas
        public int idproducto = -1;
        public string datosProducto = "";
        public decimal precio = 0;
        public int stock = 0;


        public frmBuscarProducto()
        {
            InitializeComponent();
        }

        private void obtenerDatos()
        {
            dt = productos.getdataProducto();
            gridProductos.DataSource = dt;
            dataView = dt.DefaultView;

            gridProductos.Refresh();
        }


        private void frmBuscarProducto_Load(object sender, EventArgs e)
        {

            obtenerDatos();

            gridProductos.Columns[0].Visible = false; //idproducto 
            gridProductos.Columns[1].Width = 650;   //descripcion
            gridProductos.Columns[2].Width = 90;    //cantidad
            gridProductos.Columns[3].Width = 100;   //precio
            gridProductos.Columns[4].Width = 100;   //recetaM

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            idproducto = -1;
            datosProducto = "";
            precio = 0;
            stock = 0;
            this.Close();
        }

        private void gridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProductos.Rows.Count > 0)
            {
                idproducto = Convert.ToInt32(gridProductos.CurrentRow.Cells[0].Value);
                datosProducto = gridProductos.CurrentRow.Cells[1].Value.ToString();
                stock = Convert.ToInt32(gridProductos.CurrentRow.Cells[2].Value);
                precio = Convert.ToDecimal(gridProductos.CurrentRow.Cells[3].Value);

                this.Close();
            }
            else
            {
                idproducto = -1;
                datosProducto = "";
                precio = 0;
                stock = 0;
            }

        }
    }
}
