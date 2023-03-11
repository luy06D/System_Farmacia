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
using ENTITIES;

namespace DESIGNER.Formularios
{
    public partial class FrmClientes : Form
    {

        Persona persona = new Persona();
        Epersonas epersonas = new Epersonas();
        public FrmClientes()
        {
            InitializeComponent();
        }

        private DialogResult pregunta(string pregunta)
        {
            return MessageBox.Show(pregunta, "Sistema - registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtnombres.Text.Trim() != "" &&
                txtnombres.Text.Trim() != "" &&
                txtdni.Text.Trim() != "")
            {
                if (pregunta("¿Desea registrar un nuevo cliente?") == DialogResult.Yes)
                {
                     epersonas.apellidos = txtapellidos.Text;
                    epersonas.nombres = txtnombres.Text;
                    epersonas.dni = txtdni.Text;

                    persona.registrarClientes(epersonas);

                   MessageBox.Show("Registrado con exito");
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

         

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
