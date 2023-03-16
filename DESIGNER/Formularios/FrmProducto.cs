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
    public partial class FrmProducto : Form
    {
        Productos productos = new Productos();
        Eproductos eproductos = new Eproductos();


        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            gridproductos.DataSource = productos.ListarProductos();
            gridproductos.Refresh();

        }
        private void resetForm()
        {
            txtidlaboratorio.Clear();
            txtidcategoria.Clear();
            txtnombreproducto.Clear();
            txtdescripcion.Clear();
            txtprecio.Clear();
            txtcantidad.Clear();
            txtfechaproduccion.Clear();
            txtfechavencimiento.Clear();
            txtnumerolote.Clear();
            txtreceta.Clear();
            txtbarcode.Clear();

        }

        private DialogResult pregunta(string pregunta)
        {
            return MessageBox.Show(pregunta, "Sistema - Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtidlaboratorio.Text.Trim() != "" &&
                txtidcategoria.Text.Trim() != "" &&
                txtnombreproducto.Text.Trim() != "" &&
                txtdescripcion.Text.Trim() != "" &&
                txtprecio.Text.Trim() != "" &&
                txtcantidad.Text.Trim() != "" &&
                txtfechaproduccion.Text.Trim() != "" &&
                txtfechavencimiento.Text.Trim() != "" &&
                txtnumerolote.Text.Trim() != "" &&
                txtreceta.Text.Trim() != "" &&
                txtbarcode.Text.Trim() != "")
            {
                if (pregunta("¿Desea registar un nuevo producto?") == DialogResult.Yes)
                {
                    eproductos.idlaboratorio = Convert.ToInt32(txtidlaboratorio.Text);
                    eproductos.idcategoria = Convert.ToInt32(txtidcategoria.Text);
                    eproductos.nombreproducto = txtnombreproducto.Text;
                    eproductos.descripcion = txtdescripcion.Text;
                    eproductos.precio = txtprecio.Text;
                    eproductos.cantidad = Convert.ToInt32(txtcantidad.Text);
                    eproductos.fechaproduccion = txtfechaproduccion.Text;
                    eproductos.fechavencimiento = txtfechavencimiento.Text;
                    eproductos.numlote = txtnumerolote.Text;
                    eproductos.recetamedica = txtreceta.Text;
                    eproductos.barcode = txtbarcode.Text;

                    productos.registrarProductos(eproductos);

                    MessageBox.Show("Registrado con exito");

                    gridproductos.DataSource = productos.ListarProductos();
                    gridproductos.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Faltan Registrar datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetForm();

        }
    }
}
