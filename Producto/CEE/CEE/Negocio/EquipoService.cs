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
    class EquipoService
    {
        private IEquipoDao oEquipoDao;

        public EquipoService()
        {
            oEquipoDao = new EquipoDaoSql();
        }

        public EquipoDTO GetEquipoById(int idEquipo)
        {
            return oEquipoDao.GetEquipoById(idEquipo);
        }

        public IList<EquipoDTO> GetEquipoByFilters(Dictionary<string, object> parametros)
        {
            return oEquipoDao.GetEquipoByFilters(parametros);
        }
    }
}
