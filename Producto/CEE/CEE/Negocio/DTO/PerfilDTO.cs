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
        /// <summary>
        /// Nullable
        /// </summary>
        public string Descripcion { get; set; }
    }
}
