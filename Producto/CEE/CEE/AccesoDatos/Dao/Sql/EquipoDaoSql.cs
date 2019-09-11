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
    class EquipoDaoSql : IEquipoDao
    {
        /// <summary>
        /// Me devuelve un objeto Equipo segun el Id que le pase
        /// </summary>
        /// <param name="idEquipo">El id del objeto Equipo que busco</param>
        /// <returns>El objeto Equipo con el id pasado por parametro</returns>
        public EquipoDTO GetEquipoById(int idEquipo)
        {
            string strSql = "SELECT E.equipo_id, " +
                            "E.codigo, " +
                            "E.nombre, " +
                            "TE.tipo_equipo, " +
                            "E.tipo_equipo_id, " +
                            "E.descripcion " +
                            "FROM EQUIPO E " +
                            "JOIN TIPO_EQUIPO TE ON TE.tipo_equipo_id = E.tipo_equipo_id " +
                            "WHERE E.equipo_id = " + idEquipo.ToString();

            return MappingEquipo(DBHelper.DBHelperSql.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        /// <summary>
        /// Me devuelve una IList con objetos Equipos acorde a los filtros pasados por parametro
        /// </summary>
        /// <param name="parametros">Parametros para filtrar la busqueda</param>
        /// <returns></returns>
        public IList<EquipoDTO> GetEquipoByFilters(Dictionary<string, object> parametros)
        {
            List<EquipoDTO> resultado = new List<EquipoDTO>();

            string strSql = "SELECT E.equipo_id, " +
                            "E.codigo, " +
                            "E.nombre, " +
                            "TE.tipo_equipo, " +
                            "E.tipo_equipo_id, " +
                            "E.descripcion " +
                            "FROM EQUIPO E " +
                            "JOIN TIPO_EQUIPO TE ON TE.tipo_equipo_id = E.tipo_equipo_id " +
                            "WHERE 1 = 1 ";

            if (parametros.ContainsKey("NombreUsuario"))
                strSql += " AND (U.nombre_usuario = @NombreUsuario) ";

            DataTable dt = DBHelperSql.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(MappingEquipo(row));
            }

            return resultado;
        }

        /// <summary>
        /// Le entrego un DataRow con los datos de un objeto Equipos
        /// y me devuelve la instancia del objeto equipo creada con esos datos.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private EquipoDTO MappingEquipo(DataRow row)
        {
            EquipoDTO oEquipo = new EquipoDTO();

            oEquipo.IdEquipo = Int32.Parse(row["equipo_id"].ToString());
            oEquipo.Nombre = row["nombre"].ToString();
            oEquipo.Codigo = row["codigo"].ToString();
            oEquipo.TipoEquipo = row["tipo_equipo"].ToString();
            oEquipo.IdTipoEquipo = Int32.Parse(row["tipo_equipo_id"].ToString());
            if (!DBNull.Value.Equals(row["descripcion"]))
                oEquipo.Descripcion = row["descripcion"].ToString();

            return oEquipo;
        }
    }
}
