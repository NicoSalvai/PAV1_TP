using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao
{
    interface IUniversidadDao
    {
        UniversidadDTO GetUniversidadById(int idUniversidad);
        IList<UniversidadDTO> GetUniversidadByFilters(Dictionary<string, object> parametros);
    }
}
