using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao
{
    interface IEquipoDao
    {
        EquipoDTO GetEquipoById(int idEquipo);
        IList<EquipoDTO> GetEquipoByFilters(Dictionary<string, object> parametros);
    }
}
