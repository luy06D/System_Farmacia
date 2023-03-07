using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;

namespace DESIGNER.Test
{
    public partial class FrmCodigo : Form
    {
        public FrmCodigo()
        {
            InitializeComponent();
        }

        public class OpcionesCombo
        {
            public int Valor { get; set; }
            public string Texto { get; set; }
        }

        private void FrmCodigo_Load(object sender, EventArgs e)
        {
            int indice = 0;
            foreach(var name in Enum.GetNames(typeof(BarcodeLib.TYPE)))
            {
                comboTipo.Items.Add(new OpcionesCombo() { Valor = indice, Texto = name });

                indice++;   
            }

            comboTipo.DisplayMember = "Texto";
            comboTipo.ValueMember = "Valor";
            comboTipo.SelectedIndex = 0;

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Image imgCodigo;

            int indice = (comboTipo.SelectedItem as OpcionesCombo).Valor;
            BarcodeLib.TYPE tipoCodigo = (BarcodeLib.TYPE)indice;

            Barcode codigo = new Barcode();
            codigo.IncludeLabel = true;
            codigo.LabelPosition = LabelPositions.BOTTOMCENTER;

            imgCodigo = codigo.Encode(tipoCodigo, txtnumCodigo.Text,
                                        Color.Black, Color.White, 300, 100);

            pictureCodigo.BackgroundImage = imgCodigo;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Image imgCodigo = pictureCodigo.BackgroundImage.Clone() as Image;

            SaveFileDialog ventanaDialogo = new SaveFileDialog();
            ventanaDialogo.FileName = String.Format("{0}.png", txtnumCodigo.Text);
            ventanaDialogo.Filter = "Imagen |*.png";

            if(ventanaDialogo.ShowDialog() == DialogResult.OK)
            {
                imgCodigo.Save(ventanaDialogo.FileName, ImageFormat.Png);
                MessageBox.Show("La imagen a sido guardada");
            }
        }
    }
}
