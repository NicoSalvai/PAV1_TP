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
    class EstadoDao : IEstadoDao
    {
        /// <summary>
        /// Me devuelve un objeto Estado segun el Id que le pase
        /// </summary>
        /// <param name="idEquipo">El id del objeto Estado que busco</param>
        /// <returns>El objeto Estado con el id pasado por parametro</returns>
        public EstadoDTO GetEstadoById(int idEstado)
        {
            string strSql = "SELECT EST.estado_id, " +
                            "EST.nombre_estado, " +
                            "EST.ambito, " +
                            "EST.deshabilita " +
                            "FROM ESTADO EST " +
                            "WHERE EST.estado_id = " + idEstado;

            return MappingEstado(DBHelperSql.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        /// <summary>
        /// Me devuelve una IList con objetos Estado acorde a los filtros pasados por parametro
        /// </summary>
        /// <param name="parametros">NombreEstado - Ambito</param>
        /// <returns></returns>
        public IList<EstadoDTO> GetEstadoByFilters(Dictionary<string, object> parametros)
        {
            List<EstadoDTO> resultado = new List<EstadoDTO>();

            string strSql = "SELECT EST.estado_id, " +
                            "EST.nombre_estado, " +
                            "EST.ambito, " +
                            "EST.deshabilita " +
                            "FROM ESTADO EST " +
                            "WHERE 1 = 1";

            if (parametros.ContainsKey("NombreEstado"))
                strSql += " AND (EST.nombre_estado = @NombreEstado) ";
            if (parametros.ContainsKey("Ambito"))
                strSql += " AND (EST.ambito = @Ambito) ";


            DataTable dt = DBHelperSql.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(MappingEstado(row));
            }

            return resultado;
        }

        /// <summary>
        /// Le entrego un DataRow con los datos de un objeto Estado
        /// y me devuelve la instancia del objeto Estado creada con esos datos.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private EstadoDTO MappingEstado(DataRow row)
        {
            EstadoDTO oEstado = new EstadoDTO();

            oEstado.IdEstado = Int32.Parse(row["estado_id"].ToString());
            oEstado.NombreEstado = row["nombre_estado"].ToString();
            oEstado.Ambito = row["ambito"].ToString();
            oEstado.Deshabilita = Boolean.Parse(row["deshabilita"].ToString());

            return oEstado;
        }
    }
}
