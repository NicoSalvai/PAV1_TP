namespace CEE.Interfaz
{
    partial class FrmCambioPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambioPassword));
            this.panelPrinciapl = new System.Windows.Forms.Panel();
            this.groupBoxCambioPassword = new System.Windows.Forms.GroupBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxContraseñaVieja = new System.Windows.Forms.TextBox();
            this.labelNuevaContraseña = new System.Windows.Forms.Label();
            this.labelPasswordActual = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.labelRepetirNuevaContraseña = new System.Windows.Forms.Label();
            this.textBoxContraseñaRepetir = new System.Windows.Forms.TextBox();
            this.panelPrinciapl.SuspendLayout();
            this.groupBoxCambioPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrinciapl
            // 
            this.panelPrinciapl.Controls.Add(this.groupBoxCambioPassword);
            this.panelPrinciapl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrinciapl.Location = new System.Drawing.Point(0, 0);
            this.panelPrinciapl.Name = "panelPrinciapl";
            this.panelPrinciapl.Size = new System.Drawing.Size(377, 145);
            this.panelPrinciapl.TabIndex = 1;
            // 
            // groupBoxCambioPassword
            // 
            this.groupBoxCambioPassword.Controls.Add(this.textBoxContraseñaRepetir);
            this.groupBoxCambioPassword.Controls.Add(this.labelRepetirNuevaContraseña);
            this.groupBoxCambioPassword.Controls.Add(this.textBoxContraseña);
            this.groupBoxCambioPassword.Controls.Add(this.textBoxContraseñaVieja);
            this.groupBoxCambioPassword.Controls.Add(this.labelNuevaContraseña);
            this.groupBoxCambioPassword.Controls.Add(this.labelPasswordActual);
            this.groupBoxCambioPassword.Controls.Add(this.buttonAceptar);
            this.groupBoxCambioPassword.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCambioPassword.Name = "groupBoxCambioPassword";
            this.groupBoxCambioPassword.Size = new System.Drawing.Size(353, 121);
            this.groupBoxCambioPassword.TabIndex = 0;
            this.groupBoxCambioPassword.TabStop = false;
            this.groupBoxCambioPassword.Text = "CambioPassword";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(149, 38);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(151, 20);
            this.textBoxContraseña.TabIndex = 1;
            this.textBoxContraseña.UseSystemPasswordChar = true;
            // 
            // textBoxContraseñaVieja
            // 
            this.textBoxContraseñaVieja.Location = new System.Drawing.Point(149, 13);
            this.textBoxContraseñaVieja.Name = "textBoxContraseñaVieja";
            this.textBoxContraseñaVieja.PasswordChar = '*';
            this.textBoxContraseñaVieja.Size = new System.Drawing.Size(151, 20);
            this.textBoxContraseñaVieja.TabIndex = 0;
            // 
            // labelNuevaContraseña
            // 
            this.labelNuevaContraseña.AutoSize = true;
            this.labelNuevaContraseña.Location = new System.Drawing.Point(44, 41);
            this.labelNuevaContraseña.Name = "labelNuevaContraseña";
            this.labelNuevaContraseña.Size = new System.Drawing.Size(99, 13);
            this.labelNuevaContraseña.TabIndex = 3;
            this.labelNuevaContraseña.Text = "Nueva Contraseña:";
            // 
            // labelPasswordActual
            // 
            this.labelPasswordActual.AutoSize = true;
            this.labelPasswordActual.Location = new System.Drawing.Point(46, 16);
            this.labelPasswordActual.Name = "labelPasswordActual";
            this.labelPasswordActual.Size = new System.Drawing.Size(97, 13);
            this.labelPasswordActual.TabIndex = 2;
            this.labelPasswordActual.Text = "Contraseña Actual:";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(272, 90);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 3;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptar_Click);
            // 
            // labelRepetirNuevaContraseña
            // 
            this.labelRepetirNuevaContraseña.AutoSize = true;
            this.labelRepetirNuevaContraseña.Location = new System.Drawing.Point(7, 67);
            this.labelRepetirNuevaContraseña.Name = "labelRepetirNuevaContraseña";
            this.labelRepetirNuevaContraseña.Size = new System.Drawing.Size(136, 13);
            this.labelRepetirNuevaContraseña.TabIndex = 4;
            this.labelRepetirNuevaContraseña.Text = "Repetir Nueva Contraseña:";
            // 
            // textBoxContraseñaRepetir
            // 
            this.textBoxContraseñaRepetir.Location = new System.Drawing.Point(149, 64);
            this.textBoxContraseñaRepetir.Name = "textBoxContraseñaRepetir";
            this.textBoxContraseñaRepetir.PasswordChar = '*';
            this.textBoxContraseñaRepetir.Size = new System.Drawing.Size(151, 20);
            this.textBoxContraseñaRepetir.TabIndex = 2;
            this.textBoxContraseñaRepetir.UseSystemPasswordChar = true;
            // 
            // FrmCambioPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 145);
            this.Controls.Add(this.panelPrinciapl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCambioPassword";
            this.Text = "Cambiar Contraseña";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmCambioPassword_Load);
            this.panelPrinciapl.ResumeLayout(false);
            this.groupBoxCambioPassword.ResumeLayout(false);
            this.groupBoxCambioPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrinciapl;
        private System.Windows.Forms.GroupBox groupBoxCambioPassword;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxContraseñaVieja;
        private System.Windows.Forms.Label labelNuevaContraseña;
        private System.Windows.Forms.Label labelPasswordActual;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelRepetirNuevaContraseña;
        private System.Windows.Forms.TextBox textBoxContraseñaRepetir;
    }
}