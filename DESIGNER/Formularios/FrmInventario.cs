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
    public partial class FrmInventario : Form
    {
        Inventario inventario = new Inventario();

        public FrmInventario()
        {
            InitializeComponent();
        }

        private void resertForm()
        {
            txtCantidad.Clear();
            txtIdproducto.Clear();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            //GRID INVENTARIO

            gridInventario.DataSource = inventario.listarProductos();
            gridInventario.Refresh();

            //Configuracion GRID
            gridInventario.Columns[0].Width = 50;   //idproducto
            gridInventario.Columns[1].Width = 160;   //nombreproducto
            gridInventario.Columns[2].Width = 200;   //descripcion
            gridInventario.Columns[3].Width = 50;   //precio
            gridInventario.Columns[4].Width = 50;   //cantidad
            gridInventario.Columns[5].Width = 90;   //fechaP
            gridInventario.Columns[6].Width = 90;   //fechav
            gridInventario.Columns[7].Width = 50;   //numlote
            gridInventario.Columns[8].Width = 90;   //RecetaMedica

            //GRID DETALLE_COMPRA

            gridCompras.DataSource = inventario.listarInventario();
            gridCompras.Refresh();

            gridCompras.Columns[0].Width = 50;
            gridCompras.Columns[1].Width = 160;
            gridCompras.Columns[2].Width = 120;

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtIdproducto.Text == "" ||
               txtCantidad.Text == ""  || txtCantidad.Text.Trim() == String.Empty)
            {

                MessageBox.Show(
                    "Error, Complete los campos",
                    "Inventario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("¿Desea actualizar el inventario?","Inventario",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Question);
                inventario.editarInventario(Convert.ToInt16(txtIdproducto.Text), txtCantidad.Text);
                gridInventario.DataSource = inventario.listarProductos();
                gridInventario.Refresh();

                resertForm();

            }


        }

      
    }
}
