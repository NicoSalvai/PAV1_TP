﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Negocio.DTO
{
    class TipoDocumentoDTO
    {
        public int IdTipoDocumento { get; set; }
        public string NombreTipoDocumento { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public string Descripcion { get; set; }

    }
}
