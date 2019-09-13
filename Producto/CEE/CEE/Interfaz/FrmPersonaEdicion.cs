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
    public partial class FrmPersonaEdicion : Form
    {
        public ABMFormMode formMode = ABMFormMode.insert;
        public enum ABMFormMode
        {
            insert,
            update,
            delete
        }

        public FrmPersonaEdicion()
        {
            InitializeComponent();
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

        }

        private void cargarDatos()
        {

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

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
