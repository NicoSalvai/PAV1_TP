namespace CEE.Interfaz
{
    partial class FrmInicioPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioPrestamos));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.labelTipoDocumento = new System.Windows.Forms.Label();
            this.labelNumeroDocumento = new System.Windows.Forms.Label();
            this.buttonBusqueda = new System.Windows.Forms.Button();
            this.groupBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxLegajo = new System.Windows.Forms.TextBox();
            this.groupBoxContacto = new System.Windows.Forms.GroupBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelLegajo = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBoxPrestamo = new System.Windows.Forms.GroupBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.checkBoxToday = new System.Windows.Forms.CheckBox();
            this.labelFechaHasta = new System.Windows.Forms.Label();
            this.textBoxFechaHasta = new System.Windows.Forms.TextBox();
            this.buttonCancelarSeleccionados = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.IdEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.groupBoxBusqueda.SuspendLayout();
            this.groupBoxDatosPersonales.SuspendLayout();
            this.groupBoxContacto.SuspendLayout();
            this.groupBoxPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.buttonConfirmar);
            this.panelPrincipal.Controls.Add(this.groupBoxPrestamo);
            this.panelPrincipal.Controls.Add(this.groupBoxBusqueda);
            this.panelPrincipal.Location = new System.Drawing.Point(12, 12);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(776, 531);
            this.panelPrincipal.TabIndex = 0;
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.groupBoxDatosPersonales);
            this.groupBoxBusqueda.Controls.Add(this.buttonBusqueda);
            this.groupBoxBusqueda.Controls.Add(this.buttonSeleccionar);
            this.groupBoxBusqueda.Controls.Add(this.textBoxNumeroDocumento);
            this.groupBoxBusqueda.Controls.Add(this.comboBoxTipoDocumento);
            this.groupBoxBusqueda.Controls.Add(this.labelTipoDocumento);
            this.groupBoxBusqueda.Controls.Add(this.labelNumeroDocumento);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(768, 170);
            this.groupBoxBusqueda.TabIndex = 0;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Busqueda";
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(318, 40);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionar.TabIndex = 10;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.ButtonSeleccionar_Click);
            // 
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(119, 40);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(183, 20);
            this.textBoxNumeroDocumento.TabIndex = 9;
            this.textBoxNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumeroDocumento_KeyPress);
            // 
            // comboBoxTipoDocumento
            // 
            this.comboBoxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDocumento.FormattingEnabled = true;
            this.comboBoxTipoDocumento.Location = new System.Drawing.Point(119, 13);
            this.comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            this.comboBoxTipoDocumento.Size = new System.Drawing.Size(183, 21);
            this.comboBoxTipoDocumento.TabIndex = 7;
            // 
            // labelTipoDocumento
            // 
            this.labelTipoDocumento.AutoSize = true;
            this.labelTipoDocumento.Location = new System.Drawing.Point(24, 16);
            this.labelTipoDocumento.Name = "labelTipoDocumento";
            this.labelTipoDocumento.Size = new System.Drawing.Size(89, 13);
            this.labelTipoDocumento.TabIndex = 8;
            this.labelTipoDocumento.Text = "Tipo Documento:";
            // 
            // labelNumeroDocumento
            // 
            this.labelNumeroDocumento.AutoSize = true;
            this.labelNumeroDocumento.Location = new System.Drawing.Point(8, 43);
            this.labelNumeroDocumento.Name = "labelNumeroDocumento";
            this.labelNumeroDocumento.Size = new System.Drawing.Size(105, 13);
            this.labelNumeroDocumento.TabIndex = 6;
            this.labelNumeroDocumento.Text = "Numero Documento:";
            // 
            // buttonBusqueda
            // 
            this.buttonBusqueda.Location = new System.Drawing.Point(682, 43);
            this.buttonBusqueda.Name = "buttonBusqueda";
            this.buttonBusqueda.Size = new System.Drawing.Size(80, 23);
            this.buttonBusqueda.TabIndex = 11;
            this.buttonBusqueda.Text = "Busqueda";
            this.buttonBusqueda.UseVisualStyleBackColor = true;
            this.buttonBusqueda.Click += new System.EventHandler(this.ButtonBusqueda_Click);
            // 
            // groupBoxDatosPersonales
            // 
            this.groupBoxDatosPersonales.Controls.Add(this.labelLegajo);
            this.groupBoxDatosPersonales.Controls.Add(this.labelNombre);
            this.groupBoxDatosPersonales.Controls.Add(this.labelApellido);
            this.groupBoxDatosPersonales.Controls.Add(this.groupBoxContacto);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxLegajo);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxNombre);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxApellido);
            this.groupBoxDatosPersonales.Location = new System.Drawing.Point(11, 66);
            this.groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            this.groupBoxDatosPersonales.Size = new System.Drawing.Size(751, 99);
            this.groupBoxDatosPersonales.TabIndex = 12;
            this.groupBoxDatosPersonales.TabStop = false;
            this.groupBoxDatosPersonales.Text = "Datos Personales";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(108, 19);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(183, 20);
            this.textBoxApellido.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(108, 45);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(183, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxLegajo
            // 
            this.textBoxLegajo.Location = new System.Drawing.Point(108, 71);
            this.textBoxLegajo.Name = "textBoxLegajo";
            this.textBoxLegajo.Size = new System.Drawing.Size(183, 20);
            this.textBoxLegajo.TabIndex = 3;
            // 
            // groupBoxContacto
            // 
            this.groupBoxContacto.Controls.Add(this.labelTelefono);
            this.groupBoxContacto.Controls.Add(this.textBoxTelefono);
            this.groupBoxContacto.Controls.Add(this.labelEmail);
            this.groupBoxContacto.Controls.Add(this.textBoxEmail);
            this.groupBoxContacto.Location = new System.Drawing.Point(361, 18);
            this.groupBoxContacto.Name = "groupBoxContacto";
            this.groupBoxContacto.Size = new System.Drawing.Size(384, 76);
            this.groupBoxContacto.TabIndex = 5;
            this.groupBoxContacto.TabStop = false;
            this.groupBoxContacto.Text = "Contacto";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(55, 22);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(47, 13);
            this.labelApellido.TabIndex = 0;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(55, 48);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelLegajo
            // 
            this.labelLegajo.AutoSize = true;
            this.labelLegajo.Location = new System.Drawing.Point(60, 74);
            this.labelLegajo.Name = "labelLegajo";
            this.labelLegajo.Size = new System.Drawing.Size(42, 13);
            this.labelLegajo.TabIndex = 7;
            this.labelLegajo.Text = "Legajo:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(41, 42);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 11;
            this.labelTelefono.Text = "Telefono:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(58, 16);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(99, 39);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(183, 20);
            this.textBoxTelefono.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(99, 13);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(183, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // groupBoxPrestamo
            // 
            this.groupBoxPrestamo.Controls.Add(this.buttonCancelarSeleccionados);
            this.groupBoxPrestamo.Controls.Add(this.textBoxFechaHasta);
            this.groupBoxPrestamo.Controls.Add(this.labelFechaHasta);
            this.groupBoxPrestamo.Controls.Add(this.checkBoxToday);
            this.groupBoxPrestamo.Controls.Add(this.dgvPrestamo);
            this.groupBoxPrestamo.Controls.Add(this.buttonAgregar);
            this.groupBoxPrestamo.Controls.Add(this.labelCodigo);
            this.groupBoxPrestamo.Controls.Add(this.textBoxCodigo);
            this.groupBoxPrestamo.Location = new System.Drawing.Point(3, 179);
            this.groupBoxPrestamo.Name = "groupBoxPrestamo";
            this.groupBoxPrestamo.Size = new System.Drawing.Size(768, 321);
            this.groupBoxPrestamo.TabIndex = 1;
            this.groupBoxPrestamo.TabStop = false;
            this.groupBoxPrestamo.Text = "Prestamo";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(34, 22);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(79, 13);
            this.labelCodigo.TabIndex = 9;
            this.labelCodigo.Text = "Codigo Equipo:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(119, 19);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(183, 20);
            this.textBoxCodigo.TabIndex = 8;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(318, 16);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 13;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.ButtonAgregar_Click);
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.AllowUserToAddRows = false;
            this.dgvPrestamo.AllowUserToDeleteRows = false;
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEquipo,
            this.Codigo,
            this.NombreEquipo,
            this.IdTipoEquipo,
            this.TipoEquipo});
            this.dgvPrestamo.Location = new System.Drawing.Point(11, 94);
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.Size = new System.Drawing.Size(745, 221);
            this.dgvPrestamo.TabIndex = 14;
            // 
            // checkBoxToday
            // 
            this.checkBoxToday.AutoSize = true;
            this.checkBoxToday.Checked = true;
            this.checkBoxToday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxToday.Location = new System.Drawing.Point(69, 45);
            this.checkBoxToday.Name = "checkBoxToday";
            this.checkBoxToday.Size = new System.Drawing.Size(67, 17);
            this.checkBoxToday.TabIndex = 15;
            this.checkBoxToday.Text = "Solo hoy";
            this.checkBoxToday.UseVisualStyleBackColor = true;
            this.checkBoxToday.CheckedChanged += new System.EventHandler(this.CheckBoxToday_CheckedChanged);
            // 
            // labelFechaHasta
            // 
            this.labelFechaHasta.AutoSize = true;
            this.labelFechaHasta.Location = new System.Drawing.Point(42, 71);
            this.labelFechaHasta.Name = "labelFechaHasta";
            this.labelFechaHasta.Size = new System.Drawing.Size(71, 13);
            this.labelFechaHasta.TabIndex = 16;
            this.labelFechaHasta.Text = "Fecha Hasta:";
            // 
            // textBoxFechaHasta
            // 
            this.textBoxFechaHasta.Location = new System.Drawing.Point(119, 68);
            this.textBoxFechaHasta.Name = "textBoxFechaHasta";
            this.textBoxFechaHasta.Size = new System.Drawing.Size(183, 20);
            this.textBoxFechaHasta.TabIndex = 17;
            // 
            // buttonCancelarSeleccionados
            // 
            this.buttonCancelarSeleccionados.Location = new System.Drawing.Point(618, 66);
            this.buttonCancelarSeleccionados.Name = "buttonCancelarSeleccionados";
            this.buttonCancelarSeleccionados.Size = new System.Drawing.Size(138, 23);
            this.buttonCancelarSeleccionados.TabIndex = 18;
            this.buttonCancelarSeleccionados.Text = "Cancelar Seleccionado";
            this.buttonCancelarSeleccionados.UseVisualStyleBackColor = true;
            this.buttonCancelarSeleccionados.Click += new System.EventHandler(this.ButtonCancelarSeleccionados_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(664, 503);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(107, 23);
            this.buttonConfirmar.TabIndex = 19;
            this.buttonConfirmar.Text = "Confirmar Prestamo";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.ButtonConfirmar_Click);
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
            // FrmInicioPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicioPrestamos";
            this.Text = "Iniciar Prestamos";
            this.Load += new System.EventHandler(this.FrmInicioPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            this.groupBoxDatosPersonales.ResumeLayout(false);
            this.groupBoxDatosPersonales.PerformLayout();
            this.groupBoxContacto.ResumeLayout(false);
            this.groupBoxContacto.PerformLayout();
            this.groupBoxPrestamo.ResumeLayout(false);
            this.groupBoxPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.Button buttonBusqueda;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private System.Windows.Forms.Label labelTipoDocumento;
        private System.Windows.Forms.Label labelNumeroDocumento;
        private System.Windows.Forms.GroupBox groupBoxDatosPersonales;
        private System.Windows.Forms.GroupBox groupBoxContacto;
        private System.Windows.Forms.TextBox textBoxLegajo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelLegajo;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.GroupBox groupBoxPrestamo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxFechaHasta;
        private System.Windows.Forms.Label labelFechaHasta;
        private System.Windows.Forms.CheckBox checkBoxToday;
        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.Button buttonCancelarSeleccionados;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEquipo;
    }
}