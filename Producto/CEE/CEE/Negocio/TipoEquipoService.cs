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
    class TipoEquipoService
    {
        private ITipoEquipoDao oTipoEquipoDao;

        public TipoEquipoService()
        {
            oTipoEquipoDao = new TipoEquipoDaoSql();
        }

        public TipoEquipoDTO GetTipoEquipoById(int idTipoEquipo)
        {
            return oTipoEquipoDao.GetTipoEquipoById(idTipoEquipo);
        }

        public IList<TipoEquipoDTO> GetTipoEquipoByFilters(Dictionary<string, object> parametros)
        {
            return oTipoEquipoDao.GetTipoEquipoByFilters(parametros);
        }
    }
}
