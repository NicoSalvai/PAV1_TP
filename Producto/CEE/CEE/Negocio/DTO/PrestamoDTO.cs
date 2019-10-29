using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Negocio.DTO
{
    class PrestamoDTO
    {
        public int IdPrestamo { get; set; }
        public int IdPersona { get; set; }
        public int NumeroDocumentoPersona { get; set; }
        public int IdTipoDocumentoPersona { get; set; }
        public string NombreTipoDocumentoPersona { get; set; }
        public string ApellidoPersona { get; set; }
        public string NombrePersona { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public int LegajoPersona { get; set; }
        public int IdEstado { get; set; }
        public string NombreEstado { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHastaEstimada { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public DateTime FechaHasta { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public DateTime FechaCancelacion { get; set; }
        /// <summary>
        /// Nullable. Solo para Busqueda por filtros
        /// </summary>
        public IList<DetallePrestamoDTO> Detalles { get; set; }
    }
}
