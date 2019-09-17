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

namespace CEE.Interfaz
{
    public partial class FrmPersonaEdicion : Form
    {
        private PersonaService oPersonaService;
        private TipoDocumentoService oTipoDocumentoService;

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
            cargarCombos();
            habilitarCampos();
            cargarDatos();
        }

        private void cargarCombos()
        {
            IList<TipoDocumentoDTO> tiposDocumentos = oTipoDocumentoService.GetTipoDocumentoByFilters(new Dictionary<string, object>());
            List<string> content = new List<string>();

            content.Add("Seleccionar");
            foreach (TipoDocumentoDTO oTipoDocumento in tiposDocumentos)
                content.Add(oTipoDocumento.NombreTipoDocumento);

            comboBoxTipoDocumento.DataSource = content;
        }

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

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxLegajo.Text) || string.IsNullOrWhiteSpace(textBoxLegajo.Text))
                    throw new Exception("Legajo no puede ser vacio ni negativo");
                if (string.IsNullOrEmpty(textBoxApellido.Text) || string.IsNullOrWhiteSpace(textBoxApellido.Text))
                    throw new Exception("Apellido no puede ser vacio");
                if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrWhiteSpace(textBoxNombre.Text))
                    throw new Exception("Nombre no puede ser vacio");
                if (comboBoxTipoDocumento.SelectedIndex == 0)
                    throw new Exception("Debe seleccionar un Tipo de Documento");
                if (string.IsNullOrEmpty(textBoxNumeroDocumento.Text) || string.IsNullOrWhiteSpace(textBoxNumeroDocumento.Text))
                    throw new Exception("Numero de Documento no puede ser vacio");

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

                
                if (textBoxTelefono.Text != "")
                    oPersona.Telefono = Int32.Parse(textBoxTelefono.Text);

                oPersona.Calle = textBoxCalle.Text;
                if (textBoxNumero.Text != "")
                    oPersona.NumeroCalle = Int32.Parse(textBoxNumero.Text);
                if (textBoxPiso.Text != "")
                    oPersona.Piso = Int32.Parse(textBoxPiso.Text);
                oPersona.Departamento = textBoxDepartamento.Text;
                oPersona.Observaciones = textBoxObservaciones.Text;

                //       ######################################################################     SOULICION MOMENTANEA PARA TRAER IdTipoEquipo
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("TipoDocumento", comboBoxTipoDocumento.SelectedItem.ToString());
                oPersona.IdTipoDocumento = oTipoDocumentoService.GetTipoDocumentoByFilters(parametros).First().IdTipoDocumento; // CORREGIR
                //       ######################################################################     SOULICION MOMENTANEA PARA TRAER IdTipoEquipo

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

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
