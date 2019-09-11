using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Entidad;

namespace CEE.AccesoDatos.Dao
{
    interface IUsuarioDao
    {
        Usuario GetUsuarioById(int idUsuario);
        IList<Usuario> GetUsuarioByFilters(Dictionary<string, object> parametros);
    }
}
