using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CEE.AccesoDatos.Dao.Sql;
using CEE.AccesoDatos.Dao;
using CEE.Negocio.DTO;

namespace CEE.Negocio
{
    class PerfilService
    {
        private IPerfilDao oPerfilDao;

        public PerfilService()
        {
            oPerfilDao = new PerfilDaoSql();
        }

        public PerfilDTO GetPerfilById(int idPerfil)
        {
            return oPerfilDao.GetPerfilById(idPerfil);
        }

        public IList<PerfilDTO> GetPerfilByFilters(Dictionary<string, object> parametros)
        {
            return oPerfilDao.GetPerfilByFilters(parametros);
        }
    }
}
