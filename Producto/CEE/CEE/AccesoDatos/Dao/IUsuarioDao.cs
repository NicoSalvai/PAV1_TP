using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao
{
    interface IUsuarioDao
    {
        UsuarioDTO GetUsuarioById(int idUsuario);
        IList<UsuarioDTO> GetUsuarioByFilters(Dictionary<string, object> parametros);
    }
}
