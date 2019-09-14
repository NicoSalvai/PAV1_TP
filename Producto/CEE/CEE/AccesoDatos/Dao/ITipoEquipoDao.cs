using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao
{
    interface ITipoEquipoDao
    {
        TipoEquipoDTO GetTipoEquipoById(int idTipoEquipo);
        IList<TipoEquipoDTO> GetTipoEquipoByFilters(Dictionary<string, object> parametros);
        bool UpdateTipoEquipoById(TipoEquipoDTO oTipoEquipo);
        bool InsertTipoEquipo(TipoEquipoDTO oTipoEquipo);
    }
}
