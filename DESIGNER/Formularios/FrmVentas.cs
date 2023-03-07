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
using BOL;
using ENTITIES;

namespace DESIGNER.Formularios
{
    public partial class FrmVentas : Form
    {
        Ventas ventas = new Ventas();
        DataView dv = new DataView();
        DataTable dt = new DataTable();
        string campoFiltro = "nombreproducto";
        public FrmVentas()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargaDatos();



            gridVentas.Columns[0].Width = 50; //id
            gridVentas.Columns[1].Width = 220; //razonsocial
            gridVentas.Columns[2].Width = 100; //ruc
            gridVentas.Columns[3].Width = 150; //direccion
            gridVentas.Columns[4].Width = 100; //telefono
            gridVentas.Columns[5].Width = 75; //email
        }
        private void CargaDatos()
        {
            dt = ventas.listar();
            gridVentas.DataSource = dt;
            gridVentas.Refresh();
            dv = dt.DefaultView;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text.Trim() != String.Empty)
            { 
            dv.RowFilter = campoFiltro + " LIKE '%" + txtBuscar.Text.Trim() + "%' ";
            }
            else
            {
                gridVentas.ClearSelection();

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
=======
        
>>>>>>> 4837770d920981dd6562c7ddee64bbbcd201cd67
    }
}
