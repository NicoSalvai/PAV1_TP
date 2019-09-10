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
using CEE.Entidad;

namespace CEE.Interfaz
{
    public partial class FrmLogin : Form
    {
        UsuarioService oUsuarioService;
        PerfilService oPerfilService;
        
        public FrmLogin()
        {
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            dgvUsuario.Rows.Clear();
            dgvPerfil.Rows.Clear();
            dgvMenu.Rows.Clear();
            //Usuario oUsuario = oUsuarioService.GetUsuarioById(1);
            IList<Usuario> usuarios = oUsuarioService.GetUsuarioByFilters(new Dictionary<string, object>());

            foreach (Usuario oUsuario in usuarios)
            {
                dgvUsuario.Rows.Add(new object[] { oUsuario.IdUsuario.ToString(), oUsuario.NombreUsuario.ToString(), oUsuario.Pass.ToString() }); ;
            }

        }

        private void DgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPerfil.Rows.Clear();
            dgvMenu.Rows.Clear();
            if (dgvUsuario.CurrentRow.Index != -1)
            {
                dgvPerfil.Rows.Clear();

                int idUsuarioSeleccionado = Convert.ToInt32(dgvUsuario.CurrentRow.Cells[0].Value);

                IList<Perfil> perfiles = oUsuarioService.GetUsuarioById(idUsuarioSeleccionado).Perfiles;
                foreach (Perfil oPerfil in perfiles)
                    dgvPerfil.Rows.Add(new string[] { oPerfil.IdPerfil.ToString(), oPerfil.NombrePerfil, oPerfil.Descripcion, oPerfil.FechaAlta.ToString(), oPerfil.FechaBaja.ToString()});
            }
        }

        private void DgvPerfil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMenu.Rows.Clear();
            if (dgvPerfil.CurrentRow.Index != -1)
            {
                dgvMenu.Rows.Clear();

                int idPerfilSeleccionado = Convert.ToInt32(dgvPerfil.CurrentRow.Cells[0].Value);

                IList<CEE.Entidad.Menu> menus = oPerfilService.GetPerfilById(idPerfilSeleccionado).Menus;
                foreach (CEE.Entidad.Menu oMenu in menus)
                    dgvMenu.Rows.Add(new string[] { oMenu.IdMenu.ToString(), oMenu.MenuPadre.NombreMenu, oMenu.NombreMenu, oMenu.EsFinal.ToString(), oMenu.Aplicacion });
            }
        }
    }
}
