namespace CEE.Interfaz
{
    partial class FrmFinalizarPrestamo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinalizarPrestamo));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.groupBoxDetallePrestamo = new System.Windows.Forms.GroupBox();
            this.buttonDevolverParcial = new System.Windows.Forms.Button();
            this.buttonDevolverTodo = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.IdDetallePrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devolver = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBoxPrestamo = new System.Windows.Forms.GroupBox();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.IdPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEstimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPrincipal.SuspendLayout();
            this.groupBoxDetallePrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.groupBoxPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.groupBoxDetallePrestamo);
            this.panelPrincipal.Controls.Add(this.groupBoxPrestamo);
            this.panelPrincipal.Location = new System.Drawing.Point(12, 12);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(776, 485);
            this.panelPrincipal.TabIndex = 0;
            // 
            // groupBoxDetallePrestamo
            // 
            this.groupBoxDetallePrestamo.Controls.Add(this.buttonDevolverParcial);
            this.groupBoxDetallePrestamo.Controls.Add(this.buttonDevolverTodo);
            this.groupBoxDetallePrestamo.Controls.Add(this.dgvDetalles);
            this.groupBoxDetallePrestamo.Location = new System.Drawing.Point(3, 257);
            this.groupBoxDetallePrestamo.Name = "groupBoxDetallePrestamo";
            this.groupBoxDetallePrestamo.Size = new System.Drawing.Size(768, 223);
            this.groupBoxDetallePrestamo.TabIndex = 1;
            this.groupBoxDetallePrestamo.TabStop = false;
            this.groupBoxDetallePrestamo.Text = "Detalle del Prestamo";
            // 
            // buttonDevolverParcial
            // 
            this.buttonDevolverParcial.Location = new System.Drawing.Point(441, 198);
            this.buttonDevolverParcial.Name = "buttonDevolverParcial";
            this.buttonDevolverParcial.Size = new System.Drawing.Size(166, 23);
            this.buttonDevolverParcial.TabIndex = 17;
            this.buttonDevolverParcial.Text = "Devolucion de Seleccionados";
            this.buttonDevolverParcial.UseVisualStyleBackColor = true;
            this.buttonDevolverParcial.Click += new System.EventHandler(this.ButtonDevolverParcial_Click);
            // 
            // buttonDevolverTodo
            // 
            this.buttonDevolverTodo.Location = new System.Drawing.Point(638, 198);
            this.buttonDevolverTodo.Name = "buttonDevolverTodo";
            this.buttonDevolverTodo.Size = new System.Drawing.Size(130, 23);
            this.buttonDevolverTodo.TabIndex = 16;
            this.buttonDevolverTodo.Text = "Devolucion Completa";
            this.buttonDevolverTodo.UseVisualStyleBackColor = true;
            this.buttonDevolverTodo.Click += new System.EventHandler(this.ButtonDevolverTodo_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDetallePrestamo,
            this.IdEquipo,
            this.Codigo,
            this.NombreEquipo,
            this.IdTipoEquipo,
            this.TipoEquipo,
            this.Devolver});
            this.dgvDetalles.Location = new System.Drawing.Point(6, 19);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(756, 173);
            this.dgvDetalles.TabIndex = 15;
            // 
            // IdDetallePrestamo
            // 
            this.IdDetallePrestamo.HeaderText = "IdDetallePrestamo";
            this.IdDetallePrestamo.Name = "IdDetallePrestamo";
            this.IdDetallePrestamo.ReadOnly = true;
            this.IdDetallePrestamo.Visible = false;
            // 
            // IdEquipo
            // 
            this.IdEquipo.HeaderText = "IdEquipo";
            this.IdEquipo.Name = "IdEquipo";
            this.IdEquipo.ReadOnly = true;
            this.IdEquipo.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 150;
            // 
            // NombreEquipo
            // 
            this.NombreEquipo.HeaderText = "Nombre Equipo";
            this.NombreEquipo.Name = "NombreEquipo";
            this.NombreEquipo.ReadOnly = true;
            this.NombreEquipo.Width = 200;
            // 
            // IdTipoEquipo
            // 
            this.IdTipoEquipo.HeaderText = "IdTipoEquipo";
            this.IdTipoEquipo.Name = "IdTipoEquipo";
            this.IdTipoEquipo.ReadOnly = true;
            this.IdTipoEquipo.Visible = false;
            // 
            // TipoEquipo
            // 
            this.TipoEquipo.HeaderText = "Tipo Equipo";
            this.TipoEquipo.Name = "TipoEquipo";
            this.TipoEquipo.ReadOnly = true;
            this.TipoEquipo.Width = 200;
            // 
            // Devolver
            // 
            this.Devolver.HeaderText = "Devolver";
            this.Devolver.Name = "Devolver";
            this.Devolver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Devolver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBoxPrestamo
            // 
            this.groupBoxPrestamo.Controls.Add(this.dgvPrestamos);
            this.groupBoxPrestamo.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPrestamo.Name = "groupBoxPrestamo";
            this.groupBoxPrestamo.Size = new System.Drawing.Size(768, 248);
            this.groupBoxPrestamo.TabIndex = 0;
            this.groupBoxPrestamo.TabStop = false;
            this.groupBoxPrestamo.Text = "Prestamo";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPrestamo,
            this.IdPersona,
            this.NumeroDocumento,
            this.IdTipoDocumento,
            this.TipoDocumento,
            this.Apellido,
            this.Nombre,
            this.Legajo,
            this.FechaEstimada});
            this.dgvPrestamos.Location = new System.Drawing.Point(6, 19);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.Size = new System.Drawing.Size(756, 223);
            this.dgvPrestamos.TabIndex = 0;
            this.dgvPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPrestamos_CellClick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // IdPrestamo
            // 
            this.IdPrestamo.HeaderText = "IdPrestamo";
            this.IdPrestamo.Name = "IdPrestamo";
            this.IdPrestamo.ReadOnly = true;
            this.IdPrestamo.Visible = false;
            // 
            // IdPersona
            // 
            this.IdPersona.HeaderText = "IdPersona";
            this.IdPersona.Name = "IdPersona";
            this.IdPersona.ReadOnly = true;
            this.IdPersona.Visible = false;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 150;
            // 
            // IdTipoDocumento
            // 
            this.IdTipoDocumento.HeaderText = "IdTipoDocumento";
            this.IdTipoDocumento.Name = "IdTipoDocumento";
            this.IdTipoDocumento.ReadOnly = true;
            this.IdTipoDocumento.Visible = false;
            this.IdTipoDocumento.Width = 120;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 115;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 115;
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // FechaEstimada
            // 
            this.FechaEstimada.HeaderText = "Fecha Estimada";
            this.FechaEstimada.Name = "FechaEstimada";
            this.FechaEstimada.ReadOnly = true;
            this.FechaEstimada.Width = 130;
            // 
            // FrmFinalizarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFinalizarPrestamo";
            this.Text = "Finalizar Prestamo";
            this.Load += new System.EventHandler(this.FrmFinalizarPrestamo_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.groupBoxDetallePrestamo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.groupBoxPrestamo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBoxDetallePrestamo;
        private System.Windows.Forms.GroupBox groupBoxPrestamo;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button buttonDevolverParcial;
        private System.Windows.Forms.Button buttonDevolverTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetallePrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEquipo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Devolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEstimada;
    }
}