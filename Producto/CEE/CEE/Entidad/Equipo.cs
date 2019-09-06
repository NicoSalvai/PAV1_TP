using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Entidad
{
    class Equipo
    {
        public int IdEquipo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public TipoEquipo TipoEquipo { get; set; }

        //Desde aca las Propertys son Nullable
        public string Descripcion { get; set; }

    }
}
