﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Entidad
{
    class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Pass { get; set; }

        // Desde aca las Propertys son Nullable
        public IList<Perfil> Perfiles { get; set; }

    }
}
