namespace DESIGNER.Formularios
{
    partial class FrmVentas
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
            this.rbBoleta = new System.Windows.Forms.RadioButton();
            this.rdFactura = new System.Windows.Forms.RadioButton();
            this.BOLETA = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.txtdatos = new System.Windows.Forms.TextBox();
            this.lbldatos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.txtneto = new System.Windows.Forms.TextBox();
            this.txtigv = new System.Windows.Forms.TextBox();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.Descrpcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // rbBoleta
            // 
            this.rbBoleta.AutoSize = true;
            this.rbBoleta.Location = new System.Drawing.Point(1166, 90);
            this.rbBoleta.Margin = new System.Windows.Forms.Padding(4);
            this.rbBoleta.Name = "rbBoleta";
            this.rbBoleta.Size = new System.Drawing.Size(67, 21);
            this.rbBoleta.TabIndex = 0;
            this.rbBoleta.TabStop = true;
            this.rbBoleta.Text = "Boleta";
            this.rbBoleta.UseVisualStyleBackColor = true;
            this.rbBoleta.CheckedChanged += new System.EventHandler(this.rbBoleta_CheckedChanged);
            // 
            // rdFactura
            // 
            this.rdFactura.AutoSize = true;
            this.rdFactura.Location = new System.Drawing.Point(1368, 90);
            this.rdFactura.Margin = new System.Windows.Forms.Padding(4);
            this.rdFactura.Name = "rdFactura";
            this.rdFactura.Size = new System.Drawing.Size(75, 21);
            this.rdFactura.TabIndex = 1;
            this.rdFactura.TabStop = true;
            this.rdFactura.Text = "Factura";
            this.rdFactura.UseVisualStyleBackColor = true;
            this.rdFactura.CheckedChanged += new System.EventHandler(this.rdFactura_CheckedChanged);
            // 
            // BOLETA
            // 
            this.BOLETA.AutoSize = true;
            this.BOLETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOLETA.Location = new System.Drawing.Point(1239, 30);
            this.BOLETA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BOLETA.Name = "BOLETA";
            this.BOLETA.Size = new System.Drawing.Size(127, 31);
            this.BOLETA.TabIndex = 2;
            this.BOLETA.Text = "BOLETA";
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Location = new System.Drawing.Point(210, 141);
            this.lbldni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(31, 17);
            this.lbldni.TabIndex = 3;
            this.lbldni.Text = "DNI";
            // 
            // txtdatos
            // 
            this.txtdatos.Location = new System.Drawing.Point(626, 141);
            this.txtdatos.Margin = new System.Windows.Forms.Padding(4);
            this.txtdatos.Name = "txtdatos";
            this.txtdatos.Size = new System.Drawing.Size(317, 23);
            this.txtdatos.TabIndex = 5;
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.Location = new System.Drawing.Point(495, 147);
            this.lbldatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(124, 17);
            this.lbldatos.TabIndex = 7;
            this.lbldatos.Text = "Datos del Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(497, 239);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(624, 23);
            this.txtDescripcion.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1273, 191);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(181, 47);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(1273, 252);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(181, 47);
            this.btnReiniciar.TabIndex = 13;
            this.btnReiniciar.Text = "Réiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(498, 310);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(65, 23);
            this.txtStock.TabIndex = 14;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(678, 311);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(66, 23);
            this.txtPrecio.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(886, 286);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(675, 289);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Stock:";
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToDeleteRows = false;
            this.gridProductos.AllowUserToOrderColumns = true;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descrpcion,
            this.stock,
            this.Precio,
            this.cantidad,
            this.total});
            this.gridProductos.Location = new System.Drawing.Point(213, 353);
            this.gridProductos.Margin = new System.Windows.Forms.Padding(4);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.RowHeadersWidth = 62;
            this.gridProductos.Size = new System.Drawing.Size(1241, 278);
            this.gridProductos.TabIndex = 20;
            this.gridProductos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gridProductos_CellPainting);
            // 
            // txtneto
            // 
            this.txtneto.Location = new System.Drawing.Point(1374, 732);
            this.txtneto.Margin = new System.Windows.Forms.Padding(4);
            this.txtneto.Name = "txtneto";
            this.txtneto.Size = new System.Drawing.Size(80, 23);
            this.txtneto.TabIndex = 21;
            // 
            // txtigv
            // 
            this.txtigv.Location = new System.Drawing.Point(1374, 698);
            this.txtigv.Margin = new System.Windows.Forms.Padding(4);
            this.txtigv.Name = "txtigv";
            this.txtigv.Size = new System.Drawing.Size(80, 23);
            this.txtigv.TabIndex = 22;
            // 
            // txtsub
            // 
            this.txtsub.Location = new System.Drawing.Point(1374, 664);
            this.txtsub.Margin = new System.Windows.Forms.Padding(4);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(80, 23);
            this.txtsub.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1326, 735);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Neto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1331, 704);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "IGV:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1300, 667);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Subtotal:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(213, 819);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(432, 23);
            this.textBox10.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 788);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Usted está siendo atendida por:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1273, 801);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 41);
            this.button3.TabIndex = 29;
            this.button3.Text = "Finalizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1048, 801);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 41);
            this.button4.TabIndex = 30;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 24);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 23);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(889, 311);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(66, 23);
            this.numCantidad.TabIndex = 32;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("barcode font", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(213, 252);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(132, 57);
            this.txtBarcode.TabIndex = 33;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(248, 138);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(143, 23);
            this.txtdni.TabIndex = 34;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(248, 138);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(143, 23);
            this.txtruc.TabIndex = 35;
            this.txtruc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtruc_KeyPress);
            // 
            // txtempresa
            // 
            this.txtempresa.Location = new System.Drawing.Point(626, 141);
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(317, 23);
            this.txtempresa.TabIndex = 36;
            // 
            // Descrpcion
            // 
            this.Descrpcion.HeaderText = "Descripcion";
            this.Descrpcion.MinimumWidth = 8;
            this.Descrpcion.Name = "Descrpcion";
            this.Descrpcion.ReadOnly = true;
            this.Descrpcion.Width = 400;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 8;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 250;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 150;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 8;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 150;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 865);
            this.Controls.Add(this.txtempresa);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtsub);
            this.Controls.Add(this.txtigv);
            this.Controls.Add(this.txtneto);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbldatos);
            this.Controls.Add(this.txtdatos);
            this.Controls.Add(this.lbldni);
            this.Controls.Add(this.BOLETA);
            this.Controls.Add(this.rdFactura);
            this.Controls.Add(this.rbBoleta);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBoleta;
        private System.Windows.Forms.RadioButton rdFactura;
        private System.Windows.Forms.Label BOLETA;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.TextBox txtdatos;
        private System.Windows.Forms.Label lbldatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.TextBox txtneto;
        private System.Windows.Forms.TextBox txtigv;
        private System.Windows.Forms.TextBox txtsub;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.TextBox txtempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrpcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}