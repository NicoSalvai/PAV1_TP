using CEE.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEE.AccesoDatos.DBHelper;

namespace CEE.AccesoDatos.Dao.SqlObjects
{
    class UsuarioDaoSql : IUsuarioDao
    {
        /// <summary>
        /// Me devuelve un objeto Usuario segun el id que le pase
        /// </summary>
        /// <param name="idUsuario">El id del objeto Usuario buscado</param>
        /// <returns>El objeto Usuario buscado</returns>
        public Usuario GetUsuarioById (int idUsuario)
        {
            string strSql = "SELECT U.usuario_id, " +
                            "U.nombre_usuario, " +
                            "U.pass " + 
                            "FROM USUARIO U " + 
                            "WHERE U.usuario_id = " + idUsuario.ToString();

            return MappingUsuario(DBHelper.DBHelperSql.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        /// <summary>
        /// Me devuelve una IList de objetos Usuario segun los parametros que yo le envie
        /// </summary>
        /// <param name="parametros">Un Dictionary de string-object con los parametros para filtrar la busqueda</param>
        /// <returns>Operacion no soportada</returns>
        public IList<Usuario> GetUsuarioByFilters(Dictionary<string, object> parametros)
        {
            List<Usuario> resultado = new List<Usuario>();

            string strSql = "SELECT U.usuario_id, " +
                " U.nombre_usuario, " +
                " U.pass " +
                " FROM USUARIO U " +
                " WHERE (1 = 1) ";

            if (parametros.ContainsKey("NombreUsuario"))
                strSql += " AND (U.nombre_usuario like @NombreUsuario) ";
            if (parametros.ContainsKey("Pass"))
                strSql += " AND (U.pass=@Pass) ";
            
            DataTable dt = DBHelper.DBHelperSql.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);

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
        private Usuario MappingUsuario(DataRow row)
        {
            Usuario oUsuario = new Usuario();
            oUsuario.IdUsuario = Int32.Parse(row["usuario_id"].ToString());
            oUsuario.NombreUsuario = row["nombre_usuario"].ToString();
            oUsuario.Pass = row["pass"].ToString();

            oUsuario.Perfiles = GetUsuarioPerfiles(oUsuario.IdUsuario);

            return oUsuario;
        }

        /// <summary>
        /// Le paso el id de un objeto Usuario y me devuelve el conjunto de Perfiles que este posee
        /// </summary>
        /// <param name="idUsuario"> El id del usuario en cuestion</param>
        /// <returns>una IList de Perfiles</returns>
        private IList<Perfil> GetUsuarioPerfiles(int idUsuario)
        {
            List<Perfil> perfiles = new List<Perfil>();        // armo la lista de menus a devolver
            IPerfilDao perfilDao = new PerfilDaoSql();            // creo el menuDao para poder buscar los menus del perfil

            string strSql = "SELECT UP.perfil_id " +
                        "FROM USUARIO_PERFIL UP " +
                        "WHERE UP.usuario_id = " + idUsuario.ToString();

            //List<string> list = DBHelper.DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows.OfType<DataRow>().Select(dr => (string)dr["menu_id"]).ToList();

            DataTable dt = DBHelper.DBHelperSql.GetDBHelper().ConsultaSQL(strSql);             // aca consigo la DataTable con el BDHelper que tenga los menu_id de este perfil 
            List<string> list = dt.Rows.OfType<DataRow>().Select(dr => (string)dr["perfil_id"].ToString()).ToList(); // convierto la dt de 1 columna en una lista de strings

            foreach (string idMenu in list)     // por cada uno de los string de la lista mando al menuDao un pedido de que me traiga el menu q le corresponde y lo meto a mi lista
            {
                perfiles.Add(perfilDao.GetPerfilById(Int32.Parse(idMenu)));
            }

            return perfiles;
        }
    }
}
