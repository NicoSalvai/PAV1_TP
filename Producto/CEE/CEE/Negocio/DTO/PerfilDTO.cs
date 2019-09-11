using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Negocio.DTO
{
    class PerfilDTO
    {
        public int IdPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public DateTime FechaAlta { get; set; }

        // Desde aca las Propertys son Nullable
        public DateTime FechaBaja { get; set; }

        public string Descripcion { get; set; }
    }
}
