using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Negocio.DTO
{
    class TipoEquipoDTO
    {
        public int IdTipoEquipo { get; set; }
        public string NombreTipoEquipo { get; set; }    // Se cambia el nombre de la Property porque no puede coincidir con el nombre envolvente

        // Desde aca las Propertys son Nullable
        public string Descripcion { get; set; }
    }
}
