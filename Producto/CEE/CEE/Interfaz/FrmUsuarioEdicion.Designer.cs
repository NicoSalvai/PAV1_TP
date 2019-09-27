namespace CEE.Interfaz
{
    partial class FrmUsuarioEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioEdicion));
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBoxPerfiles = new System.Windows.Forms.GroupBox();
            this.buttonQuitar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.labelPerfilesTodos = new System.Windows.Forms.Label();
            this.labelPerfilesUsuario = new System.Windows.Forms.Label();
            this.dgvPerfiles = new System.Windows.Forms.DataGridView();
            this.IdPerfilLibre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePerfilLibre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPerfilesUsuario = new System.Windows.Forms.DataGridView();
            this.IdPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelUsuario.SuspendLayout();
            this.groupBoxPerfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfilesUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUsuario
            // 
            this.panelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsuario.Controls.Add(this.checkBoxPassword);
            this.panelUsuario.Controls.Add(this.buttonGuardar);
            this.panelUsuario.Controls.Add(this.groupBoxPerfiles);
            this.panelUsuario.Controls.Add(this.textBoxNombreUsuario);
            this.panelUsuario.Controls.Add(this.labelNombreUsuario);
            this.panelUsuario.Location = new System.Drawing.Point(12, 12);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(532, 426);
            this.panelUsuario.TabIndex = 0;
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(109, 42);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(168, 17);
            this.checkBoxPassword.TabIndex = 6;
            this.checkBoxPassword.Text = "Forzar Reinicio de Contraseña";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(436, 398);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // groupBoxPerfiles
            // 
            this.groupBoxPerfiles.Controls.Add(this.buttonQuitar);
            this.groupBoxPerfiles.Controls.Add(this.buttonAgregar);
            this.groupBoxPerfiles.Controls.Add(this.labelPerfilesTodos);
            this.groupBoxPerfiles.Controls.Add(this.labelPerfilesUsuario);
            this.groupBoxPerfiles.Controls.Add(this.dgvPerfiles);
            this.groupBoxPerfiles.Controls.Add(this.dgvPerfilesUsuario);
            this.groupBoxPerfiles.Location = new System.Drawing.Point(3, 73);
            this.groupBoxPerfiles.Name = "groupBoxPerfiles";
            this.groupBoxPerfiles.Size = new System.Drawing.Size(524, 319);
            this.groupBoxPerfiles.TabIndex = 3;
            this.groupBoxPerfiles.TabStop = false;
            this.groupBoxPerfiles.Text = "Perfiles";
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.Location = new System.Drawing.Point(233, 97);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(55, 23);
            this.buttonQuitar.TabIndex = 6;
            this.buttonQuitar.Text = ">";
            this.buttonQuitar.UseVisualStyleBackColor = true;
            this.buttonQuitar.Click += new System.EventHandler(this.ButtonQuitar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(233, 39);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(55, 23);
            this.buttonAgregar.TabIndex = 5;
            this.buttonAgregar.Text = "<";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.ButtonAgregar_Click);
            // 
            // labelPerfilesTodos
            // 
            this.labelPerfilesTodos.AutoSize = true;
            this.labelPerfilesTodos.Location = new System.Drawing.Point(291, 23);
            this.labelPerfilesTodos.Name = "labelPerfilesTodos";
            this.labelPerfilesTodos.Size = new System.Drawing.Size(115, 13);
            this.labelPerfilesTodos.TabIndex = 5;
            this.labelPerfilesTodos.Text = "Todos los otros perfiles";
            // 
            // labelPerfilesUsuario
            // 
            this.labelPerfilesUsuario.AutoSize = true;
            this.labelPerfilesUsuario.Location = new System.Drawing.Point(10, 23);
            this.labelPerfilesUsuario.Name = "labelPerfilesUsuario";
            this.labelPerfilesUsuario.Size = new System.Drawing.Size(97, 13);
            this.labelPerfilesUsuario.TabIndex = 4;
            this.labelPerfilesUsuario.Text = "Perfiles del Usuario";
            // 
            // dgvPerfiles
            // 
            this.dgvPerfiles.AllowUserToAddRows = false;
            this.dgvPerfiles.AllowUserToDeleteRows = false;
            this.dgvPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPerfilLibre,
            this.NombrePerfilLibre});
            this.dgvPerfiles.Location = new System.Drawing.Point(294, 39);
            this.dgvPerfiles.Name = "dgvPerfiles";
            this.dgvPerfiles.ReadOnly = true;
            this.dgvPerfiles.Size = new System.Drawing.Size(214, 274);
            this.dgvPerfiles.TabIndex = 3;
            // 
            // IdPerfilLibre
            // 
            this.IdPerfilLibre.HeaderText = "IdPerfilLibre";
            this.IdPerfilLibre.Name = "IdPerfilLibre";
            this.IdPerfilLibre.ReadOnly = true;
            this.IdPerfilLibre.Visible = false;
            // 
            // NombrePerfilLibre
            // 
            this.NombrePerfilLibre.HeaderText = "Nombre Perfil";
            this.NombrePerfilLibre.Name = "NombrePerfilLibre";
            this.NombrePerfilLibre.ReadOnly = true;
            this.NombrePerfilLibre.Width = 170;
            // 
            // dgvPerfilesUsuario
            // 
            this.dgvPerfilesUsuario.AllowUserToAddRows = false;
            this.dgvPerfilesUsuario.AllowUserToDeleteRows = false;
            this.dgvPerfilesUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfilesUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPerfil,
            this.NombrePerfil});
            this.dgvPerfilesUsuario.Location = new System.Drawing.Point(13, 39);
            this.dgvPerfilesUsuario.Name = "dgvPerfilesUsuario";
            this.dgvPerfilesUsuario.ReadOnly = true;
            this.dgvPerfilesUsuario.Size = new System.Drawing.Size(214, 274);
            this.dgvPerfilesUsuario.TabIndex = 2;
            // 
            // IdPerfil
            // 
            this.IdPerfil.HeaderText = "IdPerfil";
            this.IdPerfil.Name = "IdPerfil";
            this.IdPerfil.ReadOnly = true;
            this.IdPerfil.Visible = false;
            // 
            // NombrePerfil
            // 
            this.NombrePerfil.HeaderText = "Nombre Perfil";
            this.NombrePerfil.Name = "NombrePerfil";
            this.NombrePerfil.ReadOnly = true;
            this.NombrePerfil.Width = 170;
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(109, 16);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(188, 20);
            this.textBoxNombreUsuario.TabIndex = 1;
            this.textBoxNombreUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNombreUsuario_Validating);
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Location = new System.Drawing.Point(13, 19);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(90, 13);
            this.labelNombreUsuario.TabIndex = 0;
            this.labelNombreUsuario.Text = "Nombre Usuario*:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmUsuarioEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.panelUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuarioEdicion";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmUsuarioEdicion_Load);
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.groupBoxPerfiles.ResumeLayout(false);
            this.groupBoxPerfiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfilesUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.GroupBox groupBoxPerfiles;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridView dgvPerfiles;
        private System.Windows.Forms.Label labelPerfilesTodos;
        private System.Windows.Forms.Label labelPerfilesUsuario;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonQuitar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPerfilLibre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePerfilLibre;
        private System.Windows.Forms.DataGridView dgvPerfilesUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePerfil;
        private System.Windows.Forms.CheckBox checkBoxPassword;
    }
}