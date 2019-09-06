using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Entidad
{
    class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }

        private string pass;

        public string MyProperty
        {
            get { return pass; }
            set { pass = value.GetHashCode().ToString(); }
        }

        // Desde aca las Propertys son Nullable
        public IList<Perfil> Perfiles { get; set; }

    }
}
