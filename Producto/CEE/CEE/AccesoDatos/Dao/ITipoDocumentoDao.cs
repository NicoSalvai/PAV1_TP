using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao
{
    interface ITipoDocumentoDao
    {
        TipoDocumentoDTO GetTipoDocumentoById(int idTipoDocumento);
        IList<TipoDocumentoDTO> GetTipoDocumentoByFilters(Dictionary<string, object> parametros);
        bool UpdateTipoDocumentoById(TipoDocumentoDTO oTipoDocumento);
        bool InsertTipoDocumento(TipoDocumentoDTO oTipoDocumento);
        
    }
}
