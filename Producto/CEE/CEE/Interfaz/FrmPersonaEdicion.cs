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
        private ErrorProviderExtension oErrorProviderExtension;

        public ABMFormMode formMode = ABMFormMode.insert;
        public enum ABMFormMode
        {
            insert,
            update,
            delete
        }

        public FrmPersonaEdicion(PersonaService oPersonaService)
        {
            InitializeComponent();

            this.oPersonaService = oPersonaService;
            this.oTipoDocumentoService = new TipoDocumentoService();
        }

        private void FrmPersonaEdicion_Load(object sender, EventArgs e)
        {
            oErrorProviderExtension = new ErrorProviderExtension(errorProvider);
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            setLabels();
            cargarCombos();
            habilitarCampos();
            cargarDatos();

            textBoxLegajo.MaxLength = 10;
            textBoxNumeroDocumento.MaxLength = 10;
            textBoxApellido.MaxLength = 30;
            textBoxNombre.MaxLength = 30;
            textBoxTelefono.MaxLength = 30;
            textBoxEmail.MaxLength = 30;
            textBoxCalle.MaxLength = 30;
            textBoxDepartamento.MaxLength = 30;
            textBoxObservaciones.MaxLength = 30;
            textBoxNumero.MaxLength = 10;
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
        }

        /// <summary>
        /// si estamos en modo update o delete cargo los datos de la Persona Seleccionada en la otra pantalla
        /// </summary>
        private void cargarDatos()
        {
            if (formMode == ABMFormMode.update || formMode == ABMFormMode.delete)
            {
                PersonaDTO oPersona = oPersonaService.GetPersonaById(oPersonaService.IdPersonaSeleccionada);

                textBoxLegajo.Text = oPersona.Legajo.ToString();
                textBoxApellido.Text = oPersona.Apellido;
                textBoxNombre.Text = oPersona.Nombre;
                comboBoxTipoDocumento.SelectedIndex = comboBoxTipoDocumento.FindStringExact(oPersona.NombreTipoDocumento);
                textBoxNumeroDocumento.Text = oPersona.NumeroDocumento.ToString();

                textBoxEmail.Text = oPersona.Mail;
                textBoxTelefono.Text = oPersona.Telefono.ToString();

                textBoxCalle.Text = oPersona.Calle;
                textBoxNumero.Text = oPersona.NumeroCalle.ToString();
                textBoxPiso.Text = oPersona.Piso.ToString();
                textBoxDepartamento.Text = oPersona.Departamento;
                textBoxObservaciones.Text = oPersona.Observaciones;
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
            }
        }

        // ########################################################################
        // Eventos de botones
        // ########################################################################

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            validarApellidoYNombre(textBoxApellido);
            validarApellidoYNombre(textBoxNombre);
            validarLegajoYNumeroDocumento(textBoxLegajo);
            validarLegajoYNumeroDocumento(textBoxNumeroDocumento);
            ValidarTipoDocumento(comboBoxTipoDocumento);
            if (!oErrorProviderExtension.HasErrors())
            {
                try
                {
                    PersonaDTO oPersona = new PersonaDTO();

                    oPersona.IdPersona = 0;
                    if (formMode != ABMFormMode.insert)
                        oPersona.IdPersona = oPersonaService.IdPersonaSeleccionada;

                    oPersona.Legajo = Int32.Parse(textBoxLegajo.Text);
                    oPersona.Apellido = textBoxApellido.Text;
                    oPersona.Nombre = textBoxNombre.Text;
                    oPersona.NombreTipoDocumento = comboBoxTipoDocumento.SelectedItem.ToString();
                    oPersona.NumeroDocumento = Int32.Parse(textBoxNumeroDocumento.Text);

                    oPersona.Mail = textBoxEmail.Text;
                    oPersona.Telefono = (textBoxTelefono.Text);

                    oPersona.Calle = textBoxCalle.Text;
                    if (textBoxNumero.Text != "")
                        oPersona.NumeroCalle = Int32.Parse(textBoxNumero.Text);
                    if (textBoxPiso.Text != "")
                        oPersona.Piso = Int32.Parse(textBoxPiso.Text);
                    oPersona.Departamento = textBoxDepartamento.Text;
                    oPersona.Observaciones = textBoxObservaciones.Text;

                    //       ######################################################################     SOULICION MOMENTANEA PARA TRAER IdTipoDopcumento
                    Dictionary<string, object> parametros = new Dictionary<string, object>();
                    parametros.Add("TipoDocumento", comboBoxTipoDocumento.SelectedItem.ToString());
                    oPersona.IdTipoDocumento = oTipoDocumentoService.GetTipoDocumentoByFilters(parametros).First().IdTipoDocumento; // CORREGIR
                    //       ######################################################################     SOULICION MOMENTANEA PARA TRAER IdTipoDopcumento

                    if (formMode == ABMFormMode.update)
                    {
                        oPersonaService.UpdatePersonaById(oPersona);
                        this.Dispose();
                    }
                    else if (formMode == ABMFormMode.insert)
                    {
                        oPersonaService.InsertPersona(oPersona);
                        this.Dispose();
                    }
                    else if (formMode == ABMFormMode.delete)
                    {
                        if (MessageBox.Show("¿Seguro que quiere eliminar" + oPersona.Nombre + ", " + oPersona.Apellido + "?", "Confirmar Eliminacion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            oPersonaService.DeletePersonaById(oPersona.IdPersona);
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
            validarApellidoYNombre(oEventSender);
        }
        private void validarApellidoYNombre(TextBox oEventSender)
        {
            string errorString = "";

            if (string.IsNullOrEmpty(oEventSender.Text))
                errorString += "El " + oEventSender.Name + " es un campo obligatorio";

            oErrorProviderExtension.SetErrorWithCount(oEventSender, errorString);
        }

        private void ComboBoxTipoDocumento_Validating(object sender, CancelEventArgs e)
        {
            ComboBox oEventSender = (ComboBox)sender;
            ValidarTipoDocumento(oEventSender);
        }
        private void ValidarTipoDocumento(ComboBox oEventSender)
        {
            string errorString = "";

            if (oEventSender.SelectedIndex == 0)
                errorString += "El " + oEventSender.Name + " es un campo obligatorio";

            oErrorProviderExtension.SetErrorWithCount(oEventSender, errorString);
        }

        private void TextBoxLegajoyNumeroDocumento_Validating(object sender, CancelEventArgs e)
        {
            TextBox oEventSender = (TextBox)sender;
            validarLegajoYNumeroDocumento(oEventSender);
        }
        private void validarLegajoYNumeroDocumento(TextBox oEventSender)
        {
            string errorString = "";

            if (string.IsNullOrEmpty(oEventSender.Text))
                errorString += "El " + oEventSender.Name + " es un campo obligatorio";

            foreach (char oChar in oEventSender.Text)
            {
                if (!(char.IsDigit(oChar)))
                {
                    errorString += "El " + oEventSender.Name + " debe ser un numero entero mayor que 0";
                    break;
                }
            }

            oErrorProviderExtension.SetErrorWithCount(oEventSender, errorString);
        }

        private void TextBoxPisoYNumero_Validating(object sender, CancelEventArgs e)
        {
            TextBox oEventSender = (TextBox)sender;
            validarPisoYNumero(oEventSender);
        }

        private void validarPisoYNumero(TextBox oEventSender)
        {
            string errorString = "";

            foreach (char oChar in oEventSender.Text)
            {
                if (!(char.IsDigit(oChar)))
                {
                    errorString += "El " + oEventSender.Name + " debe ser un numero entero mayor que 0";
                    break;
                }
            }

            oErrorProviderExtension.SetErrorWithCount(oEventSender, errorString);
        }
    }
}
