namespace CEE.Interfaz
{
    partial class FrmLogin
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
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPerfil = new System.Windows.Forms.DataGridView();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.IdPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PadreMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.panelPerfil.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUsuario
            // 
            this.panelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsuario.CausesValidation = false;
            this.panelUsuario.Controls.Add(this.buttonBuscar);
            this.panelUsuario.Controls.Add(this.dgvUsuario);
            this.panelUsuario.Location = new System.Drawing.Point(12, 13);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(626, 155);
            this.panelUsuario.TabIndex = 0;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.NombreUsuario,
            this.Pass});
            this.dgvUsuario.Location = new System.Drawing.Point(3, 4);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(611, 111);
            this.dgvUsuario.TabIndex = 0;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuario_CellClick);
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "NombreUsuario";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            // 
            // Pass
            // 
            this.Pass.HeaderText = "Pass";
            this.Pass.Name = "Pass";
            this.Pass.ReadOnly = true;
            // 
            // panelPerfil
            // 
            this.panelPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPerfil.Controls.Add(this.dgvPerfil);
            this.panelPerfil.Location = new System.Drawing.Point(12, 174);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(626, 155);
            this.panelPerfil.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.dgvMenu);
            this.panelMenu.Location = new System.Drawing.Point(12, 335);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(626, 164);
            this.panelMenu.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panelUsuario);
            this.panel2.Controls.Add(this.panelMenu);
            this.panel2.Controls.Add(this.panelPerfil);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 511);
            this.panel2.TabIndex = 1;
            // 
            // dgvPerfil
            // 
            this.dgvPerfil.AllowUserToAddRows = false;
            this.dgvPerfil.AllowUserToDeleteRows = false;
            this.dgvPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPerfil,
            this.NombrePerfil,
            this.Descripcion,
            this.FechaAlta,
            this.FechaBaja});
            this.dgvPerfil.Location = new System.Drawing.Point(3, 3);
            this.dgvPerfil.Name = "dgvPerfil";
            this.dgvPerfil.ReadOnly = true;
            this.dgvPerfil.Size = new System.Drawing.Size(611, 111);
            this.dgvPerfil.TabIndex = 1;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMenu,
            this.PadreMenu,
            this.NombreMenu,
            this.EsFinal,
            this.Aplicacion});
            this.dgvMenu.Location = new System.Drawing.Point(3, 3);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.Size = new System.Drawing.Size(611, 129);
            this.dgvMenu.TabIndex = 2;
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMenu_CellClick);
            // 
            // IdPerfil
            // 
            this.IdPerfil.HeaderText = "IdPerfil";
            this.IdPerfil.Name = "IdPerfil";
            this.IdPerfil.ReadOnly = true;
            // 
            // NombrePerfil
            // 
            this.NombrePerfil.HeaderText = "NombrePerfil";
            this.NombrePerfil.Name = "NombrePerfil";
            this.NombrePerfil.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // FechaAlta
            // 
            this.FechaAlta.HeaderText = "FechaAlta";
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.ReadOnly = true;
            // 
            // FechaBaja
            // 
            this.FechaBaja.HeaderText = "FechaBaja";
            this.FechaBaja.Name = "FechaBaja";
            this.FechaBaja.ReadOnly = true;
            // 
            // IdMenu
            // 
            this.IdMenu.HeaderText = "IdMenu";
            this.IdMenu.Name = "IdMenu";
            this.IdMenu.ReadOnly = true;
            // 
            // PadreMenu
            // 
            this.PadreMenu.HeaderText = "PadreMenu";
            this.PadreMenu.Name = "PadreMenu";
            this.PadreMenu.ReadOnly = true;
            // 
            // NombreMenu
            // 
            this.NombreMenu.HeaderText = "NombreMenu";
            this.NombreMenu.Name = "NombreMenu";
            this.NombreMenu.ReadOnly = true;
            // 
            // EsFinal
            // 
            this.EsFinal.HeaderText = "EsFinal";
            this.EsFinal.Name = "EsFinal";
            this.EsFinal.ReadOnly = true;
            // 
            // Aplicacion
            // 
            this.Aplicacion.HeaderText = "Aplicacino";
            this.Aplicacion.Name = "Aplicacion";
            this.Aplicacion.ReadOnly = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(539, 121);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 511);
            this.Controls.Add(this.panel2);
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panelUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.panelPerfil.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPerfil;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn PadreMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aplicacion;
        private System.Windows.Forms.Button buttonBuscar;
    }
}