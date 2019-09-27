
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
                            "U.forzar_password, " +
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
                            "U.forzar_password, " +
                            "U.fecha_alta, " +
                            "U.fecha_baja " +
                            "FROM USUARIO U " +
                            "WHERE (1 = 1) ";

            if (parametros.ContainsKey("NombreUsuario"))
                strSql += " AND (U.nombre_usuario = @NombreUsuario) ";
            if (parametros.ContainsKey("NombreUsuarioLike"))
                strSql += " AND (U.nombre_usuario LIKE '%' + @NombreUsuarioLike + '%') ";
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
            oUsuario.ForzarPassword = Boolean.Parse(row["forzar_password"].ToString());
            oUsuario.FechaAlta = DateTime.Parse(row["fecha_alta"].ToString());

            if(!DBNull.Value.Equals(row["fecha_baja"]))
                oUsuario.FechaAlta = DateTime.Parse(row["fecha_baja"].ToString());

            return oUsuario;
        }

        public bool DeleteUsuarioById(int idUsuario)
        {
            string strSql = "UPDATE USUARIO " +
                            "SET fecha_baja = GETDATE() " +
                            "WHERE usuario_id = " + idUsuario.ToString();

            DBHelperSql.GetDBHelper().EjecutarSQL(strSql);
            return true;
        }

        public bool UpdateUsuarioById(UsuarioDTO oUsuario, IList<int> perfiles)
        {
            string strSql = "UPDATE USUARIO SET nombre_usuario = '" + oUsuario.NombreUsuario.ToString() + "' ";

            if (oUsuario.Pass != "")
            {
                strSql += ", pass = '" + oUsuario.Pass.ToString() + "'";
                strSql += ", forzar_password = '" + oUsuario.ForzarPassword.ToString() + "' ";
            }

            strSql += "WHERE usuario_id = "   + oUsuario.IdUsuario.ToString();

            DBHelperSql.GetDBHelper().EjecutarSQL(strSql);
            
            strSql = "DELETE FROM USUARIO_PERFIL WHERE usuario_id = " + oUsuario.IdUsuario.ToString();
            DBHelperSql.GetDBHelper().EjecutarSQL(strSql);

            if (perfiles.Count != 0)
            {
                strSql = "INSERT INTO USUARIO_PERFIL(usuario_id, perfil_id) " +
                            "VALUES";
                foreach (int IdPerfil in perfiles)
                {
                    strSql += "(" + oUsuario.IdUsuario + "," + IdPerfil + ")";
                    if (perfiles.Count - 1 != perfiles.IndexOf(IdPerfil))
                    {
                        strSql += ",";
                    }
                }

                DBHelperSql.GetDBHelper().EjecutarSQL(strSql);
            }
            
            return true;
        }

        public bool UpdateUsuarioById(UsuarioDTO oUsuario)
        {
            string strSql = "UPDATE USUARIO SET nombre_usuario = '" + oUsuario.NombreUsuario.ToString() + "' ";

            if (oUsuario.Pass != "")
            {
                strSql += ", pass = '" + oUsuario.Pass.ToString() + "'";
                strSql += ", forzar_password = '" + oUsuario.ForzarPassword.ToString() + "' ";
            }

            strSql += "WHERE usuario_id = " + oUsuario.IdUsuario.ToString();

            DBHelperSql.GetDBHelper().EjecutarSQL(strSql);
            return true;
        }

        public bool InsertUsuario(UsuarioDTO oUsuario, IList<int> perfiles)
        {
            string strSql = "INSERT INTO USUARIO(nombre_usuario, pass, forzar_password, fecha_alta) " +
                            "VALUES(" +
                            "'" + oUsuario.NombreUsuario.ToString()     + "'," +
                            "'" + oUsuario.Pass.ToString()              + "'," +
                            "True," +
                            "GETDATE())";

            DBHelperSql.GetDBHelper().EjecutarSQL(strSql);

            if (perfiles.Count != 0)
            {
                strSql = "INSERT INTO USUARIO_PERFIL(usuario_id, perfil_id) " +
                            "VALUES";
                foreach (int IdPerfil in perfiles)
                {
                    strSql += "(" + oUsuario.IdUsuario + "," + IdPerfil + "),";
                }
                strSql.Remove(strSql.Length, 1);
                DBHelperSql.GetDBHelper().EjecutarSQL(strSql);
            }
            return true;
        }
    }
}
