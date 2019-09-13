
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
    class UsuarioDaoSql : IUsuarioDao
    {
        /// <summary>
        /// Me devuelve un objeto Usuario segun el id que le pase
        /// </summary>
        /// <param name="idUsuario">El id del objeto Usuario buscado</param>
        /// <returns>El objeto Usuario buscado</returns>
        public UsuarioDTO GetUsuarioById (int idUsuario)
        {
            string strSql = "SELECT U.usuario_id, " +
                            "U.nombre_usuario, " +
                            "U.pass, " +
                            "U.fecha_alta, " +
                            "U.fecha_baja " + 
                            "FROM USUARIO U " + 
                            "WHERE U.usuario_id = " + idUsuario.ToString() + " " +
                            "AND U.fecha_baja IS NULL";

            return MappingUsuario(DBHelperSql.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        /// <summary>
        /// Me devuelve una IList de objetos Usuario segun los parametros que yo le envie
        /// </summary>
        /// <param name="parametros">NombreUsuario - NombreUsuarioLike - Pass - FechaBajaNotNull</param>
        /// <returns>Operacion no soportada</returns>
        public IList<UsuarioDTO> GetUsuarioByFilters(Dictionary<string, object> parametros)
        {
            List<UsuarioDTO> resultado = new List<UsuarioDTO>();

            string strSql = "SELECT U.usuario_id, " +
                            "U.nombre_usuario, " +
                            "U.pass, " +
                            "U.fecha_alta, " +
                            "U.fecha_baja " +
                            "FROM USUARIO U " +
                            "WHERE (1 = 1) ";

            if (parametros.ContainsKey("NombreUsuario"))
                strSql += " AND (U.nombre_usuario = @NombreUsuario) ";
            if (parametros.ContainsKey("NombreUsuarioLike"))
                strSql += " AND (U.nombre_usuario = @NombreUsuarioLike) ";
            if (parametros.ContainsKey("Pass"))
                strSql += " AND (U.pass=@Pass) ";
            if (!parametros.ContainsKey("FechaBajaNotNull"))
                strSql += " AND (U.fecha_baja IS NULL) ";

            DataTable dt = DBHelperSql.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(MappingUsuario(row));
            }

            return resultado;
        }

        /// <summary>
        /// Le doy un objeto DataRow que contenga los datos de 1 objeto Usuario y me devuelve el Objeto Usuario
        /// </summary>
        /// <param name="row"> La DataRow con los datos del perfil</param>
        /// <returns>Un Objeto Usuario</returns>
        private UsuarioDTO MappingUsuario(DataRow row)
        {
            UsuarioDTO oUsuario = new UsuarioDTO();

            oUsuario.IdUsuario = Int32.Parse(row["usuario_id"].ToString());
            oUsuario.NombreUsuario = row["nombre_usuario"].ToString();
            oUsuario.Pass = row["pass"].ToString();
            oUsuario.FechaAlta = DateTime.Parse(row["fecha_alta"].ToString());

            if(!DBNull.Value.Equals(row["fecha_baja"]))
                oUsuario.FechaAlta = DateTime.Parse(row["fecha_baja"].ToString());

            return oUsuario;
        }
    }
}
