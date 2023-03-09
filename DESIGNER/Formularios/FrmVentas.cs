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

        private void resetForm()
        {
            txtdni.Clear();
            txtdatos.Clear();
            txtruc.Clear();
            txtempresa.Clear();
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
                    DataGridViewRow file = new DataGridViewRow();
                    file.CreateCells(gridProductos);

                    file.Cells[0].Value = txtDescripcion.Text;
                    file.Cells[1].Value = txtStock.Text;
                    file.Cells[2].Value = txtPrecio.Text;
                    file.Cells[3].Value = numCantidad.Text;
                    file.Cells[4].Value = Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(numCantidad.Text);

                    gridProductos.Rows.Add(file); 
                    txtDescripcion.Text = txtStock.Text = txtPrecio.Text  = "";
 
                    double sub = 0;
                    int contador = 0;
                    double igvs = 0.18;



                    contador = gridProductos.RowCount;

                    for (int i = 0; i < contador; i++)
                    {
                        sub += double.Parse(gridProductos.Rows[i].Cells[4].Value.ToString());
                   
                    }

                    double igv = sub * igvs;
                    double neto = sub + igv;

                    txtsub.Text = sub.ToString();
                    txtigv.Text = igv.ToString();
                    txtneto.Text = neto.ToString();

                    
                    
                }else

                {
                    MessageBox.Show("ERROR, Producto no encontrado ");
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
                    if (dt.Rows.Count > 0)
                    {
                        txtdatos.Text = dt.Rows[0][0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("¡Datos Incorrectos!");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese Numero de DNI");
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
                    if (dt.Rows.Count > 0)
                    {
                        txtempresa.Text = dt.Rows[0][0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("¡Datos Incorrectos!");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese Numero de RUC");
                }
            }
        }

        private void rbBoleta_CheckedChanged(object sender, EventArgs e)
        {
            txtdni.Visible = true;
            txtdatos.Visible = true;
            txtruc.Visible = false;
            txtempresa.Visible = false;
            txtdatos.ReadOnly = true;


            lbldni.Text = "DNI";
            lbldatos.Text = "Datos del Cliente";
            resetForm();
        }

        private void rdFactura_CheckedChanged(object sender, EventArgs e)
        {
            txtdni.Visible = false;
            txtdatos.Visible = false;
            txtruc.Visible = true;
            txtempresa.Visible = true;
            txtempresa.ReadOnly = true;


            lbldni.Text = "RUC";
            lbldatos.Text = "Nombre Empresa";
            resetForm();
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
