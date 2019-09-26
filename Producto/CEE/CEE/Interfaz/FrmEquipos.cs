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
    public partial class FrmEquipos : Form
    {
        EquipoService oEquipoService;

        public FrmEquipos()
        {
            InitializeComponent();

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.CenterToScreen();
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmEquipos_Load(object sender, EventArgs e)
        {
            oEquipoService = new EquipoService();

            cargarCombos();
            setTextBoxLimits();
        }

        /// <summary>
        /// Levanta los datos necesarios atraves de servicios para cargar los combos de la interfaz
        /// </summary>
        private void cargarCombos()
        {
            IList<TipoEquipoDTO> tiposEquipos = new TipoEquipoService().GetTipoEquipoByFilters(new Dictionary<string, object>());
            List<string> content = new List<string>();

            content.Add("Seleccionar");
            foreach (TipoEquipoDTO tipoEquipo in tiposEquipos)
                content.Add(tipoEquipo.NombreTipoEquipo);

            comboBoxTipoEquipo.DataSource = content;

            // ######################################
            IList<EstadoDTO> estados = new EstadoService().GetEstadoByFilters(new Dictionary<string, object>());
            List<string> contentEstados = new List<string>();

            contentEstados.Add("Seleccionar");
            foreach (EstadoDTO estado in estados)
                contentEstados.Add(estado.NombreEstado);

            comboBoxEstado.DataSource = contentEstados;
        }

        /// <summary>
        /// Setea el largo maximo para los campos textBox iguales a los seteados en la BD
        /// </summary>
        private void setTextBoxLimits()
        {
            textBoxNombre.MaxLength = 20;
            textBoxCodigo.MaxLength = 20;
        }

        // ########################################################################
        // Eventos de los botones
        // ########################################################################
        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            dgvEquipos.Rows.Clear();

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(textBoxCodigo.Text))
                parametros.Add("Codigo", textBoxCodigo.Text);
            if (!string.IsNullOrEmpty(textBoxNombre.Text))
                parametros.Add("Nombre", textBoxNombre.Text);
            if (comboBoxTipoEquipo.SelectedIndex != 0)
                parametros.Add("TipoEquipo", comboBoxTipoEquipo.SelectedValue.ToString());
            if (comboBoxEstado.SelectedIndex != 0)
                parametros.Add("Estado", comboBoxEstado.SelectedValue.ToString());

            IList<EquipoDTO> busqueda = oEquipoService.GetEquipoByFilters(parametros);
            foreach (EquipoDTO oEquipo in busqueda)
            {
                dgvEquipos.Rows.Add(new object[] { oEquipo.IdEquipo.ToString(), oEquipo.Codigo, oEquipo.TipoEquipo, oEquipo.Nombre, oEquipo.Descripcion, oEquipo.Estado });
            }
        }


        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            FrmEquipoEdicion alta = new FrmEquipoEdicion(oEquipoService, FrmEquipoEdicion.ABMFormMode.insert);
            alta.ShowDialog();
            dgvEquipos.Rows.Clear();
        }


        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.CurrentRow == null) 
            {
                MessageBox.Show("Seleccione un registro");
            }
            else
            {
                oEquipoService.IdEquipoSelected = Int32.Parse(dgvEquipos.CurrentRow.Cells["IdEquipo"].Value.ToString());
                FrmEquipoEdicion alta = new FrmEquipoEdicion(oEquipoService, FrmEquipoEdicion.ABMFormMode.delete);
                alta.ShowDialog();
                dgvEquipos.Rows.Clear();
            }
        }


        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
            }
            else
            {
                oEquipoService.IdEquipoSelected = Int32.Parse(dgvEquipos.CurrentRow.Cells["IdEquipo"].Value.ToString());
                FrmEquipoEdicion alta = new FrmEquipoEdicion(oEquipoService, FrmEquipoEdicion.ABMFormMode.update);
                alta.ShowDialog();
                dgvEquipos.Rows.Clear();
            }
        }


        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
