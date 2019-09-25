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
    public partial class FrmPersonas : Form
    {
        PersonaService oPersonaService;
        private ErrorProviderExtension oErrorProviderExtension;

        public FrmPersonas()
        {
            InitializeComponent();
            
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.CenterToScreen();
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmPersonas_Load(object sender, EventArgs e)
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            oErrorProviderExtension = new ErrorProviderExtension(errorProvider);
            oPersonaService = new PersonaService();
            
            cargarCombos();
            setTextBoxLimits();
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
        }
        // ##############################################################################################################################
        // ACA van los eventos de los botones
        // ##############################################################################################################################

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            dgvPersonas.Rows.Clear();
            if (!oErrorProviderExtension.HasErrors())
            {   
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                if (!string.IsNullOrEmpty(textBoxLegajo.Text))
                    parametros.Add("Legajo", textBoxLegajo.Text);
                if (!string.IsNullOrEmpty(textBoxApellido.Text))
                    parametros.Add("Apellido", textBoxApellido.Text);
                if (!string.IsNullOrEmpty(textBoxNombre.Text))
                    parametros.Add("Nombre", textBoxNombre.Text);
                if (!string.IsNullOrEmpty(textBoxNumeroDocumento.Text))
                    parametros.Add("NumeroDocumento", textBoxNumeroDocumento.Text);
                if (comboBoxTipoDocumento.SelectedIndex != 0)
                    parametros.Add("TipoDocumento", comboBoxTipoDocumento.SelectedValue.ToString());
            
            
                IList<PersonaDTO> busqueda = oPersonaService.GetPersonaByFilters(parametros);
                foreach (PersonaDTO oPersona in busqueda)
                {
                    dgvPersonas.Rows.Add(new object[] { oPersona.IdPersona.ToString(), oPersona.Legajo.ToString(), oPersona.NumeroDocumento.ToString(), oPersona.NombreTipoDocumento, oPersona.IdTipoDocumento.ToString(), oPersona.Apellido, oPersona.Nombre });
                }
            }
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            FrmPersonaEdicion alta = new FrmPersonaEdicion(oPersonaService, FrmPersonaEdicion.ABMFormMode.insert);
            alta.ShowDialog();
            dgvPersonas.Rows.Clear();
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
            }
            else
            {
                oPersonaService.IdPersonaSeleccionada = Int32.Parse(dgvPersonas.CurrentRow.Cells["IdPersona"].Value.ToString());
                FrmPersonaEdicion alta = new FrmPersonaEdicion(oPersonaService, FrmPersonaEdicion.ABMFormMode.delete);
                alta.ShowDialog();
                dgvPersonas.Rows.Clear();
            }
        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
            }
            else
            {
                oPersonaService.IdPersonaSeleccionada = Int32.Parse(dgvPersonas.CurrentRow.Cells["IdPersona"].Value.ToString());
                FrmPersonaEdicion alta = new FrmPersonaEdicion(oPersonaService, FrmPersonaEdicion.ABMFormMode.update);
                alta.ShowDialog();
                dgvPersonas.Rows.Clear();
            }
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// ########################################################################################################################
        /// ##################          KeyPress y Validating Events           ######################################################
        /// ########################################################################################################################
       
        private void TextBoxLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void TextBoxNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void TextBoxLegajo_Validating(object sender, CancelEventArgs e)
        {
            TextBox oEventSender = (TextBox)sender;
            validarCampoNumerico(oEventSender);
        }

        private void TextBoxNumeroDocumento_Validating(object sender, CancelEventArgs e)
        {
            TextBox oEventSender = (TextBox)sender;
            validarCampoNumerico(oEventSender);
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
    }
}
