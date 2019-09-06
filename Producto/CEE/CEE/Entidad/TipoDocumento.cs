using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Entidad
{
    class TipoDocumento
    {
        public int IdTipoDocumento { get; set; }
        public string NombreTipoDocumento { get; set; }

        // Desde aca las Propertys son Nullable
        public string Descripcion { get; set; }

    }
}
