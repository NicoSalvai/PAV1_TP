using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.AccesoDatos.Dao;
using CEE.AccesoDatos.Dao.Sql;
using CEE.Negocio.DTO;

namespace CEE.Negocio
{
    class PrestamoService
    {
        private IPrestamoDao oPrestamoDao;

        public PrestamoService()
        {
            oPrestamoDao = new PrestamoDaoSql();
        }

        public PrestamoDTO GetPrestamoyId(int idPrestamo)
        {
            return oPrestamoDao.GetPrestamoyId(idPrestamo);
        }

        public IList<PrestamoDTO> GetPrestamoByFilters(Dictionary<string, object> parametros)
        {
            return oPrestamoDao.GetPrestamoByFilters(parametros);
        }
    }
}
