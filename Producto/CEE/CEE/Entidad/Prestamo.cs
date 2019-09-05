using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Entidad
{
    class Prestamo
    {
        public int IdPrestamo { get; set; }
        public IList<DetallePrestamo> Detalles { get; set; }
        public DateTime FechaDesde { get; set; }

        // Desde aca las Property son Nullable
        public DateTime FechaHasta { get; set; }

    }
}
