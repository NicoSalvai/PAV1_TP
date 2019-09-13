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
        public string NombreTipoEquipo { get; set; }   
        /// <summary>
        /// Nullable
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public string CodigoRecomendado { get; set; }
    }
}
