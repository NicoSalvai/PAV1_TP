using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Entidad;

namespace CEE.AccesoDatos.Dao
{
    interface IPerfilDao
    {
        Perfil GetPerfilById(int idPerfil);

        IList<Perfil> GetPerfilByFilters(Dictionary<string, object> parametros);
    }
}
