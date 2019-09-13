using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Negocio.DTO
{
    class MenuDTO
    {
        public int IdMenu { get; set; }
        public string NombreMenu { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public string MenuPadre { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public int IdMenuPadre { get; set; }
        public bool EsFinal { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public string Aplicacion { get; set; }
    }
}
