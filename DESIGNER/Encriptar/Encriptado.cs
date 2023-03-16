using CryptSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER.Encriptar
{
    public partial class Encriptado : Form
    {
        public Encriptado()
        {
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            string clave = txtIngresada.Text;
            string claveEncriptar = Crypter.Blowfish.Crypt(clave);
            txtEncriptado.Text = claveEncriptar;
        }

        private void txtValidaracceso_Click(object sender, EventArgs e)
        {
            string claveIngresada = txtIngresada.Text;
            bool login = Crypter.CheckPassword(claveIngresada, txtEncriptado.Text);
            if (login)
            {
                MessageBox.Show("Acceso permitido");
            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }
        }

        private void Encriptado_Load(object sender, EventArgs e)
        {

        }
    }
}