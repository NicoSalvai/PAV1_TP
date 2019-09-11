using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Entidad;
using System.Data;

namespace CEE.AccesoDatos.Dao.SqlObjects
{
    class EquipoDaoSql : IEquipoDao
    {
        /// <summary>
        /// Me devuelve un objeto Equipo segun el Id que le pase
        /// </summary>
        /// <param name="idEquipo">El id del objeto Equipo que busco</param>
        /// <returns>El objeto Equipo con el id pasado por parametro</returns>
        public Equipo GetEquipoById(int idEquipo)
        {
            string strSql = "SELECT E.equipo_id, " +
                                "E.codigo, " +
                                "E.nombre, " +
                                "E.tipo_equipo_id, " +
                                "E.descripcion " +
                            "FROM EQUIPO E " +
                            "WHERE E.equipo_id = " + idEquipo.ToString();

            return MappingEquipo(DBHelper.DBHelperSql.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        /// <summary>
        /// Me devuelve una IList con objetos Equipos acorde a los filtros pasados por parametro
        /// </summary>
        /// <param name="parametros">Parametros para filtrar la busqueda</param>
        /// <returns></returns>
        public IList<Equipo> GetEquipoByFilters(Dictionary<string, object> parametros)
        {
            throw new Exception("Operacion no soportada");
        }

        /// <summary>
        /// Le entrego un DataRow con los datos de un objeto Equipos
        /// y me devuelve la instancia del objeto equipo creada con esos datos.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Equipo MappingEquipo(DataRow row)
        {
            Equipo oEquipo = new Equipo();

            oEquipo.IdEquipo = Int32.Parse(row["equipo_id"].ToString());
            oEquipo.Nombre = row["nombre"].ToString();
            oEquipo.Codigo = row["codigo"].ToString();
            oEquipo.TipoEquipo = GetEquipoTipoEquipo(Int32.Parse(row["tipo_equipo_id"].ToString()));
            oEquipo.Descripcion = row["descripcion"].ToString();

            return oEquipo;
        }

        /// <summary>
        /// Le paso el id del TipoEquipo de un Equipo y me devuelve el objeto Tipo Equipo correspondiente
        /// </summary>
        /// <param name="idTipoEquipo"></param>
        /// <returns></returns>
        private TipoEquipo GetEquipoTipoEquipo(int idTipoEquipo)
        {
            ITipoEquipoDao tipoEquipoDao = new TipoEquipoDaoSql();
            return tipoEquipoDao.GetTipoEquipoById(idTipoEquipo);
        }
    }
}
