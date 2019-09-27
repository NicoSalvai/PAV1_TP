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
using CEE.Negocio.Auxiliares;

namespace CEE.Interfaz
{
    public partial class FrmUsuarios : Form
    {
        UsuarioService oUsuarioService;
        PerfilService oPerfilService;

        public FrmUsuarios()
        {
            InitializeComponent();

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.CenterToScreen();
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();
        }

        /// <summary>
        /// Levanta los datos necesarios atraves de servicios para cargar los combos de la interfaz
        /// </summary>
        private void cargarCombos()
        {
            /*
            IList<PerfilDTO> perfiles = oPerfilService.GetPerfilByFilters(new Dictionary<string, object>());
            List<string> content = new List<string>();

            content.Add("Seleccionar");
            foreach (PerfilDTO perfil in perfiles)
                content.Add(perfil.NombrePerfil);

            comboBoxTipoEquipo.DataSource = content;
            */
        }

        /// <summary>
        /// Setea el largo maximo para los campos textBox iguales a los seteados en la BD
        /// </summary>
        private void setTextBoxLimits()
        {
            textBoxNombreUsuario.MaxLength = 20;
        }

        // ########################################################################
        // Eventos de los botones
        // ########################################################################
        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.Clear();

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(textBoxNombreUsuario.Text))
                parametros.Add("NombreUsuarioLike", textBoxNombreUsuario.Text);

            IList<UsuarioDTO> busqueda = oUsuarioService.GetUsuarioByFilters(parametros);
            foreach (UsuarioDTO oUsuario in busqueda)
            {
                dgvUsuarios.Rows.Add(new object[] { oUsuario.IdUsuario, oUsuario.NombreUsuario, oUsuario.FechaAlta.ToString() });
            }   
        }


        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            FrmUsuarioEdicion alta = new FrmUsuarioEdicion(oUsuarioService, FrmUsuarioEdicion.ABMFormMode.insert);
            alta.ShowDialog();
            dgvUsuarios.Rows.Clear();
        }


        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
            }
            else
            {
                oUsuarioService.IdUsuarioSelected = Int32.Parse(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value.ToString());
                FrmUsuarioEdicion alta = new FrmUsuarioEdicion(oUsuarioService, FrmUsuarioEdicion.ABMFormMode.delete);
                alta.ShowDialog();
                dgvUsuarios.Rows.Clear();
            }
        }


        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
            }
            else
            {
                oUsuarioService.IdUsuarioSelected = Int32.Parse(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value.ToString());
                FrmUsuarioEdicion alta = new FrmUsuarioEdicion(oUsuarioService, FrmUsuarioEdicion.ABMFormMode.update);
                alta.ShowDialog();
                dgvUsuarios.Rows.Clear();
            }
        }
    }
}
