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
    
    public partial class FrmRPersonas : Form
    {
        Persona persona = new Persona();
        Epersonas epersonas = new Epersonas();
        public FrmRPersonas()
        {
            InitializeComponent();
        }

        private DialogResult pregunta(string pregunta)
        {
            return MessageBox.Show(pregunta, "Sistema - registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text.Trim() != "" &&
               txtApellidos.Text.Trim() != "" &&
                   txtDNI.Text.Trim() != "" &&
                   txtTelefono.Text.Trim() != "")
            {
                if (pregunta("¿Desea registrar una nueva persona?") == DialogResult.Yes)
                {
                    epersonas.nombres = txtNombres.Text;
                    epersonas.apellidos = txtApellidos.Text;
                    epersonas.dni = txtDNI.Text;
                    epersonas.telefono = txtTelefono.Text;
                    persona.registrarPersonas(epersonas);

                    MessageBox.Show("Registrado con exito");


                    FrmUsuarios usuarios = new FrmUsuarios();
                    usuarios.Show();
                    this.Hide();


                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin login= new FrmLogin();
            login.Show();
            this.Hide();
        }
    }
}
