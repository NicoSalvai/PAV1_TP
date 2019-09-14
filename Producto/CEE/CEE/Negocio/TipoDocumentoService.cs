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
    class TipoDocumentoService
    {
        private ITipoDocumentoDao oTipoDocumentoDao;

        public TipoDocumentoService()
        {
            oTipoDocumentoDao = new TipoDocumentoDaoSql();
        }

        public TipoDocumentoDTO GetTipoDocumentoById(int idTipoDocumento)
        {
            return oTipoDocumentoDao.GetTipoDocumentoById(idTipoDocumento);
        }

        public IList<TipoDocumentoDTO> GetTipoDocumentoByFilters(Dictionary<string, object> parametros)
        {
            return oTipoDocumentoDao.GetTipoDocumentoByFilters(parametros);
        }
    }
}
