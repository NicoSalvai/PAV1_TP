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
    public partial class FrmEquipos : Form
    {
        EquipoService oEquipoService;
        public FrmEquipos()
        {
            InitializeComponent();
            oEquipoService = new EquipoService();
            cargarCombos();
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
        }


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

            IList<EquipoDTO> busqueda = oEquipoService.GetEquipoByFilters(parametros);
            foreach (EquipoDTO oEquipo in busqueda)
            {
                dgvEquipos.Rows.Add(new object[] { oEquipo.IdEquipo.ToString(), oEquipo.Codigo, oEquipo.TipoEquipo, oEquipo.Nombre, oEquipo.Descripcion });
            }
        }


        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            FrmEquipoEdicion alta = new FrmEquipoEdicion(oEquipoService);
            alta.formMode = FrmEquipoEdicion.ABMFormMode.insert;
            alta.ShowDialog();
        }


        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.CurrentRow == null) 
            {
                MessageBox.Show("Seleccione un registro");
            }
            else
            {
                int idEquipoSeleccionado = Int32.Parse(dgvEquipos.CurrentRow.Cells["IdEquipo"].Value.ToString());
                oEquipoService.IdEquipoSelected = idEquipoSeleccionado;

                FrmEquipoEdicion alta = new FrmEquipoEdicion(oEquipoService);
                alta.formMode = FrmEquipoEdicion.ABMFormMode.delete;
                alta.ShowDialog();
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
                int idEquipoSeleccionado = Int32.Parse(dgvEquipos.CurrentRow.Cells["IdEquipo"].Value.ToString());
                oEquipoService.IdEquipoSelected = idEquipoSeleccionado;

                FrmEquipoEdicion alta = new FrmEquipoEdicion(oEquipoService);
                alta.formMode = FrmEquipoEdicion.ABMFormMode.update;
                alta.ShowDialog();
            }
        }


        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
