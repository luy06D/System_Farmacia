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
            numCantidad.Value = 1;
        }


        private DialogResult pregunta(string pregunta)
        {
            return MessageBox.Show(pregunta, "Sistema - Personas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (pregunta("¿Desea agrega un nuevo producto a la lista?") == DialogResult.Yes)
            {

                if (txtDescripcion.Text != ""  && txtPrecio.Text != "" && numCantidad.Text != "" && txtUnd.Text != "")
                {
                    DataGridViewRow file = new DataGridViewRow();
                    file.CreateCells(gridProductos);

                    file.Cells[0].Value = txtDescripcion.Text;        
                    file.Cells[1].Value = numCantidad.Text;
                    file.Cells[2].Value = txtPrecio.Text;
                    file.Cells[3].Value = txtUnd.Text;
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
                    MessageBox.Show("Producto no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                


            }

        } 
        private void rbBoleta_CheckedChanged(object sender, EventArgs e)
        {

            txtdni.Visible = true;
            txtdatos.Visible = true;
            txtruc.Visible = false;
            txtempresa.Visible = false;
            txtdatos.Enabled = false;

            txtdni.Enabled = true;



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
            txtempresa.Enabled= false;

            txtruc.Enabled = true;

            lbldni.Text = "RUC";
            lbldatos.Text = "Nombre Empresa";


            resetForm();
        }



        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtdni.Text != "")
                {
                    dt = ventas.buscarPersona(Convert.ToString(txtdni.Text));

                    if (dt.Rows.Count > 0)
                    {
                        txtdatos.Text = dt.Rows[0][0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("¡Datos Incorrectos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese Numero de DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

       

        private void btnregistrarP_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
        }

        private void gridProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var ancho = Properties.Resources.delete.Width;
                var alto = Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - ancho) / 2;
                var y = e.CellBounds.Left + (e.CellBounds.Height - alto) / 2;

                //Se procede a pintar
                e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, ancho, alto));
                e.Handled = true;
            }              

        }


        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProductos.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int indice = e.RowIndex;

                if(indice >= 0)
                {

                    gridProductos.Rows.RemoveAt(indice);


                    // Reutilizamos parte del codigo del btnAgregar
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


                }
            }

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (gridProductos.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingrresar productos para realizar la venta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("idproducto", typeof(int));
            detalle_venta.Columns.Add("cantidad", typeof(int));
            detalle_venta.Columns.Add("unidad", typeof(string));
            detalle_venta.Columns.Add("precioventa", typeof(decimal));

            foreach (DataGridViewRow row in gridProductos.Rows)
            {
                detalle_venta.Rows.Add(
                    new object[]
                    {
                        Convert.ToInt16(row.Cells["idproducto"].Value.ToString()),
                        row.Cells["cantidad"].Value.ToString(),
                        row.Cells["unidad"].Value.ToString(),
                        row.Cells["precioventa"].Value.ToString(),

                    });
            }

            


        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            FrmEmpresas frmEmpresas = new FrmEmpresas();
            frmEmpresas.Show();
            

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtruc_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
