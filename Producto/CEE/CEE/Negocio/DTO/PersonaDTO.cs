using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Negocio.DTO
{
    public class PersonaDTO
    {
        public int IdPersona { get; set; }
        public int Legajo { get; set; }
        public int NumeroDocumento { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NombreTipoDocumento{ get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public int Telefono { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public string Calle  { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public int NumeroCalle { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public int Piso { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public string Departamento { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public string Observaciones { get; set; }
        public DateTime FechaAlta { get; set; }
        /// <summary>
        /// Nullable
        /// </summary>
        public DateTime FechaBaja { get; set; }

    }
}
