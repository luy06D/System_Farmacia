using BOL;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        EVentas eventas = new EVentas();
        Eclientes eclientes = new Eclientes();  
        Eempresa eempresa = new Eempresa();
        Eusuarios  eusuarios = new Eusuarios();
        Edetalle_venta edetalle = new Edetalle_venta();

        int idproducto = -1;

        public FrmVentas()
        {

            InitializeComponent();
        }
        

        private void resetForm()
        {
            //txtdni.Clear();
            txtdatos.Clear();
           // txtruc.Clear();
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
                        idproducto = Convert.ToInt32(dt.Rows[0][0].ToString());
                        txtDescripcion.Text = dt.Rows[0][1].ToString();
                        txtStock.Text = dt.Rows[0][2].ToString();
                        txtPrecio.Text = dt.Rows[0][3].ToString();

                        numCantidad.Maximum = Convert.ToDecimal(txtStock.Text);
                        btnAgregar.Focus();
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
            txtUnd.Clear();
            numCantidad.Value = 1;
        }


        private DialogResult pregunta(string pregunta)
        {
            return MessageBox.Show(pregunta, "Sistema - Personas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Verificamos que hemos encontrado el producto
            if (idproducto != -1)
            {

                if (!existeDuplicado(idproducto))
                {
                    decimal importe = Convert.ToDecimal(txtPrecio.Text) * numCantidad.Value;

                    gridProductos.Rows.Add( numCantidad.Value.ToString(), idproducto.ToString(), txtDescripcion.Text, txtPrecio.Text, importe.ToString(), txtUnd.Text);

                    montoPago();
                    idproducto = -1;

                    resetCamposProducto();
                    txtBarcode.Focus();                   
                    
                }

            }
            else
            {
                MessageBox.Show("Producto no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool existeDuplicado(int idtmp)
        {
            int i = 0;
            int cantidadSolicitada = 0;
            decimal nuevoImporte = 0;
            bool encontrado = false;

            //Recorremos todo el datagridview, buscando en la segunda columna si el "idproducto" ya existe
            if (gridProductos.Rows.Count > 0)
            {
                while (i < gridProductos.Rows.Count && !encontrado)
                {
                    //Si lo encontramos verificamos si podemos la cantidad comprada no supera el stock
                    if (Convert.ToInt32(gridProductos.Rows[i].Cells[1].Value) == idtmp)
                    {
                        //Se calcula el total solicitado sumando la cantidad del grid + cantidad ingresada en la caja de texto
                        cantidadSolicitada = Convert.ToInt32(gridProductos.Rows[i].Cells[0].Value) + Convert.ToInt32(numCantidad.Value);

                        if (cantidadSolicitada > Convert.ToInt32(txtStock.Text))
                        {
                            MessageBox.Show(
                                "No podemos atender su pedido porque sobrepasa el stock",
                                "Infotec ventas",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            numCantidad.Focus();
                        }
                        else
                        {
                            //Si la cantidad que se va a agregar + la cantidad que ya se solicitó, NO sobrepasa el stock, se procede a la actualización
                            gridProductos.Rows[i].Cells[0].Value = cantidadSolicitada;

                            //Calculando nuevo importe
                            nuevoImporte = Convert.ToDecimal(txtPrecio.Text) * cantidadSolicitada;
                            gridProductos.Rows[i].Cells[4].Value = nuevoImporte;

                            resetCamposProducto();
                            txtBarcode.Focus();
                        }

                        encontrado = true;
                    }

                    i++;
                }
            }

            return encontrado;
        }

        private void resetCamposProducto()
        {
            txtBarcode.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            txtUnd.Clear();
            numCantidad.Value = 1;
        }


        //Metodo para calcular el sub , igv y total
        private void montoPago()
        {
            double neto = 0, igv = 0, subtotal = 0;

            if (gridProductos.Rows.Count > 0)
            {
                for (int i = 0; i < gridProductos.Rows.Count; i++)
                {
                    neto += Convert.ToDouble(gridProductos.Rows[i].Cells[4].Value);
                }

                subtotal = neto / 1.18;
                igv = neto - subtotal;
            }

            txtsub.Text = subtotal.ToString("0.00");
            txtigv.Text = igv.ToString("0.00");
            txtneto.Text = neto.ToString("0.00");

            
        }



        private void rbBoleta_CheckedChanged(object sender, EventArgs e)
        {

            btnBuscar.Enabled = true;
            eventas.tipoComprobante = 'B';
            btnBuscarEmpresa.Enabled = false;
            txtdatos.Visible = true;
            txtempresa.Visible = false;
            txtdatos.Enabled = false;
            lbldatos.Text = "Datos del Cliente";


            resetForm();
        }

        private void rdFactura_CheckedChanged(object sender, EventArgs e)
        {

            eventas.tipoComprobante = 'F';
         
            txtdatos.Visible = false;
            txtempresa.Visible = true;
            txtempresa.Enabled= false;
            btnBuscarEmpresa.Enabled = true;
            btnBuscar.Enabled = false;

          
            lbldatos.Text = "Nombre Empresa";


            resetForm();
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
                  
                    montoPago();
                  
                }
            }

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //Si el numero de filas es igual a cero
            if(gridProductos.Rows.Count == 0)
            {
                MessageBox.Show("No ha indicado productos","FARMACHINCHA ventas", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtBarcode.Focus();
            }
            else
            {
                if (MessageBox.Show(
                    "¿Desea finalizar esta venta?",
                    "FARMACHINCHA Ventas",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idVentaObtenido = ventas.registrarVentas(eventas);

                    if(idVentaObtenido == -1)
                    {
                       MessageBox.Show("Existen errores, consulte al administrador del sistema","FARMACHINCHA Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Enviamos todos los datos del datagridview
                        enviarProductos(idVentaObtenido);
                    }
                }
            }
        

        }

        private void enviarProductos(int idventa)
        {
            for(int i = 0; i < gridProductos.Rows.Count; i++)
            {
                edetalle.idventa = idventa;
                edetalle.idproducto = Convert.ToInt32(gridProductos.Rows[i].Cells[1].Value);
                edetalle.cantidad = Convert.ToInt32(gridProductos.Rows[i].Cells[0].Value);
                edetalle.unidad = Convert.ToString(gridProductos.Rows[i].Cells[5].Value);
                edetalle.precioVenta = Convert.ToDecimal(gridProductos.Rows[i].Cells[3].Value);

                ventas.registrarDetalleV(edetalle);

            }

            //Reseteamos todo el frmVentas
            rbBoleta.Checked = true;
            txtdatos.Clear();

            
            resetCamposProducto();
            gridProductos.Rows.Clear();

            eventas.tipoComprobante = 'B';
            eventas.tipoComprobante = 'F';
            eventas.idcliente = -1;
            eventas.idusuario = -1;
            eventas.idempresa = -1;

            txtsub.Clear();
            txtigv.Clear();
            txtneto.Clear();

            MessageBox.Show("Se registró una venta y su detalle correctamente","FARMACHINCHA Ventas",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }



        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            FrmEmpresas frmEmpresas = new FrmEmpresas();
            frmEmpresas.Show();
            

        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarCliente buscarCliente = new frmBuscarCliente();
            buscarCliente.ShowDialog();

            if(buscarCliente.idcliente != -1)
            {
                eventas.idcliente = buscarCliente.idcliente;
                txtdatos.Text = buscarCliente.datosCliente;

            }
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            frmBuscarProducto buscarProducto = new frmBuscarProducto(); 
            buscarProducto.ShowDialog();

            if(buscarProducto.idproducto != -1)
            {
                int stock = buscarProducto.stock;
                decimal precio = buscarProducto.precio;


                idproducto = buscarProducto.idproducto;
                txtDescripcion.Text = buscarProducto.datosProducto;
                txtStock.Text = stock.ToString();
                txtPrecio.Text = precio.ToString();
                

            }
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            gridProductos.Columns[0].Width = 90;            
            gridProductos.Columns[2].Width = 740;
            gridProductos.Columns[3].Width = 100;
            gridProductos.Columns[4].Width = 98;
            gridProductos.Columns[5].Width = 90;

        }

        private void btnBuscarEmpresa_Click(object sender, EventArgs e)
        {
            frmbuscarEmpresa buscarEmpresa = new frmbuscarEmpresa();
            buscarEmpresa.ShowDialog();

            if (buscarEmpresa.idempresa != -1)
            {
                eventas.idempresa = buscarEmpresa.idempresa;
                txtempresa.Text = buscarEmpresa.datosEmpresa;

            }

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
