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
                            "EST.nombre_estado, " +
                            "E.estado_id, " +
                            "E.descripcion, " +
	                        "E.fecha_alta, " +
	                        "E.fecha_baja " +
                            "FROM EQUIPO E " +
                            "JOIN TIPO_EQUIPO TE ON TE.tipo_equipo_id = E.tipo_equipo_id " +
                            "JOIN ESTADO EST ON EST.estado_id = E.estado_id " +
                            "WHERE E.equipo_id = " + idEquipo.ToString() + " " +
                            "AND E.fecha_baja IS NULL ";

            return MappingEquipo(DBHelperSql.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        /// <summary>
        /// Me devuelve una IList con objetos Equipos acorde a los filtros pasados por parametro
        /// </summary>
        /// <param name="parametros">Codigo - Nombre - TipoEquipo - FechaBajaNotNull</param>
        /// <returns></returns>
        public IList<EquipoDTO> GetEquipoByFilters(Dictionary<string, object> parametros)
        {
            List<EquipoDTO> resultado = new List<EquipoDTO>();

            string strSql = "SELECT E.equipo_id, " +
                            "E.codigo, " +
                            "E.nombre, " +
                            "TE.tipo_equipo, " +
                            "E.tipo_equipo_id, " +
                            "EST.nombre_estado, " +
                            "E.estado_id, " +
                            "E.descripcion, " +
                            "E.fecha_alta, " +
                            "E.fecha_baja " +
                            "FROM EQUIPO E " +
                            "JOIN TIPO_EQUIPO TE ON TE.tipo_equipo_id = E.tipo_equipo_id " +
                            "JOIN ESTADO EST ON EST.estado_id = E.estado_id " +
                            "WHERE 1 = 1 ";

            if (parametros.ContainsKey("Codigo"))
                strSql += " AND (E.codigo LIKE '%' + @Codigo + '%') ";
            if (parametros.ContainsKey("Nombre"))
                strSql += " AND (E.nombre LIKE '%' + @Nombre + '%') ";
            if (parametros.ContainsKey("TipoEquipo"))
                strSql += " AND (TE.tipo_equipo = @TipoEquipo) ";
            if (parametros.ContainsKey("Estado"))
                strSql += " AND (EST.nombre_estado = @Estado) ";
            if (!parametros.ContainsKey("FechaBajaNotNull"))
                strSql += " AND (E.fecha_baja IS NULL) ";


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
            oEquipo.Estado = row["nombre_estado"].ToString();
            oEquipo.IdEstado = Int32.Parse(row["estado_id"].ToString());
            oEquipo.FechaAlta = DateTime.Parse(row["fecha_alta"].ToString());

            if(!DBNull.Value.Equals(row["fecha_baja"]))
                oEquipo.FechaAlta = DateTime.Parse(row["fecha_baja"].ToString());

            if (!DBNull.Value.Equals(row["descripcion"]))
                oEquipo.Descripcion = row["descripcion"].ToString();

            return oEquipo;
        }

        public bool DeleteEquipoById(int idEquipo)
        {
            string strSql = "UPDATE EQUIPO " +
                            "SET fecha_baja = GETDATE() " +
                            "WHERE equipo_id = " + idEquipo.ToString();

            DBHelperSql.GetDBHelper().EjecutarSQL(strSql);
            return true;
        }

        public bool UpdateEquipoById(EquipoDTO oEquipo)
        {
            string strSql = "UPDATE EQUIPO " +
                            "SET codigo = '" + oEquipo.Codigo               + "', " +
                            "nombre = '" + oEquipo.Nombre                   + "', " +
                            "tipo_equipo_id = '" + oEquipo.IdTipoEquipo     + "', " +
                            "estado_id = '" + oEquipo.IdEstado              + "', " +
                            "descripcion = '" + oEquipo.Descripcion         + "' " +
                            "WHERE equipo_id = " + oEquipo.IdEquipo.ToString();

            DBHelperSql.GetDBHelper().EjecutarSQL(strSql);
            return true;
        }

        public bool InsertEquipo(EquipoDTO oEquipo)
        {
            string strSql = "INSERT INTO EQUIPO(codigo, nombre, tipo_equipo_id, estado_id, descripcion, fecha_alta) " +
                            "VALUES(" + 
                            "'" + oEquipo.Codigo                            + "'," +
                            "'" + oEquipo.Nombre                            + "'," +
                            "'" + oEquipo.IdTipoEquipo.ToString()           + "'," +
                            "'" + oEquipo.IdEstado.ToString()               + "'," +
                            "'" + oEquipo.Descripcion                       + "'," +
                             "GETDATE()" + "); ";

            DBHelperSql.GetDBHelper().EjecutarSQL(strSql);
            return true;
        }
    }
}
