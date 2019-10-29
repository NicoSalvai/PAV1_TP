using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Negocio.DTO
{
    public class EquipoDTO
    {
        public int IdEquipo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string TipoEquipo { get; set; }
        public int IdTipoEquipo { get; set; }
        public string Estado { get; set; }
        public bool EstadoDeshabilita { get; set; }
        public bool EstadoEditable { get; set; }
        public int IdEstado { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public string Descripcion { get; set; }
        public DateTime FechaAlta { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public DateTime FechaBaja{ get; set; }
    }
}
