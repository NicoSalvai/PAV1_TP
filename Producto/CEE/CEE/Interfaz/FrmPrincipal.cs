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
    public partial class FrmPrincipal : Form
    {
        UsuarioService oUsuarioService;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funcion que se ejecuta ante el evento Load del Formulario
        /// Lo que hago es crear y mostrar un Formulario de Login para el inicio de sesion
        /// </summary>
        /// <param name="sender">Nose</param>
        /// <param name="e">Los argumentos del trigger del evento</param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            oUsuarioService = new UsuarioService();
            FrmLogin login = new FrmLogin(oUsuarioService);
            login.ShowDialog();
            checkLogin();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Salir de la aplicacion", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.No)
                e.Cancel = true;
        }

        private void checkLogin()
        {
            if (oUsuarioService.IdUsuarioLogeado == 0) this.Dispose();
        }
    }
}
