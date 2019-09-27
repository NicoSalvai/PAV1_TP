using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CEE.Negocio;
using CEE.Negocio.DTO;

namespace CEE.Interfaz
{
    public partial class FrmCambioPassword : Form
    {
        UsuarioService oUsuarioService;
        bool finalizo;

        private CambioPassFormMode formMode = CambioPassFormMode.forzarCambio;
        public enum CambioPassFormMode
        {
            cambio,
            forzarCambio
        }
        public FrmCambioPassword(UsuarioService oUsuarioService, CambioPassFormMode formMode)
        {
            this.oUsuarioService = oUsuarioService;
            InitializeComponent();
            this.formMode = formMode;

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.CenterToScreen();
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            finalizo = false;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxContraseñaVieja.Text == "" || textBoxContraseñaVieja.Text == null)
                    throw new Exception("Campo Password Vieja vacio o null");
                if (textBoxContraseña.Text == "" || textBoxContraseña.Text == null)
                    throw new Exception("Campo Password Nueva vacio o null");

                UsuarioDTO oUsuario = oUsuarioService.GetUsuarioById(oUsuarioService.IdUsuarioLogeado);

                if (oUsuario.Pass == oUsuarioService.GetMd5Hash(textBoxContraseñaVieja.Text))
                {
                    if (textBoxContraseña.Text == textBoxContraseñaRepetir.Text)
                    {
                        oUsuario.Pass = oUsuarioService.GetMd5Hash(textBoxContraseña.Text);
                        oUsuario.ForzarPassword = false;
                        oUsuarioService.UpdateUsuarioById(oUsuario);
                    }
                    else { throw new Exception("Contraseñas no coinciden"); }
                }
                else { throw new Exception("Contraseña Equivocada"); }
                finalizo = true;
                this.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FrmCambioPassword_Load(object sender, EventArgs e)
        {
            textBoxContraseña.MaxLength = 20;
            textBoxContraseñaVieja.MaxLength = 20;
            textBoxContraseñaRepetir.MaxLength = 20;
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!finalizo && formMode == CambioPassFormMode.forzarCambio)
            {
                oUsuarioService.IdUsuarioLogeado = 0;
            }
        }
    }
}
