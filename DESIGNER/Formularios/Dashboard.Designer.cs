namespace DESIGNER.Formularios
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnVentas = new System.Windows.Forms.ToolStripButton();
            this.btnProductos = new System.Windows.Forms.ToolStripButton();
            this.btnInventario = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(9, 2, 8, 2);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVentas,
            this.btnProductos,
            this.btnInventario});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // btnVentas
            // 
            resources.ApplyResources(this.btnVentas, "btnVentas");
            this.btnVentas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProductos
            // 
            resources.ApplyResources(this.btnProductos, "btnProductos");
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnInventario
            // 
            resources.ApplyResources(this.btnInventario, "btnInventario");
            this.btnInventario.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnVentas;
        private System.Windows.Forms.ToolStripButton btnProductos;
        private System.Windows.Forms.ToolStripButton btnInventario;
        private System.Windows.Forms.Label label1;
    }
}