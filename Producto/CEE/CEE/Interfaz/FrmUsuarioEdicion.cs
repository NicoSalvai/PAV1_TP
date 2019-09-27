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
    public partial class FrmUsuarioEdicion : Form
    {
        UsuarioService oUsuarioService;
        PerfilService oPerfilService;
        private ErrorProviderExtension oErrorProviderExtension;

        private ABMFormMode formMode = ABMFormMode.insert;
        public enum ABMFormMode
        {
            insert,
            update,
            delete
        }

        public FrmUsuarioEdicion(UsuarioService oUsuarioService, ABMFormMode formMode)
        {
            InitializeComponent();

            this.formMode = formMode;
            this.oUsuarioService = oUsuarioService;

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.CenterToScreen();
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmUsuarioEdicion_Load(object sender, EventArgs e)
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            oErrorProviderExtension = new ErrorProviderExtension(errorProvider);
            this.oPerfilService = new PerfilService();

            cargarCombos();
            setTextBoxLimits();
            setLabels();
            habilitarCampos();
            cargarDatos();
        }

        /// <summary>
        /// Levanta los datos necesarios atraves de servicios para cargar los combos de la interfaz
        /// </summary>
        private void cargarCombos()
        {
            if (formMode == ABMFormMode.insert)
            {
                IList<PerfilDTO> perfiles = oPerfilService.GetPerfilByFilters(new Dictionary<string, object>());

                dgvPerfiles.Rows.Clear();

                foreach (PerfilDTO oPerfil in perfiles)
                {
                    dgvPerfiles.Rows.Add(new object[] { oPerfil.IdPerfil.ToString(), oPerfil.NombrePerfil });
                }
            }
        }

        /// <summary>
        /// Setea el largo maximo para los campos textBox iguales a los seteados en la BD
        /// </summary>
        private void setTextBoxLimits()
        {
            textBoxNombreUsuario.MaxLength = 20;
        }
        /// <summary>
        /// Ajusta los labels de la pantalla para que coincidan con el modo de formulario
        /// </summary>
        private void setLabels()
        {
            switch (formMode)
            {
                case ABMFormMode.insert:
                    this.Text = "Alta Usuario";
                    break;
                case ABMFormMode.update:
                    this.Text = "Modificar Usuario";
                    break;
                case ABMFormMode.delete:
                    this.Text = "Eliminar Usuario";
                    buttonGuardar.Text = "Eliminar";
                    break;

            }
        }

        /// <summary>
        /// habilita o deshabilita los campos segun el modo de formulario
        /// </summary>
        private void habilitarCampos()
        {
            if (formMode == ABMFormMode.delete)
            {
                textBoxNombreUsuario.Enabled = false;
                buttonAgregar.Enabled = false;
                buttonQuitar.Enabled = false;
                checkBoxPassword.Enabled = false;
            }
        }

        /// <summary>
        /// carga los datos del Equipo a editar/bortrar si esatmos en modo edicion o eliminacion
        /// </summary>
        private void cargarDatos()
        {
            if (formMode == ABMFormMode.update || formMode == ABMFormMode.delete)
            {
                UsuarioDTO oUsuario = oUsuarioService.GetUsuarioById(oUsuarioService.IdUsuarioSelected);
                textBoxNombreUsuario.Text = oUsuario.NombreUsuario;


                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("IdUsuario", oUsuario.IdUsuario.ToString());
                IList<PerfilDTO> perfiles = oPerfilService.GetPerfilByFilters(parametros);
                foreach (PerfilDTO oPerfil in perfiles)
                {
                    dgvPerfilesUsuario.Rows.Add(new object[] { oPerfil.IdPerfil.ToString(), oPerfil.NombrePerfil });
                }

                parametros.Clear();
                parametros.Add("IdUsuarioNot", oUsuario.IdUsuario.ToString());
                perfiles = oPerfilService.GetPerfilByFilters(parametros);
                foreach (PerfilDTO oPerfil in perfiles)
                {
                    dgvPerfiles.Rows.Add(new object[] { oPerfil.IdPerfil.ToString(), oPerfil.NombrePerfil });
                }
            }
        }

        // #########################################################
        // Eventos de los botonoes
        // #########################################################

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            validarCampoObligatorios(this.textBoxNombreUsuario);
            if (!oErrorProviderExtension.HasErrors())
            {
                try
                {
                    UsuarioDTO oUsuario = new UsuarioDTO();

                    oUsuario.IdUsuario = 0;
                    if (formMode != ABMFormMode.insert)
                        oUsuario.IdUsuario = oUsuarioService.IdUsuarioSelected;
                    oUsuario.NombreUsuario = textBoxNombreUsuario.Text;
                    oUsuario.Pass = "";
                    if(checkBoxPassword.Checked)
                        oUsuario.Pass = oUsuarioService.GetMd5Hash("1234");
                    oUsuario.ForzarPassword = checkBoxPassword.Checked;


                    //       ######################################################################     SOULICION MOMENTANEA PARA TRAER IdTipoEquipo
                    IList<int> perfiles = new List<int>();
                    foreach (DataGridViewRow row in dgvPerfilesUsuario.Rows)
                    {
                        perfiles.Add(Int32.Parse(row.Cells["IdPerfil"].Value.ToString()));
                    }
                    //       ######################################################################     SOULICION MOMENTANEA PARA TRAER IdTipoEquipo

                    switch (formMode)
                    {
                        case ABMFormMode.insert:
                            oUsuarioService.InsertUsuario(oUsuario, perfiles);
                            this.Close();
                            break;
                        case ABMFormMode.update:
                            oUsuarioService.UpdateUsuarioById(oUsuario, perfiles);
                            this.Close();
                            break;
                        case ABMFormMode.delete:
                            if (MessageBox.Show("¿Seguro que quiere eliminar" + oUsuario.NombreUsuario + "?", "Confirmar Eliminacion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                oUsuarioService.DeleteUsuarioById(oUsuario.IdUsuario);
                            this.Close();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            mover(dgvPerfiles, dgvPerfilesUsuario, "Libre");
        }

        private void ButtonQuitar_Click(object sender, EventArgs e)
        {
            mover(dgvPerfilesUsuario, dgvPerfiles, "");
        }

        private void mover(DataGridView dgvDesde, DataGridView dgvHasta, string aux)
        {
            if (dgvDesde.CurrentRow != null && dgvDesde.Rows.Count != 0)
            {
                string id = dgvDesde.CurrentRow.Cells["IdPerfil" + aux].Value.ToString();
                string nombrePerfil = dgvDesde.CurrentRow.Cells["NombrePerfil" + aux].Value.ToString();
                dgvHasta.Rows.Add(new object[] { id, nombrePerfil });
                dgvDesde.Rows.RemoveAt(dgvDesde.CurrentRow.Index);
            }
        }

        // ##################################################################
        // Eventos Validating y KeyPress(No hay aca)
        // ##################################################################

        private void TextBoxNombreUsuario_Validating(object sender, CancelEventArgs e)
        {
            TextBox oEventSender = (TextBox)sender;
            validarCampoObligatorios(oEventSender);
        }

        private void validarCampoObligatorios(TextBox oEventSender)
        {
            string errorString = "";
            if (string.IsNullOrEmpty(oEventSender.Text))
                errorString += "El " + oEventSender.Name + " es un campo obligatorio";

            oErrorProviderExtension.SetErrorWithCount(oEventSender, errorString);
        }
    }
}
