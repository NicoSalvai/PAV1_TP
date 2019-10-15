using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Negocio.DTO
{
    class DetallePrestamoDTO
    {
        public int IdDetallePrestamo { get; set; }
        public int IdPrestamo { get; set; }
        public int IdEquipo { get; set; }
        public string CodigoEquipo { get; set; }
        public string NombreEquipo { get; set; }
        public int IdTipoEquipo { get; set; }
        public string NombreTipoEquipo { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public DateTime FechaDevuelto { get; set; }
        public bool Devuelto { get; set; }
    }
}
