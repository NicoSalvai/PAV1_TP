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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.buttonCambioPassword = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Personas = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.asociacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Equipos = new System.Windows.Forms.ToolStripMenuItem();
            this.TiposEquipos = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InicioPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.FinPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarPerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoPrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDemorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel1.Controls.Add(this.buttonCerrarSesion);
            this.panel1.Controls.Add(this.buttonCambioPassword);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 1;
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.Location = new System.Drawing.Point(3, 56);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(124, 23);
            this.buttonCerrarSesion.TabIndex = 3;
            this.buttonCerrarSesion.Text = "Cerrar Sesion";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.ButtonCerrarSesion_Click);
            // 
            // buttonCambioPassword
            // 
            this.buttonCambioPassword.Location = new System.Drawing.Point(3, 27);
            this.buttonCambioPassword.Name = "buttonCambioPassword";
            this.buttonCambioPassword.Size = new System.Drawing.Size(124, 23);
            this.buttonCambioPassword.TabIndex = 2;
            this.buttonCambioPassword.Text = "Cambiar Contraseña";
            this.buttonCambioPassword.UseVisualStyleBackColor = true;
            this.buttonCambioPassword.Click += new System.EventHandler(this.ButtonCambioPassword_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.inscripcionesToolStripMenuItem,
            this.articulosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.reportesToolStripMenuItem});
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
            this.ConsultarPersonas,
            this.asociacionesToolStripMenuItem});
            this.personasToolStripMenuItem.Enabled = false;
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.personasToolStripMenuItem.Text = "Personas";
            this.personasToolStripMenuItem.Visible = false;
            // 
            // Personas
            // 
            this.Personas.Enabled = false;
            this.Personas.Name = "Personas";
            this.Personas.Size = new System.Drawing.Size(175, 22);
            this.Personas.Text = "Gestionar Personas";
            this.Personas.Visible = false;
            this.Personas.Click += new System.EventHandler(this.Personas_Click);
            // 
            // ConsultarPersonas
            // 
            this.ConsultarPersonas.Enabled = false;
            this.ConsultarPersonas.Name = "ConsultarPersonas";
            this.ConsultarPersonas.Size = new System.Drawing.Size(175, 22);
            this.ConsultarPersonas.Text = "Consultar Personas";
            this.ConsultarPersonas.Visible = false;
            // 
            // asociacionesToolStripMenuItem
            // 
            this.asociacionesToolStripMenuItem.Enabled = false;
            this.asociacionesToolStripMenuItem.Name = "asociacionesToolStripMenuItem";
            this.asociacionesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.asociacionesToolStripMenuItem.Text = "Asociaciones";
            this.asociacionesToolStripMenuItem.Visible = false;
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Equipos,
            this.TiposEquipos});
            this.equiposToolStripMenuItem.Enabled = false;
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.equiposToolStripMenuItem.Text = "Equipos";
            this.equiposToolStripMenuItem.Visible = false;
            // 
            // Equipos
            // 
            this.Equipos.Enabled = false;
            this.Equipos.Name = "Equipos";
            this.Equipos.Size = new System.Drawing.Size(216, 22);
            this.Equipos.Text = "Gestionar Equipos";
            this.Equipos.Visible = false;
            this.Equipos.Click += new System.EventHandler(this.Equipos_Click);
            // 
            // TiposEquipos
            // 
            this.TiposEquipos.Enabled = false;
            this.TiposEquipos.Name = "TiposEquipos";
            this.TiposEquipos.Size = new System.Drawing.Size(216, 22);
            this.TiposEquipos.Text = "Gestionar Tipos de Equipos";
            this.TiposEquipos.Visible = false;
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InicioPrestamos,
            this.FinPrestamos,
            this.ConsultarPrestamos});
            this.prestamosToolStripMenuItem.Enabled = false;
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            this.prestamosToolStripMenuItem.Visible = false;
            // 
            // InicioPrestamos
            // 
            this.InicioPrestamos.Enabled = false;
            this.InicioPrestamos.Name = "InicioPrestamos";
            this.InicioPrestamos.Size = new System.Drawing.Size(183, 22);
            this.InicioPrestamos.Text = "Iniciar Prestamos";
            this.InicioPrestamos.Visible = false;
            this.InicioPrestamos.Click += new System.EventHandler(this.InicioPrestamos_Click);
            // 
            // FinPrestamos
            // 
            this.FinPrestamos.Enabled = false;
            this.FinPrestamos.Name = "FinPrestamos";
            this.FinPrestamos.Size = new System.Drawing.Size(183, 22);
            this.FinPrestamos.Text = "Finalizar Prestamos";
            this.FinPrestamos.Visible = false;
            this.FinPrestamos.Click += new System.EventHandler(this.FinPrestamos_Click);
            // 
            // ConsultarPrestamos
            // 
            this.ConsultarPrestamos.Enabled = false;
            this.ConsultarPrestamos.Name = "ConsultarPrestamos";
            this.ConsultarPrestamos.Size = new System.Drawing.Size(183, 22);
            this.ConsultarPrestamos.Text = "Consultar Prestamos";
            this.ConsultarPrestamos.Visible = false;
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarCursosToolStripMenuItem});
            this.cursosToolStripMenuItem.Enabled = false;
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Visible = false;
            // 
            // gestionarCursosToolStripMenuItem
            // 
            this.gestionarCursosToolStripMenuItem.Enabled = false;
            this.gestionarCursosToolStripMenuItem.Name = "gestionarCursosToolStripMenuItem";
            this.gestionarCursosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.gestionarCursosToolStripMenuItem.Text = "Gestionar Cursos";
            this.gestionarCursosToolStripMenuItem.Visible = false;
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.Enabled = false;
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.inscripcionesToolStripMenuItem.Text = "Inscripciones";
            this.inscripcionesToolStripMenuItem.Visible = false;
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarArticulosToolStripMenuItem});
            this.articulosToolStripMenuItem.Enabled = false;
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Visible = false;
            // 
            // gestionarArticulosToolStripMenuItem
            // 
            this.gestionarArticulosToolStripMenuItem.Enabled = false;
            this.gestionarArticulosToolStripMenuItem.Name = "gestionarArticulosToolStripMenuItem";
            this.gestionarArticulosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gestionarArticulosToolStripMenuItem.Text = "Gestionar Articulos";
            this.gestionarArticulosToolStripMenuItem.Visible = false;
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Enabled = false;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Visible = false;
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarUsuariosToolStripMenuItem,
            this.gestionarPerfilesToolStripMenuItem});
            this.usuariosToolStripMenuItem.Enabled = false;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Visible = false;
            // 
            // gestionarUsuariosToolStripMenuItem
            // 
            this.gestionarUsuariosToolStripMenuItem.Enabled = false;
            this.gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            this.gestionarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gestionarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios";
            this.gestionarUsuariosToolStripMenuItem.Visible = false;
            this.gestionarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.GestionarUsuariosToolStripMenuItem_Click);
            // 
            // gestionarPerfilesToolStripMenuItem
            // 
            this.gestionarPerfilesToolStripMenuItem.Enabled = false;
            this.gestionarPerfilesToolStripMenuItem.Name = "gestionarPerfilesToolStripMenuItem";
            this.gestionarPerfilesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gestionarPerfilesToolStripMenuItem.Text = "Gestionar Perfiles";
            this.gestionarPerfilesToolStripMenuItem.Visible = false;
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReportesToolStripMenuItem,
            this.listadoPrestamosToolStripMenuItem,
            this.reporteDemorasToolStripMenuItem});
            this.reportesToolStripMenuItem.Enabled = false;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Visible = false;
            // 
            // generarReportesToolStripMenuItem
            // 
            this.generarReportesToolStripMenuItem.Enabled = false;
            this.generarReportesToolStripMenuItem.Name = "generarReportesToolStripMenuItem";
            this.generarReportesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generarReportesToolStripMenuItem.Text = "Generar Reportes";
            this.generarReportesToolStripMenuItem.Visible = false;
            this.generarReportesToolStripMenuItem.Click += new System.EventHandler(this.GenerarReportesToolStripMenuItem_Click);
            // 
            // listadoPrestamosToolStripMenuItem
            // 
            this.listadoPrestamosToolStripMenuItem.Name = "listadoPrestamosToolStripMenuItem";
            this.listadoPrestamosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoPrestamosToolStripMenuItem.Text = "Listado Prestamos";
            this.listadoPrestamosToolStripMenuItem.Click += new System.EventHandler(this.ListadoPrestamosToolStripMenuItem_Click);
            // 
            // reporteDemorasToolStripMenuItem
            // 
            this.reporteDemorasToolStripMenuItem.Name = "reporteDemorasToolStripMenuItem";
            this.reporteDemorasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteDemorasToolStripMenuItem.Text = "Reporte Demoras";
            this.reporteDemorasToolStripMenuItem.Click += new System.EventHandler(this.ReporteDemorasToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.ToolStripMenuItem asociacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarPerfilesToolStripMenuItem;
        private System.Windows.Forms.Button buttonCambioPassword;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoPrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDemorasToolStripMenuItem;
    }
}

