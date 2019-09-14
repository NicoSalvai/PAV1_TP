using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao.Sql
{
    class TipoDocumentoDaoSql : ITipoDocumentoDao
    {
        public TipoDocumentoDTO GetTipoDocumentoById(int idTipoDocumento)
        {
            throw new NotImplementedException();
        }

        public IList<TipoDocumentoDTO> GetTipoDocumentoByFilters(Dictionary<string, object> parametros)
        {
            throw new NotImplementedException();
        }

        private TipoDocumentoDTO MappingTipoDocumento(DataRow row)
        {
            throw new NotImplementedException();
        }
        public bool InsertTipoDocumento(TipoDocumentoDTO oTipoDocumento)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTipoDocumentoById(TipoDocumentoDTO oTipoDocumento)
        {
            throw new NotImplementedException();
        }
    }
}
