﻿namespace CEE.Interfaz
{
    partial class FrmEquipoEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipoEdicion));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelEquipo = new System.Windows.Forms.Panel();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelTipoEquipo = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.comboBoxTipoEquipo = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.panelPrincipal.SuspendLayout();
            this.panelEquipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelEquipo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(329, 290);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelEquipo
            // 
            this.panelEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEquipo.Controls.Add(this.labelEstado);
            this.panelEquipo.Controls.Add(this.comboBoxEstado);
            this.panelEquipo.Controls.Add(this.labelDescripcion);
            this.panelEquipo.Controls.Add(this.labelNombre);
            this.panelEquipo.Controls.Add(this.labelCodigo);
            this.panelEquipo.Controls.Add(this.labelTipoEquipo);
            this.panelEquipo.Controls.Add(this.buttonGuardar);
            this.panelEquipo.Controls.Add(this.textBoxNombre);
            this.panelEquipo.Controls.Add(this.textBoxDescripcion);
            this.panelEquipo.Controls.Add(this.textBoxCodigo);
            this.panelEquipo.Controls.Add(this.comboBoxTipoEquipo);
            this.panelEquipo.Location = new System.Drawing.Point(12, 12);
            this.panelEquipo.Name = "panelEquipo";
            this.panelEquipo.Size = new System.Drawing.Size(305, 266);
            this.panelEquipo.TabIndex = 0;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(16, 123);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 10;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(35, 97);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(39, 71);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 8;
            this.labelCodigo.Text = "Codigo:";
            // 
            // labelTipoEquipo
            // 
            this.labelTipoEquipo.AutoSize = true;
            this.labelTipoEquipo.Location = new System.Drawing.Point(15, 17);
            this.labelTipoEquipo.Name = "labelTipoEquipo";
            this.labelTipoEquipo.Size = new System.Drawing.Size(67, 13);
            this.labelTipoEquipo.TabIndex = 7;
            this.labelTipoEquipo.Text = "Tipo Equipo:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(225, 238);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(88, 94);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(197, 20);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxObligatorios_Validating);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(88, 120);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(197, 95);
            this.textBoxDescripcion.TabIndex = 3;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(88, 68);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(197, 20);
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxObligatorios_Validating);
            // 
            // comboBoxTipoEquipo
            // 
            this.comboBoxTipoEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoEquipo.FormattingEnabled = true;
            this.comboBoxTipoEquipo.Location = new System.Drawing.Point(88, 14);
            this.comboBoxTipoEquipo.Name = "comboBoxTipoEquipo";
            this.comboBoxTipoEquipo.Size = new System.Drawing.Size(197, 21);
            this.comboBoxTipoEquipo.TabIndex = 0;
            this.comboBoxTipoEquipo.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxObligatorios_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(39, 44);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(43, 13);
            this.labelEstado.TabIndex = 12;
            this.labelEstado.Text = "Estado:";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(88, 41);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(197, 21);
            this.comboBoxEstado.TabIndex = 11;
            // 
            // FrmEquipoEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 290);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEquipoEdicion";
            this.Text = "Equipo";
            this.Load += new System.EventHandler(this.FrmEquipoEdicion_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelEquipo.ResumeLayout(false);
            this.panelEquipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelEquipo;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelTipoEquipo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.ComboBox comboBoxTipoEquipo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
    }
}