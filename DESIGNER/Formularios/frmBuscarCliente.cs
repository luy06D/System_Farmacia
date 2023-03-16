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
    public partial class frmBuscarCliente : Form
    {

        Persona persona = new Persona();
        DataTable dt = new DataTable();
        DataView dataView;

        //Estos datos se pasaran al frmventas
        public int idcliente = -1;
        public string datosCliente = "";

        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        private void obtenerDatos()
        {
            dt = persona.getdataPersona();
            gridClientes.DataSource = dt;
            dataView = dt.DefaultView;

        }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            obtenerDatos();

            gridClientes.Columns[0].Visible = false;
            gridClientes.Columns[1].Width = 300;
            gridClientes.Columns[2].Width = 300;
            gridClientes.Columns[3].Width = 100;
            gridClientes.Columns[4].Width = 100;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Si pulsamos no se envian los datos
            idcliente = -1;
            datosCliente = "";
            this.Close();

            

        }

        private void gridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridClientes.Rows.Count > 0)
            {
                idcliente = Convert.ToInt32(gridClientes.CurrentRow.Cells[0].Value);
                datosCliente = gridClientes.CurrentRow.Cells[1].Value.ToString()
                + " " + gridClientes.CurrentRow.Cells[2].Value.ToString();
                this.Close();
            }
            else
            {
                idcliente = -1;
                datosCliente = "";
            }
        }

        private void txtBuscadorCliente_KeyUp(object sender, KeyEventArgs e)
        {
            dataView.RowFilter = "dni like  '%" + txtBuscadorCliente.Text.Trim() + "%'";

        }
    }
}
