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

namespace DESIGNER.Formularios
{
    public partial class FrmLogin : Form
    {
        Usuario usuario = new Usuario();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DataTable result = new DataTable();
            string nombreUsuario = txtUsuario.Text;
            string clave = txtContraseña.Text;

            result = usuario.iniciarSesion(nombreUsuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            string nombreUsuario = txtUsuario.Text;
            string claveAcceso = txtContraseña.Text;

            resultado = usuario.iniciarSesion(nombreUsuario);

            if (resultado.Rows.Count > 0)
            {
                string claveEncriptada = resultado.Rows[0][3].ToString();
                bool login = Crypter.CheckPassword(claveAcceso, claveEncriptada);

                if (login)
                {
                    FrmVentas frmVentas = new FrmVentas();
                    frmVentas.Show();
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
                MessageBox.Show("No existe el usuario" + " " + nombreUsuario);
                txtUsuario.Clear();
                txtContraseña.Clear() ;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            txtContraseña.PasswordChar = '*';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            txtContraseña.PasswordChar = '\0';
        }
    }
}
