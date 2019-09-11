using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao
{
    interface IMenuDao
    {
        MenuDTO GetMenuById(int idMenu);
        IList<MenuDTO> GetMenuByFilters(Dictionary<string, object> parametros);

    }
}
