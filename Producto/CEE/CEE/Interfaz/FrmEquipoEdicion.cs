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
        private ErrorProviderExtension oErrorProviderExtension;

        public ABMFormMode formMode = ABMFormMode.insert;
        public enum ABMFormMode
        {
            insert,
            update,
            delete
        }

        public FrmEquipoEdicion(EquipoService oEquipoService)
        {
            InitializeComponent();

            this.oTipoEquipoService = new TipoEquipoService();
            this.oEquipoService = oEquipoService;
        }

        private void FrmEquipoEdicion_Load(object sender, EventArgs e)
        {
            oErrorProviderExtension = new ErrorProviderExtension(errorProvider);
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            setLabels();
            cargarCombos();
            habilitarCampos();
            cargarDatos();

            textBoxNombre.MaxLength = 30;
            textBoxCodigo.MaxLength = 30;
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
                textBoxDescripcion.Text = oEquipo.Descripcion;
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
                textBoxDescripcion.Enabled = false;
            }
        }

        // #########################################################
        // Eventos de los botonoes
        // #########################################################

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            validarObligatorios(this.textBoxNombre);
            validarObligatorios(this.textBoxCodigo);
            validarObligatorios(this.comboBoxTipoEquipo);
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

                    //       ######################################################################     SOULICION MOMENTANEA PARA TRAER IdTipoEquipo
                    Dictionary<string, object> parametros = new Dictionary<string, object>();
                    parametros.Add("TipoEquipo", comboBoxTipoEquipo.SelectedItem.ToString());
                    oEquipo.IdTipoEquipo = oTipoEquipoService.GetTipoEquipoByFilters(parametros).First().IdTipoEquipo; // CORREGIR
                    //       ######################################################################     SOULICION MOMENTANEA PARA TRAER IdTipoEquipo

                    if (formMode == ABMFormMode.update)
                    {
                        oEquipoService.UpdateEquipoById(oEquipo);
                        this.Dispose();
                    }
                    else if (formMode == ABMFormMode.insert)
                    {
                        oEquipoService.InsertEquipo(oEquipo);
                        this.Dispose();
                    }
                    else if (formMode == ABMFormMode.delete)
                    {
                        if (MessageBox.Show("¿Seguro que quiere eliminar" + oEquipo.Codigo + "?", "Confirmar Eliminacion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            oEquipoService.DeleteEquipoById(oEquipo.IdEquipo);
                        this.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // ##################################################################
        // Eventos Validating y KeyPress(No hay aca)
        // ##################################################################

        private void TextBoxObligatorios_Validating(object sender, CancelEventArgs e)
        {
            TextBox oEventSender = (TextBox)sender;
            validarObligatorios(oEventSender);
        }

        private void validarObligatorios(TextBox oEventSender)
        {
            string errorString = "";

            if (string.IsNullOrEmpty(oEventSender.Text))
                errorString += "El " + oEventSender.Name + " es un campo obligatorio";

            oErrorProviderExtension.SetErrorWithCount(oEventSender, errorString);
        }

        private void ComboBoxObligatorios_Validating(object sender, CancelEventArgs e)
        {
            ComboBox oEventSender = (ComboBox)sender;
            validarObligatorios(oEventSender);
        }

        private void validarObligatorios(ComboBox oEventSender)
        {
            string errorString = "";

            if (oEventSender.SelectedIndex == 0)
                errorString += "El " + oEventSender.Name + " es un campo obligatorio";

            oErrorProviderExtension.SetErrorWithCount(oEventSender, errorString);
        }


    }
}
