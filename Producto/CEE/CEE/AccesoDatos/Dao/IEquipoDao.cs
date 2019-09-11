using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Entidad;

namespace CEE.AccesoDatos.Dao
{
    interface IEquipoDao
    {
        Equipo GetEquipoById(int idEquipo);
        IList<Equipo> GetEquipoByFilters(Dictionary<string, object> parametros);
    }
}
