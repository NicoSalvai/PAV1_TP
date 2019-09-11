using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Entidad;

namespace CEE.AccesoDatos.Dao
{
    interface IMenuDao
    {
        Menu GetMenuById(int idMenu);
        IList<Menu> GetMenuByFilters(Dictionary<string, object> parametros);

    }
}
