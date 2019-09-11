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
        public FrmLogin(UsuarioService ioUsuarioService)
        {
            this.oUsuarioService = ioUsuarioService;
            InitializeComponent();
        }

        public FrmLogin()
        {
            this.oUsuarioService = new UsuarioService();
            InitializeComponent();
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
                parametros.Add("FechaBajaNull", "");

                if (oUsuarioService.LoginUsuario(parametros, textBoxPassword.Text))
                {
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
