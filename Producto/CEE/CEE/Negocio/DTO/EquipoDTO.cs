using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Negocio.DTO
{
    class EquipoDTO
    {
        public int IdEquipo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string TipoEquipo { get; set; }
        public int IdTipoEquipo { get; set; }

        //Desde aca las Propertys son Nullable
        public string Descripcion { get; set; }
    }
}
