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
    public partial class FrmEmpresas : Form
    {


        Empresa empresa = new Empresa();
        Eempresa eempresa = new Eempresa();
        public FrmEmpresas()
        {
            InitializeComponent();
        }

        private DialogResult pregunta(string pregunta)
        {
            return MessageBox.Show(pregunta, "Sistema - registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtEmpresa.Text.Trim() != "" && txtruc.Text.Trim() != "" )
            {
                if (pregunta("¿Desea registrar una empresa?") == DialogResult.Yes)
                {
                    eempresa.nombre = txtEmpresa.Text;
                    eempresa.ruc = txtruc.Text;

                    empresa.registrarEmpresa(eempresa);

                    MessageBox.Show("Registrado con exito");

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Faltan Registrar Datos", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmEmpresas_Load(object sender, EventArgs e)
        {

        }
    }
}
