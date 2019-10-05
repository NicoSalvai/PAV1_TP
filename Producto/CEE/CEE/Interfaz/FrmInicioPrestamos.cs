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
    public partial class FrmInicioPrestamos : Form
    {
        private PersonaService oPersonaService;
        private EquipoService oEquipoService;
        private ErrorProviderExtension oErrorProviderExtension;
        private FormMode formMode = FormMode.noSeleccionado;

        public enum FormMode
        {
            noSeleccionado,
            seleccionado
        }
        public FrmInicioPrestamos()
        {
            InitializeComponent();

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.CenterToScreen();
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmInicioPrestamos_Load(object sender, EventArgs e)
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            oErrorProviderExtension = new ErrorProviderExtension(errorProvider);
            formMode = FormMode.noSeleccionado;
            oPersonaService = new PersonaService();
            oEquipoService = new EquipoService();

            cargarCombos();
            setTextBoxLimits();
            habilitarCampos();
        }

        /// <summary>
        /// Levanta los datos necesarios atraves de servicios para cargar los combos
        /// Levanta Tipos de Documento a partir de TipoDocumentoService en forma de TipoDocumentoDTO
        /// </summary>
        private void cargarCombos()
        {
            IList<TipoDocumentoDTO> tiposDocumentos = new TipoDocumentoService().GetTipoDocumentoByFilters(new Dictionary<string, object>());
            List<string> content = new List<string>();

            content.Add("Seleccionar");
            foreach (TipoDocumentoDTO oTipoDocumento in tiposDocumentos)
            {
                content.Add(oTipoDocumento.NombreTipoDocumento);
            }
            comboBoxTipoDocumento.DataSource = content;
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
        }


        /// <summary>
        /// Se habilitan o deshabilitan los campos que haga falta segun el modo en que estemos
        /// </summary>
        private void habilitarCampos()
        {
            textBoxLegajo.Enabled = false;
            textBoxApellido.Enabled = false;
            textBoxNombre.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxTelefono.Enabled = false;
            if (formMode == FormMode.noSeleccionado)
            {
                textBoxCodigo.Enabled = false;
                textBoxFechaHasta.Enabled = false;
                checkBoxToday.Enabled = false;
                buttonAgregar.Enabled = false;
                buttonCancelarSeleccionados.Enabled = false;
                dgvPrestamo.Enabled = false;
                buttonConfirmar.Enabled = false;
            }
            else if(formMode == FormMode.seleccionado)
            {
                textBoxCodigo.Enabled = true;
                if(!checkBoxToday.Checked)
                    textBoxFechaHasta.Enabled = true;
                checkBoxToday.Enabled = true;
                buttonAgregar.Enabled = true;
                buttonCancelarSeleccionados.Enabled = true;
                dgvPrestamo.Enabled = true;
                buttonConfirmar.Enabled = true;
            }
        }


        /// <summary>
        /// si estamos en modo update o delete cargo los datos de la Persona Seleccionada en la otra pantalla
        /// </summary>
        private void cargarDatos(PersonaDTO oPersona)
        {
            textBoxApellido.Text = oPersona.Apellido;
            textBoxNombre.Text = oPersona.Nombre;
            comboBoxTipoDocumento.SelectedIndex = comboBoxTipoDocumento.FindStringExact(oPersona.NombreTipoDocumento);
            textBoxNumeroDocumento.Text = oPersona.NumeroDocumento.ToString();

            if (oPersona.Legajo != 0)
                textBoxLegajo.Text = oPersona.Legajo.ToString();

            textBoxEmail.Text = oPersona.Mail;
            textBoxTelefono.Text = oPersona.Telefono.ToString();

        }
        private void limpiarDatos()
        {
            textBoxApellido.Text = "";
            textBoxNombre.Text = "";

            textBoxLegajo.Text = "";

            textBoxEmail.Text = "";
            textBoxTelefono.Text = "";

            oPersonaService.IdPersonaSeleccionada = 0;
        }

        private bool cargarEquipoGrilla(EquipoDTO oEquipo)
        {
            foreach (DataGridViewRow row in dgvPrestamo.Rows)
            {
                if (row.Cells["IdEquipo"].Value.ToString() == oEquipo.IdEquipo.ToString())
                    return false;
            }

            dgvPrestamo.Rows.Add(new object[] { oEquipo.IdEquipo.ToString(), oEquipo.Codigo.ToString(), oEquipo.Nombre.ToString(), oEquipo.IdTipoEquipo.ToString(), oEquipo.TipoEquipo.ToString()});
            return true;
        }
        // ##############################################################################################################################
        // ACA van los eventos de los botones
        // ##############################################################################################################################

        private void ButtonSeleccionar_Click(object sender, EventArgs e)
        {
            
            if (validarCampoObligatorio(textBoxNumeroDocumento))
                validarCampoNumerico(textBoxNumeroDocumento);
            validarCampoObligatorio(comboBoxTipoDocumento);
            limpiarDatos();
            formMode = FormMode.noSeleccionado;
            habilitarCampos();
            if (!oErrorProviderExtension.HasErrors())
            {
                try
                {
                    Dictionary<string, object> parametros = new Dictionary<string, object>();
                    parametros.Add("NumeroDocumento", textBoxNumeroDocumento.Text);
                    parametros.Add("TipoDocumento", comboBoxTipoDocumento.SelectedValue.ToString());

                    IList<PersonaDTO> busqueda = oPersonaService.GetPersonaByFilters(parametros);
                    PersonaDTO oPersona;
                    if (busqueda.Count == 1)
                        oPersona = busqueda.First();
                    else
                        throw new Exception("Persona no Encontrada");

                    oPersonaService.IdPersonaSeleccionada = oPersona.IdPersona;

                    cargarDatos(oPersona);
                    formMode = FormMode.seleccionado;
                    habilitarCampos();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            }

        private void ButtonBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxCodigo.Text))
                    throw new Exception("Ingrese un codigo");

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("CodigoEquals", textBoxCodigo.Text);
                IList<EquipoDTO> busqueda = oEquipoService.GetEquipoByFilters(parametros);

                if (busqueda.Count == 0)
                    throw new Exception("El codigo buscado no existe");

                if (!cargarEquipoGrilla(busqueda.First()))
                {
                    throw new Exception("El Equipo ya fue ingresado a la lista anteriormente");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ButtonCancelarSeleccionados_Click(object sender, EventArgs e)
        {
            if(dgvPrestamo.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
            }
            else
            {
                dgvPrestamo.Rows.Remove(dgvPrestamo.CurrentRow);
            }
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrestamo.Rows.Count < 1)
                    throw new Exception("Debe cargar al menos un equipo para prestar");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        /// ########################################################################################################################
        /// ##################          KeyPress y Validating Events           ######################################################
        /// ########################################################################################################################

        private void TextBoxNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void validarCampoNumerico(TextBox oEventSender)
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

        private void CheckBoxToday_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxToday.Checked)
            {
                textBoxFechaHasta.Enabled = true;
            }
            else
            {
                textBoxFechaHasta.Enabled = false;
            }
        }
    }
}
