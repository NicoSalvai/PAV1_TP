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
    class CarreraDaoSql : ICarreraDao
    {
        /// <summary>
        /// Me devuelve un objeto Carrera segun el Id que le pase
        /// </summary>
        /// <param name="idCarrera">El id del objeto Carrera que busco</param>
        /// <returns>El objeto Carrera con el id pasado por parametro</returns>
        public CarreraDTO GetCarreraById(int idCarrera)
        {
            string strSql = "SELECT C.carrera_id, " +
                            "C.nombre_carrera " +
                            "FROM CARRERA C " +
                            "WHERE C.carrera_id = " + idCarrera.ToString();

            return MappingCarrera(DBHelperSql.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        /// <summary>
        /// Me devuelve una IList con objetos Carrera acorde a los filtros pasados por parametro
        /// </summary>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public IList<CarreraDTO> GetCarreraByFilters(Dictionary<string, object> parametros)
        {
            List<CarreraDTO> resultado = new List<CarreraDTO>();

            string strSql = "SELECT C.carrera_id, " +
                            "C.nombre_carrera " +
                            "FROM CARRERA C " +
                            "WHERE 1 = 1 ";

            if (parametros.ContainsKey("NombreCarrera"))
                strSql += " AND (C.nombre_carrera = @NombreCarrera) ";

            DataTable dt = DBHelperSql.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(MappingCarrera(row));
            }

            return resultado;
        }

        /// <summary>
        /// Le entrego un DataRow con los datos de un objeto Carrera
        /// y me devuelve la instancia del objeto Carrera creada con esos datos.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private CarreraDTO MappingCarrera(DataRow row)
        {
            CarreraDTO oCarrera = new CarreraDTO();

            oCarrera.IdCarrera = Int32.Parse(row["carrera_id"].ToString());
            oCarrera.NombreCarrera = (row["nombre_carrera"].ToString());

            return oCarrera;
        }
    }
}
