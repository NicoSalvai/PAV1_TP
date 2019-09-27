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
    public partial class FrmLogin : Form
    {
        UsuarioService oUsuarioService;
        public FrmLogin(UsuarioService oUsuarioService)
        {
            this.oUsuarioService = oUsuarioService;
            InitializeComponent();

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.CenterToScreen();
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public FrmLogin()
        {
            this.oUsuarioService = new UsuarioService();
            InitializeComponent();

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.CenterToScreen();
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsuario.Text == "" || textBoxUsuario.Text == null)
                    throw new Exception("Campo Usuario vacio o null");
                if (textBoxPassword.Text == "" || textBoxPassword.Text == null)
                    throw new Exception("Campo Password vacio o null");

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("NombreUsuario", textBoxUsuario.Text);

                IList<UsuarioDTO> lista = oUsuarioService.GetUsuarioByFilters(parametros);
                UsuarioDTO oUsuario;

                if (lista.Count == 1)
                {
                    oUsuario = lista.First();
                    if (lista.First().Pass.Equals(oUsuarioService.GetMd5Hash(textBoxPassword.Text)))
                    {
                        oUsuarioService.IdUsuarioLogeado = lista.First().IdUsuario;
                    }
                    else { throw new Exception("Password Incorrecta"); }
                }
                else { throw new Exception("Usuario Inexistente"); }

                if (oUsuario.ForzarPassword)
                {
                    new FrmCambioPassword(oUsuarioService, FrmCambioPassword.CambioPassFormMode.forzarCambio).ShowDialog();
                }
                
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            textBoxUsuario.MaxLength = 20;
            textBoxPassword.MaxLength = 20;
        }
    }
}
