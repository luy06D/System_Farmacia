namespace DESIGNER.Encriptar
{
    partial class Encriptado
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
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtEncriptado = new System.Windows.Forms.TextBox();
            this.txtIngresada = new System.Windows.Forms.TextBox();
            this.txtValidaracceso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave Encriptada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave Ingresada";
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEncriptar.Location = new System.Drawing.Point(201, 63);
            this.btnEncriptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(88, 27);
            this.btnEncriptar.TabIndex = 3;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = false;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(55, 63);
            this.txtOriginal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(116, 21);
            this.txtOriginal.TabIndex = 4;
            // 
            // txtEncriptado
            // 
            this.txtEncriptado.Location = new System.Drawing.Point(55, 144);
            this.txtEncriptado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEncriptado.Name = "txtEncriptado";
            this.txtEncriptado.Size = new System.Drawing.Size(355, 21);
            this.txtEncriptado.TabIndex = 5;
            // 
            // txtIngresada
            // 
            this.txtIngresada.Location = new System.Drawing.Point(59, 220);
            this.txtIngresada.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIngresada.Name = "txtIngresada";
            this.txtIngresada.Size = new System.Drawing.Size(116, 21);
            this.txtIngresada.TabIndex = 6;
            // 
            // txtValidaracceso
            // 
            this.txtValidaracceso.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtValidaracceso.Location = new System.Drawing.Point(55, 269);
            this.txtValidaracceso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValidaracceso.Name = "txtValidaracceso";
            this.txtValidaracceso.Size = new System.Drawing.Size(151, 27);
            this.txtValidaracceso.TabIndex = 7;
            this.txtValidaracceso.Text = "Validar el acceso";
            this.txtValidaracceso.UseVisualStyleBackColor = false;
            this.txtValidaracceso.Click += new System.EventHandler(this.txtValidaracceso_Click);
            // 
            // Encriptado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.txtValidaracceso);
            this.Controls.Add(this.txtIngresada);
            this.Controls.Add(this.txtEncriptado);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Encriptado";
            this.Text = "Encriptar";
            this.Load += new System.EventHandler(this.Encriptado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.TextBox txtEncriptado;
        private System.Windows.Forms.TextBox txtIngresada;
        private System.Windows.Forms.Button txtValidaracceso;
    }
}