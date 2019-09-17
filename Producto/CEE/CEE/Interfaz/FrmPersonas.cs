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
    public partial class FrmPersonas : Form
    {
        PersonaService oPersonaService;
        public FrmPersonas()
        {
            InitializeComponent();
            oPersonaService = new PersonaService();
            cargarCombos();
        }

        /// <summary>
        /// Levanta los datos necesarios atraves de servicios para cargar los combos
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

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            dgvPersonas.Rows.Clear();

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

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            FrmPersonaEdicion alta = new FrmPersonaEdicion(oPersonaService);
            alta.formMode = FrmPersonaEdicion.ABMFormMode.insert;
            alta.ShowDialog();
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
            }
            else
            {
                int idPersonaSeleccionada = Int32.Parse(dgvPersonas.CurrentRow.Cells["IdPersona"].Value.ToString());
                oPersonaService.IdPersonaSeleccionada = idPersonaSeleccionada;

                FrmPersonaEdicion alta = new FrmPersonaEdicion(oPersonaService);
                alta.formMode = FrmPersonaEdicion.ABMFormMode.delete;
                alta.ShowDialog();
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
                int idPersonaSeleccionada = Int32.Parse(dgvPersonas.CurrentRow.Cells["IdPersona"].Value.ToString());
                oPersonaService.IdPersonaSeleccionada = idPersonaSeleccionada;

                FrmPersonaEdicion alta = new FrmPersonaEdicion(oPersonaService);
                alta.formMode = FrmPersonaEdicion.ABMFormMode.update;
                alta.ShowDialog();
            }
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
