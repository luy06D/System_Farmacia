namespace DESIGNER.Formularios
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtfechaproduccion = new System.Windows.Forms.TextBox();
            this.txtnumlote = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtvencimiento = new System.Windows.Forms.TextBox();
            this.txtrecetamedica = new System.Windows.Forms.TextBox();
            this.btnreiniciar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar un nuevo Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "F.Producción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 313);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "N.lote:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripcion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 250);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "F.Vencimiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(523, 313);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "R.Medica:";
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(283, 108);
            this.txtnombreproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(132, 22);
            this.txtnombreproducto.TabIndex = 9;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(283, 172);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(132, 22);
            this.txtcantidad.TabIndex = 10;
            // 
            // txtfechaproduccion
            // 
            this.txtfechaproduccion.Location = new System.Drawing.Point(283, 241);
            this.txtfechaproduccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtfechaproduccion.Name = "txtfechaproduccion";
            this.txtfechaproduccion.Size = new System.Drawing.Size(132, 22);
            this.txtfechaproduccion.TabIndex = 11;
            // 
            // txtnumlote
            // 
            this.txtnumlote.Location = new System.Drawing.Point(283, 304);
            this.txtnumlote.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumlote.Name = "txtnumlote";
            this.txtnumlote.Size = new System.Drawing.Size(132, 22);
            this.txtnumlote.TabIndex = 12;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(646, 108);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(132, 22);
            this.txtdescripcion.TabIndex = 13;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(646, 177);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(132, 22);
            this.txtprecio.TabIndex = 14;
            // 
            // txtvencimiento
            // 
            this.txtvencimiento.Location = new System.Drawing.Point(646, 243);
            this.txtvencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtvencimiento.Name = "txtvencimiento";
            this.txtvencimiento.Size = new System.Drawing.Size(132, 22);
            this.txtvencimiento.TabIndex = 15;
            // 
            // txtrecetamedica
            // 
            this.txtrecetamedica.Location = new System.Drawing.Point(646, 304);
            this.txtrecetamedica.Margin = new System.Windows.Forms.Padding(4);
            this.txtrecetamedica.Name = "txtrecetamedica";
            this.txtrecetamedica.Size = new System.Drawing.Size(132, 22);
            this.txtrecetamedica.TabIndex = 16;
            // 
            // btnreiniciar
            // 
            this.btnreiniciar.Location = new System.Drawing.Point(259, 420);
            this.btnreiniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnreiniciar.Name = "btnreiniciar";
            this.btnreiniciar.Size = new System.Drawing.Size(141, 58);
            this.btnreiniciar.TabIndex = 17;
            this.btnreiniciar.Text = "Reiniciar";
            this.btnreiniciar.UseVisualStyleBackColor = true;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(615, 420);
            this.btnregistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(133, 58);
            this.btnregistrar.TabIndex = 18;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(49, 533);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.RowHeadersWidth = 51;
            this.gridProductos.RowTemplate.Height = 24;
            this.gridProductos.Size = new System.Drawing.Size(883, 328);
            this.gridProductos.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 363);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "barcode";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(283, 363);
            this.txtbarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(132, 22);
            this.txtbarcode.TabIndex = 24;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 885);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btnreiniciar);
            this.Controls.Add(this.txtrecetamedica);
            this.Controls.Add(this.txtvencimiento);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnumlote);
            this.Controls.Add(this.txtfechaproduccion);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtnombreproducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtfechaproduccion;
        private System.Windows.Forms.TextBox txtnumlote;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtvencimiento;
        private System.Windows.Forms.TextBox txtrecetamedica;
        private System.Windows.Forms.Button btnreiniciar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbarcode;
    }
}