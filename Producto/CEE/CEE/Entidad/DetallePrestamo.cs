using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Entidad
{
    class DetallePrestamo
    {
        public int IdDetallePrestamo { get; set; }
        public int IdPrestamo { get; set; }
        public Equipo Equipo { get; set; }

        // Desde aca las Propertys son Nullable
        public DateTime FechaDevolucion { get; set; }
    }
}
