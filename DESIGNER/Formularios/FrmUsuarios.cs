using BOL;
using CryptSharp;
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
    public partial class FrmUsuarios : Form
    {
        Persona persona = new Persona();
        Epersonas epersonas = new Epersonas();
        Usuario usuario = new Usuario();
        Eusuarios eusuarios = new Eusuarios();
        
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private DialogResult pregunta(string pregunta)
        {
            return MessageBox.Show(pregunta, "Sistema - registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            gridPersonas.DataSource = persona.listarPersonas();
            gridPersonas.Refresh();

            
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(pregunta("¿Desea registrar al nuevo usuario")== DialogResult.Yes)
            {
                
                eusuarios.idpersona = Convert.ToInt32(txtIdpersona.Text);
                eusuarios.nomusuarios = txtNomusuario.Text;
                eusuarios.claveacceso = Crypter.Blowfish.Crypt(txtClaveacceso.Text);
                

                usuario.registrarUsuario(eusuarios.idpersona, eusuarios.nomusuarios, eusuarios.claveacceso);
                
                gridPersonas.DataSource = persona.listarPersonas();
                gridPersonas.Refresh();

                MessageBox.Show("Guardado correctamente");

                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();


            }
        }

        private void gridPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmLogin login  = new FrmLogin();
            login.Show();
            this.Hide();
        }
    }
}
