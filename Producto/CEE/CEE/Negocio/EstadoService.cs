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
    class EstadoService
    {
        private IEstadoDao oEstadoDao;

        public EstadoService()
        {
            oEstadoDao = new EstadoDao();
        }

        public EstadoDTO GetEstadoById(int idEquipo)
        {
            return oEstadoDao.GetEstadoById(idEquipo);
        }

        public IList<EstadoDTO> GetEstadoByFilters(Dictionary<string, object> parametros)
        {
            return oEstadoDao.GetEstadoByFilters(parametros);
        }
    }
}
