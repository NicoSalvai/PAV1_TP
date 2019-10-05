using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao
{
    interface ICarreraDao
    {
        CarreraDTO GetCarreraById(int idCarrera);
        IList<CarreraDTO> GetCarreraByFilters(Dictionary<string, object> parametros);
    }
}
