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
    class CarreraService
    {
        private ICarreraDao oCarreraDao;

        public CarreraService()
        {
            oCarreraDao = new CarreraDaoSql();
        }

        public CarreraDTO GetCarreraById(int idCarrera)
        {
            return oCarreraDao.GetCarreraById(idCarrera);
        }

        public IList<CarreraDTO> GetCarreraByFilters(Dictionary<string, object> parametros)
        {
            return oCarreraDao.GetCarreraByFilters(parametros);
        }
    }
}
