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
    class UniversidadDaoSql : IUniversidadDao
    {
        /// <summary>
        /// Me devuelve un objeto Universidad segun el Id que le pase
        /// </summary>
        /// <param name="idUniversidad">El id del objeto Universidad que busco</param>
        /// <returns>El objeto Universidad con el id pasado por parametro</returns>
        public UniversidadDTO GetUniversidadById(int idUniversidad)
        {
            string strSql = "SELECT U.universidad_id, " +
                            "U.nombre_universidad " +
                            "FROM UNIVERSIDAD U " +
                            "WHERE U.universidad_id = " + idUniversidad.ToString();
            

            return MappingUniversidad(DBHelperSql.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        /// <summary>
        /// Me devuelve una IList con objetos Universidad acorde a los filtros pasados por parametro
        /// </summary>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public IList<UniversidadDTO> GetUniversidadByFilters(Dictionary<string, object> parametros)
        {
            List<UniversidadDTO> resultado = new List<UniversidadDTO>();

            string strSql = "SELECT U.universidad_id, " +
                            "U.nombre_universidad " +
                            "FROM UNIVERSIDAD U " +
                            "WHERE 1 = 1 ";

            if (parametros.ContainsKey("NombreUniversidad"))
                strSql += " AND (U.nombre_universidad = @NombreUniversidad) ";
            
            DataTable dt = DBHelperSql.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(MappingUniversidad(row));
            }

            return resultado;
        }

        /// <summary>
        /// Le entrego un DataRow con los datos de un objeto Universidad
        /// y me devuelve la instancia del objeto Universidad creada con esos datos.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private UniversidadDTO MappingUniversidad(DataRow row)
        {
            UniversidadDTO oUniversidad = new UniversidadDTO();

            oUniversidad.IdUniversidad = Int32.Parse(row["universidad_id"].ToString());
            oUniversidad.NombreUniversidad = (row["nombre_universidad"].ToString());

            return oUniversidad;
        }
    }
}
