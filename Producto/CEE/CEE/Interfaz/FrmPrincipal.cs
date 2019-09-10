using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEE.Interfaz
{
    public partial class FrmPrincipal : Form
    {
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
            this.WindowState = FormWindowState.Maximized;
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Salir de la aplicacion", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.No)
                e.Cancel = true;
        }
    }
}
