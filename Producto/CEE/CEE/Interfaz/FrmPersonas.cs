using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEE.Interfaz
{
    public partial class FrmPersonas : Form
    {
        public FrmPersonas()
        {
            InitializeComponent();
            cargarCombos();
        }

        private void cargarCombos() {

        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            FrmPersonaEdicion alta = new FrmPersonaEdicion();
            alta.formMode = FrmPersonaEdicion.ABMFormMode.insert;
            alta.ShowDialog();
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (false)//dgvEquipos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
            }
            else
            {
                //int idEquipoSeleccionado = Int32.Parse(dgvEquipos.CurrentRow.Cells["IdEquipo"].Value.ToString());
                //oEquipoService.IdEquipoSelected = idEquipoSeleccionado;

                FrmPersonaEdicion alta = new FrmPersonaEdicion();
                alta.formMode = FrmPersonaEdicion.ABMFormMode.delete;
                alta.ShowDialog();
            }
        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            if (false)//dgvEquipos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
            }
            else
            {
                //int idEquipoSeleccionado = Int32.Parse(dgvEquipos.CurrentRow.Cells["IdEquipo"].Value.ToString());
                //oEquipoService.IdEquipoSelected = idEquipoSeleccionado;

                FrmPersonaEdicion alta = new FrmPersonaEdicion();
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
