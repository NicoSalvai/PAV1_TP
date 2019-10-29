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
    class UniversidadService
    {
        private IUniversidadDao oUniversidadDao;

        public UniversidadService()
        {
            oUniversidadDao = new UniversidadDaoSql();
        }

        public UniversidadDTO GetUniversidadById(int idUniversidad)
        {
            return oUniversidadDao.GetUniversidadById(idUniversidad);
        }

        public IList<UniversidadDTO> GetUniversidadByFilters(Dictionary<string, object> parametros)
        {
            return oUniversidadDao.GetUniversidadByFilters(parametros);
        }
    }
}
