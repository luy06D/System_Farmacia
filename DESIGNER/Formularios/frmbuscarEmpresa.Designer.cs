namespace DESIGNER.Formularios
{
    partial class frmbuscarEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbuscarEmpresa));
            this.label3 = new System.Windows.Forms.Label();
            this.gridEmpresa = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtBuscadorEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pulse doble clic sobre el registro para enviarlo a la venta";
            // 
            // gridEmpresa
            // 
            this.gridEmpresa.AllowUserToAddRows = false;
            this.gridEmpresa.AllowUserToDeleteRows = false;
            this.gridEmpresa.AllowUserToResizeRows = false;
            this.gridEmpresa.BackgroundColor = System.Drawing.Color.White;
            this.gridEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpresa.Location = new System.Drawing.Point(44, 147);
            this.gridEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.gridEmpresa.MultiSelect = false;
            this.gridEmpresa.Name = "gridEmpresa";
            this.gridEmpresa.ReadOnly = true;
            this.gridEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmpresa.Size = new System.Drawing.Size(754, 337);
            this.gridEmpresa.TabIndex = 13;
            this.gridEmpresa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmpresa_CellDoubleClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(653, 511);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(145, 39);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtBuscadorEmpresa
            // 
            this.txtBuscadorEmpresa.Location = new System.Drawing.Point(252, 29);
            this.txtBuscadorEmpresa.Name = "txtBuscadorEmpresa";
            this.txtBuscadorEmpresa.Size = new System.Drawing.Size(418, 23);
            this.txtBuscadorEmpresa.TabIndex = 15;
            this.txtBuscadorEmpresa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscadorEmpresa_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingrese el RUC de la empresa:";
            // 
            // frmbuscarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 574);
            this.Controls.Add(this.txtBuscadorEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridEmpresa);
            this.Controls.Add(this.btnCerrar);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmbuscarEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador de empresa";
            this.Load += new System.EventHandler(this.frmbuscarEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridEmpresa;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.TextBox txtBuscadorEmpresa;
        private System.Windows.Forms.Label label1;
    }
}