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
    public partial class FrmEquipoEdicion : Form
    {
        EquipoService oEquipoService;
        TipoEquipoService oTipoEquipoService;
        EstadoService oEstadoService;
        private ErrorProviderExtension oErrorProviderExtension;

        private ABMFormMode formMode = ABMFormMode.insert;
        public enum ABMFormMode
        {
            insert,
            update,
            delete
        }

        public FrmEquipoEdicion(EquipoService oEquipoService, ABMFormMode formMode)
        {
            InitializeComponent();

            this.formMode = formMode;
            this.oEquipoService = oEquipoService;

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.CenterToScreen();
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmEquipoEdicion_Load(object sender, EventArgs e)
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            oErrorProviderExtension = new ErrorProviderExtension(errorProvider);
            this.oTipoEquipoService = new TipoEquipoService();
            this.oEstadoService = new EstadoService();

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
            IList<TipoEquipoDTO> tiposEquipos = oTipoEquipoService.GetTipoEquipoByFilters(new Dictionary<string, object>());
            List<string> content = new List<string>();

            content.Add("Seleccionar");
            foreach (TipoEquipoDTO tipoEquipo in tiposEquipos)
                content.Add(tipoEquipo.NombreTipoEquipo);

            comboBoxTipoEquipo.DataSource = content;

            // ######################################
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("Ambito", "Equipo");
            IList<EstadoDTO> estados = oEstadoService.GetEstadoByFilters(parametros);
            List<string> contentEstados = new List<string>();

            foreach (EstadoDTO estado in estados)
                contentEstados.Add(estado.NombreEstado);

            comboBoxEstado.SelectedIndex = comboBoxEstado.FindStringExact("DISPONIBLE");
            comboBoxEstado.DataSource = contentEstados;
        }

        /// <summary>
        /// Setea el largo maximo para los campos textBox iguales a los seteados en la BD
        /// </summary>
        private void setTextBoxLimits()
        {
            textBoxNombre.MaxLength = 30;
            textBoxCodigo.MaxLength = 20;
            textBoxDescripcion.MaxLength = 50;
        }
        /// <summary>
        /// Ajusta los labels de la pantalla para que coincidan con el modo de formulario
        /// </summary>
        private void setLabels()
        {
            switch (formMode)
            {
                case ABMFormMode.insert:
                    this.Text = "Alta Equipo";
                    break;
                case ABMFormMode.update:
                    this.Text = "Modificar Equipo";
                    break;
                case ABMFormMode.delete:
                    this.Text = "Eliminar Equipo";
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
                textBoxCodigo.Enabled = false;
                textBoxNombre.Enabled = false;
                comboBoxTipoEquipo.Enabled = false;
                comboBoxEstado.Enabled = false;
                textBoxDescripcion.Enabled = false;
            }
        }

        /// <summary>
        /// carga los datos del Equipo a editar/bortrar si esatmos en modo edicion o eliminacion
        /// </summary>
        private void cargarDatos()
        {
            if (formMode == ABMFormMode.update || formMode == ABMFormMode.delete)
            {
                EquipoDTO oEquipo = oEquipoService.GetEquipoById(oEquipoService.IdEquipoSelected);

                textBoxCodigo.Text = oEquipo.Codigo;
                textBoxNombre.Text = oEquipo.Nombre;
                comboBoxTipoEquipo.SelectedIndex = comboBoxTipoEquipo.FindStringExact(oEquipo.TipoEquipo);
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindStringExact(oEquipo.Estado);
                textBoxDescripcion.Text = oEquipo.Descripcion;
            }
        }

        // #########################################################
        // Eventos de los botonoes
        // #########################################################

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            validarCampoObligatorios(this.textBoxNombre);
            validarCampoObligatorios(this.textBoxCodigo);
            validarCampoObligatorios(this.comboBoxTipoEquipo);
            if (!oErrorProviderExtension.HasErrors())
            {
                try
                {
                    EquipoDTO oEquipo = new EquipoDTO();

                    oEquipo.IdEquipo = 0;
                    if (formMode != ABMFormMode.insert)
                        oEquipo.IdEquipo = oEquipoService.IdEquipoSelected;

                    oEquipo.Codigo = textBoxCodigo.Text;
                    oEquipo.Nombre = textBoxNombre.Text;
                    oEquipo.Descripcion = textBoxDescripcion.Text;
                    oEquipo.TipoEquipo = comboBoxTipoEquipo.SelectedItem.ToString();
                    oEquipo.Estado = comboBoxEstado.SelectedItem.ToString();

                    //       ######################################################################     SOULICION MOMENTANEA PARA TRAER IdTipoEquipo
                    Dictionary<string, object> parametros = new Dictionary<string, object>();
                    parametros.Add("TipoEquipo", comboBoxTipoEquipo.SelectedItem.ToString());
                    oEquipo.IdTipoEquipo = oTipoEquipoService.GetTipoEquipoByFilters(parametros).First().IdTipoEquipo; // CORREGIR

                    Dictionary<string, object> parametros2 = new Dictionary<string, object>();
                    parametros2.Add("NombreEstado", comboBoxEstado.SelectedItem.ToString());
                    oEquipo.IdEstado = oEstadoService.GetEstadoByFilters(parametros2).First().IdEstado; // CORREGIR
                    //       ######################################################################     SOULICION MOMENTANEA PARA TRAER IdTipoEquipo

                    switch (formMode)
                    {
                        case ABMFormMode.insert:
                            oEquipoService.InsertEquipo(oEquipo);
                            this.Close();
                            break;
                        case ABMFormMode.update:
                            oEquipoService.UpdateEquipoById(oEquipo);
                            this.Close();
                            break;
                        case ABMFormMode.delete:
                            if (MessageBox.Show("¿Seguro que quiere eliminar" + oEquipo.Codigo + "?", "Confirmar Eliminacion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                oEquipoService.DeleteEquipoById(oEquipo.IdEquipo);
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

        // ##################################################################
        // Eventos Validating y KeyPress(No hay aca)
        // ##################################################################

        private void TextBoxObligatorios_Validating(object sender, CancelEventArgs e)
        {
            TextBox oEventSender = (TextBox)sender;
            validarCampoObligatorios(oEventSender);
        }

        private void ComboBoxObligatorios_Validating(object sender, CancelEventArgs e)
        {
            ComboBox oEventSender = (ComboBox)sender;
            validarCampoObligatorios(oEventSender);
        }

        private void validarCampoObligatorios(TextBox oEventSender)
        {
            string errorString = "";
            if (string.IsNullOrEmpty(oEventSender.Text))
                errorString += "El " + oEventSender.Name + " es un campo obligatorio";

            oErrorProviderExtension.SetErrorWithCount(oEventSender, errorString);
        }

        private void validarCampoObligatorios(ComboBox oEventSender)
        {
            string errorString = "";
            if (oEventSender.SelectedIndex == 0)
                errorString += "El " + oEventSender.Name + " es un campo obligatorio";

            oErrorProviderExtension.SetErrorWithCount(oEventSender, errorString);
        }


    }
}
