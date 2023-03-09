using BOL;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DESIGNER.Formularios
{
    public partial class FrmVentas : Form
    {

        Productos productos = new Productos();
        Ventas ventas = new Ventas();
        DataTable dt = new DataTable();


        public FrmVentas()
        {
            InitializeComponent();
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtBarcode.Text != "")
                {
                    dt = productos.buscarBarCode(Convert.ToString(txtBarcode.Text));

                    if (dt.Rows.Count > 0)
                    {
                        txtDescripcion.Text = dt.Rows[0][0].ToString();
                        txtStock.Text = dt.Rows[0][1].ToString();
                        txtPrecio.Text = dt.Rows[0][2].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No existe el codigo" + " " + txtBarcode.Text, "CODEBAR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el codigo del producto", "Codebar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {

            txtBarcode.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            numCantidad.Value = 0;
        }


        private DialogResult pregunta(string pregunta)
        {
            return MessageBox.Show(pregunta, "Sistema - Personas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (pregunta("¿Desea agrega un nuevo producto a la lista?") == DialogResult.Yes)
            {
                if (txtDescripcion.Text != "" && txtStock.Text != "" && txtPrecio.Text != "" && numCantidad.Text != "")
                {
                    gridProductos.Rows.Add(txtDescripcion.Text, txtStock.Text, txtPrecio.Text, numCantidad.Text);

                    MessageBox.Show("Registrado correctamente");
                }
            }
        }



        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtdni.Text != "")
                {
                    dt = ventas.buscarPersona(Convert.ToInt32(txtdni.Text));

                    txtdatos.Text = dt.Rows[0][0].ToString();
                }
            }
        }

        private void txtruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtruc.Text != "")
                {
                    dt = ventas.buscarEmpresa(Convert.ToString(txtruc.Text));

                    txtempresa.Text = dt.Rows[0][0].ToString();
                }
            }
        }

        private void rbBoleta_CheckedChanged(object sender, EventArgs e)
        {
            txtdni.Visible = true;
            txtdatos.Visible = true;
            txtruc.Visible = false;
            txtempresa.Visible = false;

            lbldni.Text = "DNI";
            lbldatos.Text = "Datos del Cliente";
        }

        private void rdFactura_CheckedChanged(object sender, EventArgs e)
        {
            txtdni.Visible = false;
            txtdatos.Visible = false;
            txtruc.Visible = true;
            txtempresa.Visible = true;


            lbldni.Text = "RUC";
            lbldatos.Text = "Nombre Empresa";
        }


        private void FrmVentas_Load(object sender, EventArgs e)
        {
            //Instancia de un boton de columna
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();

            //Nombre del boton de cada fila del grid
            btnEliminar.Name = "Eliminar";
            gridProductos.Columns.Add(btnEliminar);



        }

        private void gridProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //Si tenemos columnas en el grid 
            if (e.ColumnIndex >= 0
                && gridProductos.Columns[e.ColumnIndex].Name == "Eliminar" // y si la columna es la columna eliminar
                && e.RowIndex >= 0)
            {
                //Render (pintar ) icono dentro del boton
                e.Paint(e.CellBounds, DataGridViewPaintParts.All); //Utiliza todo el espacio disponible

                //Construir icono 
                DataGridViewButtonCell celBtn = gridProductos.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                //Imagen (archivo ICO)

                Icon icono = new Icon(Environment.CurrentDirectory + @"\delete-file256_25240.ico");
                //Pintar el icono 
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 2, e.CellBounds.Top + 2);

                //Lo enviamos al grid 
                gridProductos.Rows[e.RowIndex].Height = icono.Height + 2;
                gridProductos.Columns[e.RowIndex].Width = icono.Width + 2;

                //Activamos el control de eventos sobre el nuevo boton 
                e.Handled = true;
            }
        }



    }
}
