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
    public partial class FrmPersonaEdicion : Form
    {
        private PersonaService oPersonaService;
        private TipoDocumentoService oTipoDocumentoService;
        private UniversidadService oUniversidadService;
        private CarreraService oCarreraService;
        private ErrorProviderExtension oErrorProviderExtension;

        private ABMFormMode formMode = ABMFormMode.insert;
        public enum ABMFormMode
        {
            insert,
            update,
            delete
        }

        public FrmPersonaEdicion(PersonaService oPersonaService, ABMFormMode formMode)
        {
            InitializeComponent();

            this.formMode = formMode;
            this.oPersonaService = oPersonaService;

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.CenterToScreen();
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmPersonaEdicion_Load(object sender, EventArgs e)
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            oErrorProviderExtension = new ErrorProviderExtension(errorProvider);
            this.oTipoDocumentoService = new TipoDocumentoService();
            this.oUniversidadService = new UniversidadService();
            this.oCarreraService = new CarreraService();

            cargarCombos();
            setTextBoxLimits();
            setLabels();
            habilitarCampos();
            cargarDatos();
        }

        /// <summary>
        /// Cargos el combo de Tipo Documento para la seleccion
        /// </summary>
        private void cargarCombos()
        {
            IList<TipoDocumentoDTO> tiposDocumentos = oTipoDocumentoService.GetTipoDocumentoByFilters(new Dictionary<string, object>());
            List<string> content = new List<string>();

            content.Add("Seleccionar");
            foreach (TipoDocumentoDTO oTipoDocumento in tiposDocumentos)
                content.Add(oTipoDocumento.NombreTipoDocumento);

            comboBoxTipoDocumento.DataSource = content;

            // ###############################################################

            IList<UniversidadDTO> universidades = oUniversidadService.GetUniversidadByFilters(new Dictionary<string, object>());
            List<string> content2 = new List<string>();

            content2.Add("Seleccionar");
            foreach (UniversidadDTO oUniversidad in universidades)
                content2.Add(oUniversidad.NombreUniversidad);

            comboBoxUniversidad.DataSource = content2;

            // ###############################################################

            IList<CarreraDTO> carreras = oCarreraService.GetCarreraByFilters(new Dictionary<string, object>());
            List<string> content3 = new List<string>();

            content3.Add("Seleccionar");
            foreach (CarreraDTO oCarrera in carreras)
                content3.Add(oCarrera.NombreCarrera);

            comboBoxCarrera.DataSource = content3;
        }

        /// <summary>
        /// Setea el largo maximo para los campos textBox iguales a los seteados en la BD
        /// </summary>
        private void setTextBoxLimits()
        {
            textBoxLegajo.MaxLength = 9;
            textBoxNumeroDocumento.MaxLength = 9;
            textBoxApellido.MaxLength = 30;
            textBoxNombre.MaxLength = 30;
            textBoxTelefono.MaxLength = 30;
            textBoxEmail.MaxLength = 30;
            textBoxCalle.MaxLength = 30;
            textBoxDepartamento.MaxLength = 30;
            textBoxObservaciones.MaxLength = 30;
            textBoxNumero.MaxLength = 9;
            textBoxPiso.MaxLength = 3;
        }

        /// <summary>
        /// Seteo los labels para que concuerden con el modo de operacion del formulario
        /// </summary>
        private void setLabels()
        {
            switch (formMode)
            {
                case ABMFormMode.insert:
                    this.Text = "Alta Persona";
                    break;
                case ABMFormMode.update:
                    this.Text = "Modificar Persona";
                    break;
                case ABMFormMode.delete:
                    this.Text = "Eliminar Persona";
                    buttonGuardar.Text = "Eliminar";
                    break;
            }
        }

        /// <summary>
        /// Se habilitan o deshabilitan los campos que haga falta segun el modo en que estemos
        /// </summary>
        private void habilitarCampos()
        {
            if(formMode == ABMFormMode.delete)
            {
                textBoxLegajo.Enabled = false;
                textBoxApellido.Enabled = false;
                textBoxNombre.Enabled = false;
                comboBoxTipoDocumento.Enabled = false;
                textBoxNumeroDocumento.Enabled = false;
                textBoxEmail.Enabled = false;
                textBoxTelefono.Enabled = false;
                textBoxCalle.Enabled = false;
                textBoxNumero.Enabled = false;
                textBoxPiso.Enabled = false;
                textBoxDepartamento.Enabled = false;
                textBoxObservaciones.Enabled = false;
                comboBoxCarrera.Enabled = false;
                comboBoxUniversidad.Enabled = false;
            }
        }


        /// <summary>
        /// si estamos en modo update o delete cargo los datos de la Persona Seleccionada en la otra pantalla
        /// </summary>
        private void cargarDatos()
        {
            if (formMode == ABMFormMode.update || formMode == ABMFormMode.delete)
            {
                PersonaDTO oPersona = oPersonaService.GetPersonaById(oPersonaService.IdPersonaSeleccionada);

                
                textBoxApellido.Text = oPersona.Apellido;
                textBoxNombre.Text = oPersona.Nombre;
                comboBoxTipoDocumento.SelectedIndex = comboBoxTipoDocumento.FindStringExact(oPersona.NombreTipoDocumento);
                textBoxNumeroDocumento.Text = oPersona.NumeroDocumento.ToString();

                if (oPersona.Legajo != 0)
                    textBoxLegajo.Text = oPersona.Legajo.ToString();

               if (!string.IsNullOrEmpty(oPersona.NombreUniversidad))
                    comboBoxUniversidad.SelectedIndex = comboBoxUniversidad.FindStringExact(oPersona.NombreUniversidad);
                if (!string.IsNullOrEmpty(oPersona.NombreCarrera))
                    comboBoxCarrera.SelectedIndex = comboBoxCarrera.FindStringExact(oPersona.NombreCarrera);

                textBoxEmail.Text = oPersona.Mail;
                textBoxTelefono.Text = oPersona.Telefono.ToString();

                textBoxCalle.Text = oPersona.Calle;
                if (oPersona.NumeroCalle != 0)
                    textBoxNumero.Text = oPersona.NumeroCalle.ToString();
                if (oPersona.Piso != 0)
                    textBoxPiso.Text = oPersona.Piso.ToString();
                textBoxDepartamento.Text = oPersona.Departamento;
                textBoxObservaciones.Text = oPersona.Observaciones;
            }
        }

        // ########################################################################
        // Eventos de botones
        // ########################################################################

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            validarCampoObligatorio(textBoxApellido);
            validarCampoObligatorio(textBoxNombre);
            validarCampoNumerico(textBoxLegajo);
            if(validarCampoObligatorio(textBoxNumeroDocumento))
                validarCampoNumerico(textBoxNumeroDocumento);
            validarCampoObligatorio(comboBoxTipoDocumento);
            if (!oErrorProviderExtension.HasErrors())
            {
                try
                {
                    PersonaDTO oPersona = new PersonaDTO();

                    oPersona.IdPersona = 0;
                    if (formMode != ABMFormMode.insert)
                        oPersona.IdPersona = oPersonaService.IdPersonaSeleccionada;

                    oPersona.Apellido = textBoxApellido.Text;
                    oPersona.Nombre = textBoxNombre.Text;
                    oPersona.NumeroDocumento = Int32.Parse(textBoxNumeroDocumento.Text);
                    oPersona.NombreTipoDocumento = comboBoxTipoDocumento.SelectedItem.ToString();
                    //       ######################################################################     SOULICION MOMENTANEA PARA TRAER IdTipoDopcumento
                    Dictionary<string, object> parametros = new Dictionary<string, object>();
                    parametros.Add("TipoDocumento", comboBoxTipoDocumento.SelectedItem.ToString());
                    oPersona.IdTipoDocumento = oTipoDocumentoService.GetTipoDocumentoByFilters(parametros).First().IdTipoDocumento; // CORREGIR
                    //       ######################################################################     SOULICION MOMENTANEA PARA TRAER IdTipoDopcumento

                    if (textBoxLegajo.Text != "")
                        oPersona.Legajo = Int32.Parse(textBoxLegajo.Text);
                    if (comboBoxUniversidad.SelectedIndex != 0)
                    {
                        oPersona.NombreUniversidad = comboBoxUniversidad.SelectedItem.ToString();
                        parametros.Clear();
                        parametros.Add("NombreUniversidad", comboBoxUniversidad.SelectedItem.ToString());
                        oPersona.IdUniversidad = oUniversidadService.GetUniversidadByFilters(parametros).First().IdUniversidad; // CORREGIR
                    }
                    if (comboBoxCarrera.SelectedIndex != 0)
                    {

                        oPersona.NombreCarrera = comboBoxCarrera.SelectedItem.ToString();
                        parametros.Clear();
                        parametros.Add("NombreCarrera", comboBoxCarrera.SelectedItem.ToString());
                        oPersona.IdCarrera = oCarreraService.GetCarreraByFilters(parametros).First().IdCarrera; // CORREGIR
                    }

                    oPersona.Mail = textBoxEmail.Text;
                    oPersona.Telefono = textBoxTelefono.Text;

                    oPersona.Calle = textBoxCalle.Text;
                    if (textBoxNumero.Text != "")
                        oPersona.NumeroCalle = Int32.Parse(textBoxNumero.Text);
                    if (textBoxPiso.Text != "")
                        oPersona.Piso = Int32.Parse(textBoxPiso.Text);
                    oPersona.Departamento = textBoxDepartamento.Text;
                    oPersona.Observaciones = textBoxObservaciones.Text;


                    switch (formMode)
                    {
                        case ABMFormMode.insert:
                            oPersonaService.InsertPersona(oPersona);
                            this.Close();
                            break;
                        case ABMFormMode.update:
                            oPersonaService.UpdatePersonaById(oPersona);
                            this.Close();
                            break;
                        case ABMFormMode.delete:
                            if (MessageBox.Show("¿Seguro que quiere eliminar" + oPersona.Nombre + ", " + oPersona.Apellido + "?", "Confirmar Eliminacion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                oPersonaService.DeletePersonaById(oPersona.IdPersona);
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

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // ########################################################################
        // Eventos Validating y KeyPress
        // ########################################################################
        private void TextBoxNumericos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void TextBoxApellidoyNombre_Validating(object sender, CancelEventArgs e)
        {
            TextBox oEventSender = (TextBox)sender;
            validarCampoObligatorio(oEventSender);
        }

        private void ComboBoxTipoDocumento_Validating(object sender, CancelEventArgs e)
        {
            ComboBox oEventSender = (ComboBox)sender;
            validarCampoObligatorio(oEventSender);
        }

        private void TextBoxNumeroDocumento_Validating(object sender, CancelEventArgs e)
        {
            TextBox oEventSender = (TextBox)sender;
            if(validarCampoObligatorio(oEventSender))
                validarCampoNumerico(oEventSender);
        }

        private void TextBoxPisoYNumero_Validating(object sender, CancelEventArgs e)
        {
            TextBox oEventSender = (TextBox)sender;
            validarCampoNumerico(oEventSender);
        }

        private void TextBoxLegajo_Validating(object sender, CancelEventArgs e)
        {
            TextBox oEventSender = (TextBox)sender;
            validarCampoNumerico(oEventSender);
        }

        private bool validarCampoNumerico(TextBox oEventSender)
        {
            string errorString = "";
            foreach (char oChar in oEventSender.Text)
            {
                if (!(char.IsDigit(oChar)))
                {
                    errorString += "El " + oEventSender.Text + " debe ser un numero entero mayor que 0";
                    break;
                }
            }
            oErrorProviderExtension.SetErrorWithCount(oEventSender, errorString);
            return errorString == "";
        }

        private bool validarCampoObligatorio(ComboBox oEventSender)
        {
            string errorString = "";
            if (oEventSender.SelectedIndex == 0)
                errorString += "El " + oEventSender.Name + " es un campo obligatorio";

            oErrorProviderExtension.SetErrorWithCount(oEventSender, errorString);
            return errorString == "";
        }

        private bool validarCampoObligatorio(TextBox oEventSender)
        {
            string errorString = "";
            if (string.IsNullOrEmpty(oEventSender.Text))
                errorString += "El " + oEventSender.Name + " es un campo obligatorio";

            oErrorProviderExtension.SetErrorWithCount(oEventSender, errorString);
            return errorString == "";
        }

    }
}
