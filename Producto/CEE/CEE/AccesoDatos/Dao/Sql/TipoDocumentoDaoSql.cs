using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.AccesoDatos.DBHelper;
using System.Data;
using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao.Sql
{
    class TipoDocumentoDaoSql : ITipoDocumentoDao
    {
        public TipoDocumentoDTO GetTipoDocumentoById(int idTipoDocumento)
        {
            string strSql = "SELECT TD.tipo_documento_id, " +
                            "TD.nombre_tipo_documento, " +
                            "TD.descripcion " +
                            "FROM TIPO_DOCUMENTO TD " +
                            "WHERE TD.tipo_documento_id =  " + idTipoDocumento.ToString();

            return MappingTipoDocumento(DBHelperSql.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        public IList<TipoDocumentoDTO> GetTipoDocumentoByFilters(Dictionary<string, object> parametros)
        {
            List<TipoDocumentoDTO> resultado = new List<TipoDocumentoDTO>();

            string strSql = "SELECT TD.tipo_documento_id, " +
                            "TD.nombre_tipo_documento, " +
                            "TD.descripcion " +
                            "FROM TIPO_DOCUMENTO TD " +
                            "WHERE 1 = 1 ";

            if (parametros.ContainsKey("TipoDocumento"))
                strSql += " AND (TD.nombre_tipo_documento = @TipoDocumento) ";

            DataTable dt = DBHelperSql.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(MappingTipoDocumento(row));
            }

            return resultado;
        }

        private TipoDocumentoDTO MappingTipoDocumento(DataRow row)
        {
            TipoDocumentoDTO oTipoDocumento = new TipoDocumentoDTO();

            oTipoDocumento.IdTipoDocumento = Int32.Parse(row["tipo_documento_id"].ToString());
            oTipoDocumento.NombreTipoDocumento = row["nombre_tipo_documento"].ToString();

            if (!DBNull.Value.Equals(row["descripcion"]))
                oTipoDocumento.Descripcion = row["descripcion"].ToString();

            return oTipoDocumento;
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
