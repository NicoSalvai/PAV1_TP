using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.AccesoDatos.DBHelper;
using System.Data;
using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao.Sql
{
    class TipoEquipoDaoSql : ITipoEquipoDao
    {

        /// <summary>
        /// devuelve un objeto TipoEquipo segun el Id que le pase
        /// </summary>
        /// <param name="idTipoEquipo">El id del objeto TipoEquipo que quiero levantar</param>
        /// <returns>El objeto TipoEquipo buscado</returns>
        public TipoEquipoDTO GetTipoEquipoById(int idTipoEquipo)
        {
            string strSql = "SELECT TE.tipo_equipo_id, " +
                            "TE.tipo_equipo, " +
                            "TE.descripcion, " +
                            "TE.fecha_alta, " +
                            "TE.fecha_baja " +
                            "FROM TIPO_EQUIPO TE " +
                            "WHERE TE.tipo_equipo_id = " + idTipoEquipo.ToString();

            return MappingTipoEquipo(DBHelperSql.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        /// <summary>
        /// Me devuelve la lista de objetos TipoEquipo segun los filtros que le pase
        /// </summary>
        /// <param name="parametros">Un Dictionary de parametros y filtros a utilizar</param>
        /// <returns>Una IList de objetos TipoEquipo</returns>
        public IList<TipoEquipoDTO> GetTipoEquipoByFilters(Dictionary<string, object> parametros)
        {
            List<TipoEquipoDTO> resultado = new List<TipoEquipoDTO>();

            string strSql = "SELECT TE.tipo_equipo_id, " +
                            "TE.tipo_equipo, " +
                            "TE.descripcion, " +
                            "TE.fecha_alta, " +
                            "TE.fecha_baja " +
                            "FROM TIPO_EQUIPO TE " +
                            "WHERE 1 = 1 ";

            if (parametros.ContainsKey("NombreUsuario"))
                strSql += " AND (U.nombre_usuario = @NombreUsuario) ";

            DataTable dt = DBHelperSql.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(MappingTipoEquipo(row));
            }

            return resultado;
        }

        /// <summary>
        /// Le pase un DataRow con los datos de un objeto TipoEquipo
        /// y me devuelve el objeto TipoEquipo ya creado
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private TipoEquipoDTO MappingTipoEquipo(DataRow row)
        {
            TipoEquipoDTO oTipoEquipo = new TipoEquipoDTO();

            oTipoEquipo.IdTipoEquipo = Int32.Parse(row["tipo_equipo_id"].ToString());
            oTipoEquipo.NombreTipoEquipo = row["tipo_equipo"].ToString();

            if (!DBNull.Value.Equals(row["descripcion"]))
                oTipoEquipo.Descripcion = row["descripcion"].ToString();

            return oTipoEquipo;
        }
    }
}
