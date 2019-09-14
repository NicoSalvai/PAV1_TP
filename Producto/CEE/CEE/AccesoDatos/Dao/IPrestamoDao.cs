using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao
{
    interface IPrestamoDao
    {
        PrestamoDTO GetPrestamoyId(int idPrestamo);
        IList<PrestamoDTO> GetPrestamoByFilters(Dictionary<string, object> parametros);
        bool DeletePrestamoById(int idPrestamo);
        bool UpdatePrestamoById(PrestamoDTO oPrestamo);
        bool InsertPrestamo(PrestamoDTO oPrestamo);
        
    }
}
