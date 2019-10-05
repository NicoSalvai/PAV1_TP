using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao.Sql
{
    class PrestamoDaoSql : IPrestamoDao
    {
        public PrestamoDTO GetPrestamoyId(int idPrestamo)
        {
            throw new NotImplementedException();
        }

        public IList<PrestamoDTO> GetPrestamoByFilters(Dictionary<string, object> parametros)
        {
            throw new NotImplementedException();
        }

        private PrestamoDTO MappingPrestamo(DataRow row)
        {
            throw new NotImplementedException();
        }

        public bool DeletePrestamoById(int idPrestamo)
        {
            throw new NotImplementedException();
        }

        public bool InsertPrestamo(PrestamoDTO oPrestamo)
        {
            string strSql = "";




            return true;
        }

        public bool UpdatePrestamoById(PrestamoDTO oPrestamo)
        {
            throw new NotImplementedException();
        }
    }
}
