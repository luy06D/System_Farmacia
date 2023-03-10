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
    public partial class FrmProductos : Form
    {
        Productos productos = new Productos();
        DataTable regprod = new DataTable();

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            gridProductos.DataSource = productos.listarProductos();
            gridProductos.Refresh();

            gridProductos.Columns[0].Width = 50;
            gridProductos.Columns[1].Width = 60;
            gridProductos.Columns[2].Width = 50;
            gridProductos.Columns[3].Width = 75; 
            gridProductos.Columns[4].Width = 90;
        }

        private DialogResult preguntar(string textPregunta)
        {
            return MessageBox.Show(textPregunta, "Sistema - personas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
        private void resetForm()
        {
            txtnombreproducto.Clear();
            txtdescripcion.Clear();
            txtprecio.Clear();
            txtcantidad.Clear();
            txtfechaproduccion.Clear();
            txtvencimiento.Clear();
            txtnumlote.Clear();
            txtrecetamedica.Clear();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (preguntar("¿Desea agregar los datos?") == DialogResult.Yes)
            {
                string idlaboratorio = txtrecetamedica.Text;
                string idcategoria = txtnombreproducto.Text;
                string nombreproducto = txtnombreproducto.Text;
                string descripcion = txtdescripcion.Text;
                string precio = txtprecio.Text;
                string cantidad = txtcantidad.Text;
                string fechaproduccion = txtfechaproduccion.Text;
                string vencimiento = txtvencimiento.Text;
                string numlote = txtnumlote.Text;
                string recetamedica = txtrecetamedica.Text;
                string barcode = txtbarcode.Text;

                productos.registrarProductos(Convert.ToInt16(idlaboratorio), Convert.ToInt16(idcategoria), nombreproducto, descripcion, precio, cantidad, fechaproduccion, vencimiento, numlote, recetamedica, barcode);
                resetForm();

                gridProductos.DataSource = productos.listarProductos();
                gridProductos.Refresh();

                MessageBox.Show("Agregado correctamente");
            }
        }

    }
}
