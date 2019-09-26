using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Negocio.DTO
{
    class EstadoDTO
    {
        public int IdEstado { get; set; }
        public string NombreEstado { get; set; }
        public string Ambito { get; set; }
        public bool Deshabilita { get; set; }
    }
}
