using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Entidad
{
    class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumeroDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }

        // Desde aca las Propertys son Nullable
        public IList<Prestamo> Prestamos { get; set; }

        public string Calle { get; set; }

        public int NumeroCalle { get; set; }

        public int Piso { get; set; }

        public string Departamento { get; set; }

        public string Mail { get; set; }

        public int Telefono { get; set; }


    }
}
