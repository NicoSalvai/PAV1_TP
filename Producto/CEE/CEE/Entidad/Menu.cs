using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Entidad
{
    class Menu
    {
        public int IdMenu { get; set; }
        public string NombreMenu { get; set; }
        public bool EsFinal { get; set; }

        // Desde aca las Propertys son Nullable
        public string Aplicacion { get; set; }

        public Menu MenuPadre { get; set; }

    }
}
