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
    public partial class FrmFinalizarPrestamo : Form
    {
        private PersonaService oPersonaService;
        private EquipoService oEquipoService;
        private PrestamoService oPrestamoService;

        private ErrorProviderExtension oErrorProviderExtension;
        
        public FrmFinalizarPrestamo()
        {
            InitializeComponent();

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.CenterToScreen();
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmFinalizarPrestamo_Load(object sender, EventArgs e)
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            oErrorProviderExtension = new ErrorProviderExtension(errorProvider);
            

            oPersonaService = new PersonaService();
            oEquipoService = new EquipoService();
            oPrestamoService = new PrestamoService();

            cargarCombos();
        }


        /// <summary>
        /// Levanta los datos necesarios atraves de servicios para cargar los combos
        /// Levanta Tipos de Documento a partir de TipoDocumentoService en forma de TipoDocumentoDTO
        /// </summary>
        private void cargarCombos()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("NombreEstado", "EN CURSO"); // DEVUELTO PARCIAL
            IList<PrestamoDTO> prestamosEnCurso = oPrestamoService.GetPrestamoByFilters(parametros);

            foreach (PrestamoDTO oPrestamo in prestamosEnCurso)
            {
                dgvPrestamos.Rows.Add(new object[] { oPrestamo.IdPrestamo, oPrestamo.IdPersona, oPrestamo.NumeroDocumentoPersona, oPrestamo.IdTipoDocumentoPersona,
                oPrestamo.NombreTipoDocumentoPersona, oPrestamo.ApellidoPersona, oPrestamo.NombrePersona, oPrestamo.LegajoPersona, oPrestamo.FechaHastaEstimada.ToShortDateString()});
            }

            parametros.Clear();
            parametros.Add("NombreEstado", "DEVUELTO PARCIAL"); 
            prestamosEnCurso = oPrestamoService.GetPrestamoByFilters(parametros);

            foreach (PrestamoDTO oPrestamo in prestamosEnCurso)
            {
                dgvPrestamos.Rows.Add(new object[] { oPrestamo.IdPrestamo, oPrestamo.IdPersona, oPrestamo.NumeroDocumentoPersona, oPrestamo.IdTipoDocumentoPersona,
                oPrestamo.NombreTipoDocumentoPersona, oPrestamo.ApellidoPersona, oPrestamo.NombrePersona, oPrestamo.LegajoPersona, oPrestamo.FechaHastaEstimada.ToShortDateString()});
            }
        }

        // ##############################################################################################################################
        // ACA van los eventos de los botones
        // ##############################################################################################################################

        private void ButtonDevolverTodo_Click(object sender, EventArgs e)
        {
            if(dgvDetalles.Rows.Count != 0)
            {
                PrestamoDTO oPrestamo = new PrestamoDTO();

                oPrestamo.IdPrestamo = Int32.Parse(dgvPrestamos.CurrentRow.Cells["IdPrestamo"].Value.ToString());
                oPrestamo.Detalles = new List<DetallePrestamoDTO>();

                foreach (DataGridViewRow dgvRow in dgvDetalles.Rows)
                {
                    DetallePrestamoDTO oDetallePrestamo = new DetallePrestamoDTO();
                    oDetallePrestamo.IdDetallePrestamo = Int32.Parse(dgvRow.Cells["IdDetallePrestamo"].Value.ToString());
                    oDetallePrestamo.IdPrestamo = oPrestamo.IdPrestamo;
                    oDetallePrestamo.IdEquipo = Int32.Parse(dgvRow.Cells["IdEquipo"].Value.ToString());
                    oDetallePrestamo.Devuelto = true;
                    oPrestamo.Detalles.Add(oDetallePrestamo);
                }

                oPrestamoService.UpdatePrestamoById(oPrestamo);
                dgvPrestamos.Rows.Remove(dgvPrestamos.CurrentRow);
                dgvDetalles.Rows.Clear();
            }
        }

        private void ButtonDevolverParcial_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.Rows.Count != 0)
            {
                PrestamoDTO oPrestamo = new PrestamoDTO();

                oPrestamo.IdPrestamo = Int32.Parse(dgvPrestamos.CurrentRow.Cells["IdPrestamo"].Value.ToString());
                oPrestamo.Detalles = new List<DetallePrestamoDTO>();

                foreach (DataGridViewRow dgvRow in dgvDetalles.Rows)
                {
                    DetallePrestamoDTO oDetallePrestamo = new DetallePrestamoDTO();
                    oDetallePrestamo.IdDetallePrestamo = Int32.Parse(dgvRow.Cells["IdDetallePrestamo"].Value.ToString());
                    oDetallePrestamo.IdPrestamo = oPrestamo.IdPrestamo;
                    oDetallePrestamo.IdEquipo = Int32.Parse(dgvRow.Cells["IdEquipo"].Value.ToString());
                    oDetallePrestamo.Devuelto = Boolean.Parse(dgvRow.Cells["Devolver"].Value.ToString());
                    oPrestamo.Detalles.Add(oDetallePrestamo);
                }

                oPrestamoService.UpdatePrestamoById(oPrestamo);
                dgvPrestamos.Rows.Clear();
                cargarCombos();
                dgvDetalles.Rows.Clear();
            }
        }

        // ######################################################################################################

        private void DgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDetalles.Rows.Clear();
            PrestamoDTO oPrestamo = oPrestamoService.GetPrestamoById(Int32.Parse(dgvPrestamos.CurrentRow.Cells["IdPrestamo"].Value.ToString()));

            foreach (DetallePrestamoDTO oDetalle in oPrestamo.Detalles)
            {
                if (!oDetalle.Devuelto)
                {
                    dgvDetalles.Rows.Add(new object[] { oDetalle.IdDetallePrestamo, oDetalle.IdEquipo, oDetalle.CodigoEquipo, oDetalle.NombreEquipo,
                    oDetalle.IdTipoEquipo, oDetalle.NombreTipoEquipo, oDetalle.Devuelto});
                }
                
            }
        }
    }
}
