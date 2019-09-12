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
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(textBoxCodigo.Text))
                parametros.Add("Codigo", textBoxCodigo.Text);
            if (!string.IsNullOrEmpty(textBoxNombre.Text))
                parametros.Add("Nombre", textBoxNombre.Text);
            if (comboBoxTipoEquipo.SelectedIndex != -1)
                parametros.Add("TipoEquipo", comboBoxTipoEquipo.SelectedValue.ToString());


            IList<EquipoDTO> busqueda = oEquipoService.GetEquipoByFilters(parametros);
            dgvEquipos.Rows.Clear();

            foreach (EquipoDTO oEquipo in busqueda)
            {
                dgvEquipos.Rows.Add(new object[] { oEquipo.IdEquipo.ToString(), oEquipo.Codigo, oEquipo.TipoEquipo, oEquipo.Nombre, oEquipo.Descripcion });
            }
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {

        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
