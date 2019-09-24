namespace CEE.Interfaz
{
    partial class FrmPersonaEdicion
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxObservaciones = new System.Windows.Forms.TextBox();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.groupBoxDomicilio = new System.Windows.Forms.GroupBox();
            this.textBoxDepartamento = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxPiso = new System.Windows.Forms.TextBox();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.labelDepartamento = new System.Windows.Forms.Label();
            this.labelPiso = new System.Windows.Forms.Label();
            this.labelNumeroCalle = new System.Windows.Forms.Label();
            this.labelCalle = new System.Windows.Forms.Label();
            this.groupBoxDatosContacto = new System.Windows.Forms.GroupBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxLegajo = new System.Windows.Forms.TextBox();
            this.labelNumeroDocumento = new System.Windows.Forms.Label();
            this.labelTipoDocumento = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelLegajo = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelPrincipal.SuspendLayout();
            this.groupBoxDomicilio.SuspendLayout();
            this.groupBoxDatosContacto.SuspendLayout();
            this.groupBoxDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.buttonCancelar);
            this.panelPrincipal.Controls.Add(this.buttonGuardar);
            this.panelPrincipal.Controls.Add(this.textBoxObservaciones);
            this.panelPrincipal.Controls.Add(this.labelObservaciones);
            this.panelPrincipal.Controls.Add(this.groupBoxDomicilio);
            this.panelPrincipal.Controls.Add(this.groupBoxDatosContacto);
            this.panelPrincipal.Controls.Add(this.groupBoxDatosPersonales);
            this.panelPrincipal.Location = new System.Drawing.Point(12, 12);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(776, 457);
            this.panelPrincipal.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(3, 429);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(696, 429);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 21;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.Location = new System.Drawing.Point(138, 342);
            this.textBoxObservaciones.Multiline = true;
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(442, 72);
            this.textBoxObservaciones.TabIndex = 20;
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Location = new System.Drawing.Point(38, 345);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(78, 13);
            this.labelObservaciones.TabIndex = 17;
            this.labelObservaciones.Text = "Observaciones";
            // 
            // groupBoxDomicilio
            // 
            this.groupBoxDomicilio.Controls.Add(this.textBoxDepartamento);
            this.groupBoxDomicilio.Controls.Add(this.textBoxNumero);
            this.groupBoxDomicilio.Controls.Add(this.textBoxPiso);
            this.groupBoxDomicilio.Controls.Add(this.textBoxCalle);
            this.groupBoxDomicilio.Controls.Add(this.labelDepartamento);
            this.groupBoxDomicilio.Controls.Add(this.labelPiso);
            this.groupBoxDomicilio.Controls.Add(this.labelNumeroCalle);
            this.groupBoxDomicilio.Controls.Add(this.labelCalle);
            this.groupBoxDomicilio.Location = new System.Drawing.Point(3, 261);
            this.groupBoxDomicilio.Name = "groupBoxDomicilio";
            this.groupBoxDomicilio.Size = new System.Drawing.Size(768, 71);
            this.groupBoxDomicilio.TabIndex = 2;
            this.groupBoxDomicilio.TabStop = false;
            this.groupBoxDomicilio.Text = "Domicilio";
            // 
            // textBoxDepartamento
            // 
            this.textBoxDepartamento.Location = new System.Drawing.Point(403, 39);
            this.textBoxDepartamento.Name = "textBoxDepartamento";
            this.textBoxDepartamento.Size = new System.Drawing.Size(174, 20);
            this.textBoxDepartamento.TabIndex = 19;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(403, 13);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(174, 20);
            this.textBoxNumero.TabIndex = 18;
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumericos_KeyPress);
            this.textBoxNumero.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxPisoYNumero_Validating);
            // 
            // textBoxPiso
            // 
            this.textBoxPiso.Location = new System.Drawing.Point(135, 39);
            this.textBoxPiso.Name = "textBoxPiso";
            this.textBoxPiso.Size = new System.Drawing.Size(174, 20);
            this.textBoxPiso.TabIndex = 17;
            this.textBoxPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumericos_KeyPress);
            this.textBoxPiso.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxPisoYNumero_Validating);
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Location = new System.Drawing.Point(135, 13);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(174, 20);
            this.textBoxCalle.TabIndex = 13;
            // 
            // labelDepartamento
            // 
            this.labelDepartamento.AutoSize = true;
            this.labelDepartamento.Location = new System.Drawing.Point(320, 43);
            this.labelDepartamento.Name = "labelDepartamento";
            this.labelDepartamento.Size = new System.Drawing.Size(77, 13);
            this.labelDepartamento.TabIndex = 16;
            this.labelDepartamento.Text = "Departamento:";
            // 
            // labelPiso
            // 
            this.labelPiso.AutoSize = true;
            this.labelPiso.Location = new System.Drawing.Point(99, 43);
            this.labelPiso.Name = "labelPiso";
            this.labelPiso.Size = new System.Drawing.Size(30, 13);
            this.labelPiso.TabIndex = 15;
            this.labelPiso.Text = "Piso:";
            // 
            // labelNumeroCalle
            // 
            this.labelNumeroCalle.AutoSize = true;
            this.labelNumeroCalle.Location = new System.Drawing.Point(350, 16);
            this.labelNumeroCalle.Name = "labelNumeroCalle";
            this.labelNumeroCalle.Size = new System.Drawing.Size(47, 13);
            this.labelNumeroCalle.TabIndex = 14;
            this.labelNumeroCalle.Text = "Numero:";
            // 
            // labelCalle
            // 
            this.labelCalle.AutoSize = true;
            this.labelCalle.Location = new System.Drawing.Point(96, 16);
            this.labelCalle.Name = "labelCalle";
            this.labelCalle.Size = new System.Drawing.Size(33, 13);
            this.labelCalle.TabIndex = 13;
            this.labelCalle.Text = "Calle:";
            // 
            // groupBoxDatosContacto
            // 
            this.groupBoxDatosContacto.Controls.Add(this.textBoxTelefono);
            this.groupBoxDatosContacto.Controls.Add(this.textBoxEmail);
            this.groupBoxDatosContacto.Controls.Add(this.labelTelefono);
            this.groupBoxDatosContacto.Controls.Add(this.labelEmail);
            this.groupBoxDatosContacto.Location = new System.Drawing.Point(3, 168);
            this.groupBoxDatosContacto.Name = "groupBoxDatosContacto";
            this.groupBoxDatosContacto.Size = new System.Drawing.Size(768, 87);
            this.groupBoxDatosContacto.TabIndex = 1;
            this.groupBoxDatosContacto.TabStop = false;
            this.groupBoxDatosContacto.Text = "Datos de Contacto";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(135, 49);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(174, 20);
            this.textBoxTelefono.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(135, 23);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(174, 20);
            this.textBoxEmail.TabIndex = 10;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(77, 52);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 11;
            this.labelTelefono.Text = "Telefono:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(91, 26);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "E-mail:";
            // 
            // groupBoxDatosPersonales
            // 
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxNumeroDocumento);
            this.groupBoxDatosPersonales.Controls.Add(this.comboBoxTipoDocumento);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxNombre);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxApellido);
            this.groupBoxDatosPersonales.Controls.Add(this.textBoxLegajo);
            this.groupBoxDatosPersonales.Controls.Add(this.labelNumeroDocumento);
            this.groupBoxDatosPersonales.Controls.Add(this.labelTipoDocumento);
            this.groupBoxDatosPersonales.Controls.Add(this.labelNombre);
            this.groupBoxDatosPersonales.Controls.Add(this.labelApellido);
            this.groupBoxDatosPersonales.Controls.Add(this.labelLegajo);
            this.groupBoxDatosPersonales.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            this.groupBoxDatosPersonales.Size = new System.Drawing.Size(768, 159);
            this.groupBoxDatosPersonales.TabIndex = 0;
            this.groupBoxDatosPersonales.TabStop = false;
            this.groupBoxDatosPersonales.Text = "Datos Personales";
            // 
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(135, 124);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(174, 20);
            this.textBoxNumeroDocumento.TabIndex = 9;
            this.textBoxNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumericos_KeyPress);
            this.textBoxNumeroDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxLegajoyNumeroDocumento_Validating);
            // 
            // comboBoxTipoDocumento
            // 
            this.comboBoxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDocumento.FormattingEnabled = true;
            this.comboBoxTipoDocumento.Location = new System.Drawing.Point(135, 97);
            this.comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            this.comboBoxTipoDocumento.Size = new System.Drawing.Size(174, 21);
            this.comboBoxTipoDocumento.TabIndex = 8;
            this.comboBoxTipoDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxTipoDocumento_Validating);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(135, 71);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(174, 20);
            this.textBoxNombre.TabIndex = 7;
            this.textBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxApellidoyNombre_Validating);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(135, 45);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(174, 20);
            this.textBoxApellido.TabIndex = 6;
            this.textBoxApellido.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxApellidoyNombre_Validating);
            // 
            // textBoxLegajo
            // 
            this.textBoxLegajo.Location = new System.Drawing.Point(135, 19);
            this.textBoxLegajo.Name = "textBoxLegajo";
            this.textBoxLegajo.Size = new System.Drawing.Size(174, 20);
            this.textBoxLegajo.TabIndex = 5;
            this.textBoxLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumericos_KeyPress);
            this.textBoxLegajo.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxLegajoyNumeroDocumento_Validating);
            // 
            // labelNumeroDocumento
            // 
            this.labelNumeroDocumento.AutoSize = true;
            this.labelNumeroDocumento.Location = new System.Drawing.Point(20, 127);
            this.labelNumeroDocumento.Name = "labelNumeroDocumento";
            this.labelNumeroDocumento.Size = new System.Drawing.Size(109, 13);
            this.labelNumeroDocumento.TabIndex = 4;
            this.labelNumeroDocumento.Text = "Numero Documento:*";
            // 
            // labelTipoDocumento
            // 
            this.labelTipoDocumento.AutoSize = true;
            this.labelTipoDocumento.Location = new System.Drawing.Point(36, 100);
            this.labelTipoDocumento.Name = "labelTipoDocumento";
            this.labelTipoDocumento.Size = new System.Drawing.Size(93, 13);
            this.labelTipoDocumento.TabIndex = 3;
            this.labelTipoDocumento.Text = "Tipo Documento:*";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(78, 74);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(51, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:*";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(78, 48);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(51, 13);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido:*";
            // 
            // labelLegajo
            // 
            this.labelLegajo.AutoSize = true;
            this.labelLegajo.Location = new System.Drawing.Point(83, 22);
            this.labelLegajo.Name = "labelLegajo";
            this.labelLegajo.Size = new System.Drawing.Size(46, 13);
            this.labelLegajo.TabIndex = 0;
            this.labelLegajo.Text = "Legajo:*";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmPersonaEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "FrmPersonaEdicion";
            this.Text = "Persona";
            this.Load += new System.EventHandler(this.FrmPersonaEdicion_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.groupBoxDomicilio.ResumeLayout(false);
            this.groupBoxDomicilio.PerformLayout();
            this.groupBoxDatosContacto.ResumeLayout(false);
            this.groupBoxDatosContacto.PerformLayout();
            this.groupBoxDatosPersonales.ResumeLayout(false);
            this.groupBoxDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.GroupBox groupBoxDatosContacto;
        private System.Windows.Forms.GroupBox groupBoxDatosPersonales;
        private System.Windows.Forms.GroupBox groupBoxDomicilio;
        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxLegajo;
        private System.Windows.Forms.Label labelNumeroDocumento;
        private System.Windows.Forms.Label labelTipoDocumento;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelLegajo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxObservaciones;
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.TextBox textBoxDepartamento;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxPiso;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.Label labelDepartamento;
        private System.Windows.Forms.Label labelPiso;
        private System.Windows.Forms.Label labelNumeroCalle;
        private System.Windows.Forms.Label labelCalle;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}