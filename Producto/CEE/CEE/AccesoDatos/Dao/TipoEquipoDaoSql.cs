using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Entidad;
using System.Data;

namespace CEE.AccesoDatos.Dao
{
    class TipoEquipoDao
    {

        /// <summary>
        /// devuelve un objeto TipoEquipo segun el Id que le pase
        /// </summary>
        /// <param name="idTipoEquipo">El id del objeto TipoEquipo que quiero levantar</param>
        /// <returns>El objeto TipoEquipo buscado</returns>
        public TipoEquipo GetTipoEquipoById(int idTipoEquipo)
        {
            string strSql = "SELECT TE.tipo_equipo_id, " +
                            "TE.tipo_equipo, " +
                            "TE.descripcion " +
                            "FROM TIPO_EQUIPO TE " +
                            "WHERE TE.tipo_equipo_id = " + idTipoEquipo.ToString();

            return MappingTipoEquipo(DBHelper.DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        /// <summary>
        /// Me devuelve la lista de objetos TipoEquipo segun los filtros que le pase
        /// </summary>
        /// <param name="parametros">Un Dictionary de parametros y filtros a utilizar</param>
        /// <returns>Una IList de objetos TipoEquipo</returns>
        public IList<TipoEquipo> GetTipoEquipoByFilters(Dictionary<string, object> parametros)
        {
            throw new Exception("Operacion no soportada");
        }

        /// <summary>
        /// Le pase un DataRow con los datos de un objeto TipoEquipo
        /// y me devuelve el objeto TipoEquipo ya creado
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public TipoEquipo MappingTipoEquipo(DataRow row)
        {
            TipoEquipo oTipoEquipo = new TipoEquipo();

            oTipoEquipo.IdTipoEquipo = Int32.Parse(row["tipo_equipo_id"].ToString());
            oTipoEquipo.NombreTipoEquipo = row["tipo_equipo"].ToString();
            oTipoEquipo.Descripcion = row["descripcion"].ToString();

            return oTipoEquipo;
        }
    }
}
