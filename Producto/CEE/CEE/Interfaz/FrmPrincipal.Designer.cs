namespace CEE.Interfaz
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Personas = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InicioPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.FinPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Equipos = new System.Windows.Forms.ToolStripMenuItem();
            this.TiposEquipos = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panel1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(800, 450);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.prestamosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Personas,
            this.ConsultarPersonas});
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.personasToolStripMenuItem.Text = "Personas";
            // 
            // Personas
            // 
            this.Personas.Enabled = false;
            this.Personas.Name = "Personas";
            this.Personas.Size = new System.Drawing.Size(175, 22);
            this.Personas.Text = "Gestionar Personas";
            this.Personas.Click += new System.EventHandler(this.Personas_Click);
            // 
            // ConsultarPersonas
            // 
            this.ConsultarPersonas.Enabled = false;
            this.ConsultarPersonas.Name = "ConsultarPersonas";
            this.ConsultarPersonas.Size = new System.Drawing.Size(175, 22);
            this.ConsultarPersonas.Text = "Consultar Personas";
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InicioPrestamos,
            this.FinPrestamos,
            this.ConsultarPrestamos});
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // InicioPrestamos
            // 
            this.InicioPrestamos.Enabled = false;
            this.InicioPrestamos.Name = "InicioPrestamos";
            this.InicioPrestamos.Size = new System.Drawing.Size(183, 22);
            this.InicioPrestamos.Text = "Iniciar Prestamos";
            // 
            // FinPrestamos
            // 
            this.FinPrestamos.Enabled = false;
            this.FinPrestamos.Name = "FinPrestamos";
            this.FinPrestamos.Size = new System.Drawing.Size(183, 22);
            this.FinPrestamos.Text = "Finalizar Prestamos";
            // 
            // ConsultarPrestamos
            // 
            this.ConsultarPrestamos.Enabled = false;
            this.ConsultarPrestamos.Name = "ConsultarPrestamos";
            this.ConsultarPrestamos.Size = new System.Drawing.Size(183, 22);
            this.ConsultarPrestamos.Text = "Consultar Prestamos";
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Equipos,
            this.TiposEquipos});
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.equiposToolStripMenuItem.Text = "Equipos";
            // 
            // Equipos
            // 
            this.Equipos.Enabled = false;
            this.Equipos.Name = "Equipos";
            this.Equipos.Size = new System.Drawing.Size(216, 22);
            this.Equipos.Text = "Gestionar Equipos";
            this.Equipos.Click += new System.EventHandler(this.Equipos_Click);
            // 
            // TiposEquipos
            // 
            this.TiposEquipos.Enabled = false;
            this.TiposEquipos.Name = "TiposEquipos";
            this.TiposEquipos.Size = new System.Drawing.Size(216, 22);
            this.TiposEquipos.Text = "Gestionar Tipos de Equipos";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "FrmPrincipal";
            this.Text = "CEE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Personas;
        private System.Windows.Forms.ToolStripMenuItem ConsultarPersonas;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InicioPrestamos;
        private System.Windows.Forms.ToolStripMenuItem FinPrestamos;
        private System.Windows.Forms.ToolStripMenuItem ConsultarPrestamos;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Equipos;
        private System.Windows.Forms.ToolStripMenuItem TiposEquipos;
    }
}

