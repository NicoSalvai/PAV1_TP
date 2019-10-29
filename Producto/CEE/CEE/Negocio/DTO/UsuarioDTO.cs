using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Negocio.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Pass { get; set; }
        public bool ForzarPassword { get; set; }
        public DateTime FechaAlta { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public DateTime FechaBaja { get; set; }

    }
}
