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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
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
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gridProductos = new System.Windows.Forms.DataGridView();


            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();


            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.txtneto = new System.Windows.Forms.TextBox();
            this.txtigv = new System.Windows.Forms.TextBox();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.txtempresa = new System.Windows.Forms.TextBox();

            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnd = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnregistrarP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbBoleta
            // 
            this.rbBoleta.AutoSize = true;
            this.rbBoleta.Checked = true;
            this.rbBoleta.Location = new System.Drawing.Point(993, 72);
            this.rbBoleta.Margin = new System.Windows.Forms.Padding(4);
            this.rbBoleta.Name = "rbBoleta";
            this.rbBoleta.Size = new System.Drawing.Size(98, 27);
            this.rbBoleta.TabIndex = 0;
            this.rbBoleta.TabStop = true;
            this.rbBoleta.Text = "Boleta";
            this.rbBoleta.UseVisualStyleBackColor = true;
            this.rbBoleta.CheckedChanged += new System.EventHandler(this.rbBoleta_CheckedChanged);
            // 
            // rdFactura
            // 
            this.rdFactura.AutoSize = true;
            this.rdFactura.Location = new System.Drawing.Point(1146, 72);
            this.rdFactura.Margin = new System.Windows.Forms.Padding(4);
            this.rdFactura.Name = "rdFactura";
            this.rdFactura.Size = new System.Drawing.Size(111, 27);
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
            this.BOLETA.Location = new System.Drawing.Point(1041, 19);
            this.BOLETA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BOLETA.Name = "BOLETA";
            this.BOLETA.Size = new System.Drawing.Size(187, 47);
            this.BOLETA.TabIndex = 2;
            this.BOLETA.Text = "BOLETA";
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Location = new System.Drawing.Point(570, 32);
            this.lbldni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(45, 23);
            this.lbldni.TabIndex = 3;
            this.lbldni.Text = "DNI";
            // 
            // txtdatos
            // 

            this.txtdatos.Location = new System.Drawing.Point(615, 87);


            this.txtdatos.Location = new System.Drawing.Point(679, 139);

            this.txtdatos.Margin = new System.Windows.Forms.Padding(4);
            this.txtdatos.Name = "txtdatos";
            this.txtdatos.Size = new System.Drawing.Size(317, 31);
            this.txtdatos.TabIndex = 5;
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.Location = new System.Drawing.Point(472, 93);
            this.lbldatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(185, 23);
            this.lbldatos.TabIndex = 7;
            this.lbldatos.Text = "Datos del Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";


            this.label3.Size = new System.Drawing.Size(89, 17);

            this.label3.Size = new System.Drawing.Size(144, 23);

            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(308, 57);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(624, 31);
            this.txtDescripcion.TabIndex = 11;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.Location = new System.Drawing.Point(1079, 108);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(142, 39);
            this.btnReiniciar.TabIndex = 13;
            this.btnReiniciar.Text = "Réiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(308, 115);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(65, 31);
            this.txtStock.TabIndex = 14;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(447, 115);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(66, 31);
            this.txtPrecio.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
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
            this.idproducto,
            this.cantidad,
            this.precioventa,
            this.unidad,
            this.total,
            this.btnEliminar});
            this.gridProductos.Location = new System.Drawing.Point(202, 391);
            this.gridProductos.Margin = new System.Windows.Forms.Padding(4);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.RowHeadersWidth = 62;
            this.gridProductos.Size = new System.Drawing.Size(1252, 278);
            this.gridProductos.TabIndex = 20;
            this.gridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellContentClick);
            this.gridProductos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gridProductos_CellPainting);
            // 

            // idproducto
            // 
            this.idproducto.HeaderText = "Descripcion";
            this.idproducto.MinimumWidth = 8;
            this.idproducto.Name = "idproducto";
            this.idproducto.ReadOnly = true;
            this.idproducto.Width = 400;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 8;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 150;
            // 
            // precioventa
            // 
            this.precioventa.HeaderText = "Precio";
            this.precioventa.MinimumWidth = 8;
            this.precioventa.Name = "precioventa";
            this.precioventa.ReadOnly = true;
            this.precioventa.Width = 150;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 70;
            // 
            // txtneto
            // 
            this.txtneto.Enabled = false;
            this.txtneto.Location = new System.Drawing.Point(1374, 755);
            this.txtneto.Margin = new System.Windows.Forms.Padding(4);
            this.txtneto.Name = "txtneto";
            this.txtneto.Size = new System.Drawing.Size(80, 23);
            this.txtneto.TabIndex = 21;
            // 
            // txtigv
            // 
            this.txtigv.Enabled = false;
            this.txtigv.Location = new System.Drawing.Point(1374, 721);
            this.txtigv.Margin = new System.Windows.Forms.Padding(4);
            this.txtigv.Name = "txtigv";
            this.txtigv.Size = new System.Drawing.Size(80, 23);
            this.txtigv.TabIndex = 22;
            // 
            // txtsub
            // 
            this.txtsub.Enabled = false;
            this.txtsub.Location = new System.Drawing.Point(1374, 687);
            this.txtsub.Margin = new System.Windows.Forms.Padding(4);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(80, 23);
            this.txtsub.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1326, 758);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Neto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1331, 727);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "IGV:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1300, 690);
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
            // lblUsuario

            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(210, 788);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 17);
            this.lblUsuario.TabIndex = 28;

            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(210, 788);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 17);
            this.lblUsuario.TabIndex = 28;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Location = new System.Drawing.Point(1273, 810);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(181, 41);
            this.btnFinalizar.TabIndex = 29;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(1061, 810);
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
            this.numCantidad.Location = new System.Drawing.Point(590, 115);
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
            this.txtBarcode.Location = new System.Drawing.Point(23, 80);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(132, 57);
            this.txtBarcode.TabIndex = 33;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(615, 27);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(143, 23);
            this.txtdni.TabIndex = 34;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(615, 27);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(143, 23);
            this.txtruc.TabIndex = 35;
            this.txtruc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtruc_KeyPress);
            // 
            // txtempresa
            // 
            this.txtempresa.Location = new System.Drawing.Point(615, 87);
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(317, 23);
            this.txtempresa.TabIndex = 36;
            // 
            // groupBox1

            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUnd);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.btnReiniciar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.numCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(202, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1252, 171);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "UNIDAD / BLISTER";
            // 
            // txtUnd
            // 
            this.txtUnd.Location = new System.Drawing.Point(730, 114);
            this.txtUnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnd.Name = "txtUnd";
            this.txtUnd.Size = new System.Drawing.Size(111, 23);
            this.txtUnd.TabIndex = 34;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(1079, 57);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 37);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnregistrarP
            // 

            this.btnregistrarP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrarP.BackgroundImage")));
            this.btnregistrarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnregistrarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrarP.Location = new System.Drawing.Point(309, 22);
            this.btnregistrarP.Name = "btnregistrarP";
            this.btnregistrarP.Size = new System.Drawing.Size(52, 28);
            this.btnregistrarP.TabIndex = 37;
            this.btnregistrarP.UseVisualStyleBackColor = true;
            this.btnregistrarP.Click += new System.EventHandler(this.btnregistrarP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnEmpresa);
            this.groupBox2.Controls.Add(this.txtruc);
            this.groupBox2.Controls.Add(this.txtdni);
            this.groupBox2.Controls.Add(this.btnregistrarP);
            this.groupBox2.Controls.Add(this.lbldatos);
            this.groupBox2.Controls.Add(this.lbldni);
            this.groupBox2.Controls.Add(this.txtdatos);
            this.groupBox2.Controls.Add(this.txtempresa);
            this.groupBox2.Controls.Add(this.BOLETA);
            this.groupBox2.Controls.Add(this.rbBoleta);
            this.groupBox2.Controls.Add(this.rdFactura);
            this.groupBox2.Location = new System.Drawing.Point(202, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1252, 133);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion del cliente";
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmpresa.BackgroundImage")));
            this.btnEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresa.Location = new System.Drawing.Point(309, 82);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(52, 28);
            this.btnEmpresa.TabIndex = 38;
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nueva cliente";

            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 8;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 150;
            // 
            // txtneto
            // 
            this.txtneto.Location = new System.Drawing.Point(1374, 732);
            this.txtneto.Margin = new System.Windows.Forms.Padding(4);
            this.txtneto.Name = "txtneto";
            this.txtneto.Size = new System.Drawing.Size(80, 31);
            this.txtneto.TabIndex = 21;
            // 
            // txtigv
            // 
            this.txtigv.Location = new System.Drawing.Point(1374, 698);
            this.txtigv.Margin = new System.Windows.Forms.Padding(4);
            this.txtigv.Name = "txtigv";
            this.txtigv.Size = new System.Drawing.Size(80, 31);
            this.txtigv.TabIndex = 22;
            // 
            // txtsub
            // 
            this.txtsub.Location = new System.Drawing.Point(1374, 664);
            this.txtsub.Margin = new System.Windows.Forms.Padding(4);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(80, 31);
            this.txtsub.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1326, 735);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Neto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1331, 704);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "IGV:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1300, 667);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "Subtotal:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(213, 819);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(432, 31);
            this.textBox10.TabIndex = 27;

            // 
            // label12
            // 
            this.label12.AutoSize = true;

            this.label12.Location = new System.Drawing.Point(210, 788);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(323, 23);
            this.label12.TabIndex = 28;
            this.label12.Text = "Usted está siendo atendida por:";

            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Location = new System.Drawing.Point(1273, 810);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(181, 41);
            this.btnFinalizar.TabIndex = 29;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(1061, 810);
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
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 31);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(590, 115);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(66, 31);
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
            this.txtBarcode.Location = new System.Drawing.Point(23, 80);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(132, 81);
            this.txtBarcode.TabIndex = 33;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // txtdni
            // 

            this.txtdni.Location = new System.Drawing.Point(248, 138);
            this.txtdni.MaxLength = 8;

            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(143, 31);
            this.txtdni.TabIndex = 34;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // txtruc
            // 

            this.txtruc.Location = new System.Drawing.Point(248, 139);
            this.txtruc.MaxLength = 11;

            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(143, 31);
            this.txtruc.TabIndex = 35;
            this.txtruc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtruc_KeyPress);
            // 
            // txtempresa
            // 

            this.txtempresa.Location = new System.Drawing.Point(678, 141);

            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(317, 31);
            this.txtempresa.TabIndex = 36;

            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUnd);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.btnReiniciar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.numCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(202, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1252, 171);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "UNIDAD / BLISTER";
            // 
            // txtUnd
            // 
            this.txtUnd.Location = new System.Drawing.Point(730, 114);
            this.txtUnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnd.Name = "txtUnd";
            this.txtUnd.Size = new System.Drawing.Size(111, 23);
            this.txtUnd.TabIndex = 34;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(1079, 57);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 37);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnregistrarP
            // 
            this.btnregistrarP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrarP.BackgroundImage")));
            this.btnregistrarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnregistrarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrarP.Location = new System.Drawing.Point(309, 22);
            this.btnregistrarP.Name = "btnregistrarP";
            this.btnregistrarP.Size = new System.Drawing.Size(52, 28);
            this.btnregistrarP.TabIndex = 37;
            this.btnregistrarP.UseVisualStyleBackColor = true;
            this.btnregistrarP.Click += new System.EventHandler(this.btnregistrarP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnEmpresa);
            this.groupBox2.Controls.Add(this.txtruc);
            this.groupBox2.Controls.Add(this.txtdni);
            this.groupBox2.Controls.Add(this.btnregistrarP);
            this.groupBox2.Controls.Add(this.lbldatos);
            this.groupBox2.Controls.Add(this.lbldni);
            this.groupBox2.Controls.Add(this.txtdatos);
            this.groupBox2.Controls.Add(this.txtempresa);
            this.groupBox2.Controls.Add(this.BOLETA);
            this.groupBox2.Controls.Add(this.rbBoleta);
            this.groupBox2.Controls.Add(this.rdFactura);
            this.groupBox2.Location = new System.Drawing.Point(202, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1252, 133);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion del cliente";
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmpresa.BackgroundImage")));
            this.btnEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresa.Location = new System.Drawing.Point(309, 82);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(52, 28);
            this.btnEmpresa.TabIndex = 38;
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nueva cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(190, 93);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 40;
            this.label12.Text = "Nueva empresa";

            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1547, 865);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtsub);
            this.Controls.Add(this.txtigv);
            this.Controls.Add(this.txtneto);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
  
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.TextBox txtempresa;
        private System.Windows.Forms.Button btnregistrarP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
    }
}