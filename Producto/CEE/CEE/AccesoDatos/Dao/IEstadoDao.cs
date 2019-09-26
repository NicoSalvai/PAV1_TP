using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao
{
    interface IEstadoDao
    {
        EstadoDTO GetEstadoById(int idEstado);
        IList<EstadoDTO> GetEstadoByFilters(Dictionary<string, object> parametros);
    }
}
