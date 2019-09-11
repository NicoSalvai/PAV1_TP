using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao
{
    interface IPerfilDao
    {
        PerfilDTO GetPerfilById(int idPerfil);

        IList<PerfilDTO> GetPerfilByFilters(Dictionary<string, object> parametros);
    }
}
