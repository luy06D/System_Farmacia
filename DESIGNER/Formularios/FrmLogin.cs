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
using CryptSharp;
using ENTITIES;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DESIGNER.Formularios
{
    public partial class FrmLogin : Form
    {
        Usuario usuario = new Usuario();
        Eusuarios eusuarios = new Eusuarios();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DataTable result = new DataTable();
            eusuarios.nomusuarios = txtUsuario.Text;
            eusuarios.claveacceso = txtContraseña.Text;

            result = usuario.iniciarSesion(eusuarios);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            eusuarios.nomusuarios = txtUsuario.Text;
            eusuarios.claveacceso = txtContraseña.Text;

            resultado = usuario.iniciarSesion(eusuarios);

            if (resultado.Rows.Count > 0)
            {
                string claveEncriptada = resultado.Rows[0][3].ToString();
                bool login = Crypter.CheckPassword(eusuarios.claveacceso, claveEncriptada);

                if (login)
                {

                    Ventana_Inicio inicio = new Ventana_Inicio();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                    txtContraseña.Clear();
                }
            }
            else
            {
                MessageBox.Show("No existe el usuario" + " " + eusuarios);
                txtUsuario.Clear();
                txtContraseña.Clear() ;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            txtContraseña.PasswordChar = '*';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            txtContraseña.PasswordChar = '\0';
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
