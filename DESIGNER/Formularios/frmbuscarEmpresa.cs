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
    public partial class frmbuscarEmpresa : Form
    {
        Empresa empresa = new Empresa();
        DataTable dt = new DataTable();
        DataView dataView;

        //Estos datos se pasaran al frmventas
        public int idempresa = -1;
        public string datosEmpresa = "";

        public frmbuscarEmpresa()
        {
            InitializeComponent();
        }


        private void obtenerDatos()
        {
            dt = empresa.getdataEmpresa();
            gridEmpresa.DataSource = dt;
            dataView = dt.DefaultView;

        }
        private void frmbuscarEmpresa_Load(object sender, EventArgs e)
        {
            obtenerDatos();

            gridEmpresa.Columns[0].Visible = false; // idempresa
            gridEmpresa.Columns[1].Width = 200;
            gridEmpresa.Columns[2].Width = 250;
            
   

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Si pulsamos no se envian los datos
            idempresa = -1;
            datosEmpresa = "";
            this.Close();
        }

        private void gridEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridEmpresa.Rows.Count > 0)
            {
                idempresa = Convert.ToInt32(gridEmpresa.CurrentRow.Cells[0].Value);
                datosEmpresa = gridEmpresa.CurrentRow.Cells[1].Value.ToString();
            
                this.Close();
            }
            else
            {
                idempresa = -1;
                datosEmpresa = "";
            }
        }

        private void txtBuscadorEmpresa_KeyUp(object sender, KeyEventArgs e)
        {
            dataView.RowFilter = "ruc like '%" + txtBuscadorEmpresa.Text.Trim() + "%'";
        }
    }
}
