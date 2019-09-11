using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Entidad;

namespace CEE.AccesoDatos.Dao
{
    interface ITipoEquipoDao
    {
        TipoEquipo GetTipoEquipoById(int idTipoEquipo);
        IList<TipoEquipo> GetTipoEquipoByFilters(Dictionary<string, object> parametros);
    }
}
