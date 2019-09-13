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
    class MenuDaoSql : IMenuDao
    {
        /// <summary>
        ///  devuelve un objeto Menu segun el id que le pase
        /// </summary>
        /// <param name="idMenu">El id del objeto menu a buscar</param>
        /// <returns>un objeto Menu</returns>
        public MenuDTO GetMenuById(int idMenu)
        {
            string strSql = "SELECT M.menu_id, " +
                            "M.nombre_menu, " +
                            "MP.nombre_menu AS 'padre_menu_nombre', " +
                            "M.padre_menu_id, " +
                            "M.es_final, " +
                            "M.aplicacion " +
                            "FROM MENU M " +
                            "LEFT JOIN MENU MP ON MP.menu_id = M.padre_menu_id " +
                            "WHERE M.menu_id = " + idMenu.ToString();

            return MappingMenu(DBHelperSql.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        /// <summary>
        /// Me devuelve la lista de objetos Menus segun los filtros pasados
        /// </summary>
        /// <param name="parametros">IdPerfil - IdUsuario</param>
        /// <returns>Operacion no soportada</returns>
        public IList<MenuDTO> GetMenuByFilters(Dictionary<string, object> parametros)
        {
            List<MenuDTO> resultado = new List<MenuDTO>();

            string strSql = "SELECT M.menu_id, " +
                            "M.nombre_menu, " +
                            "MP.nombre_menu AS 'padre_menu_nombre', " +
                            "M.padre_menu_id, " +
                            "M.es_final, " +
                            "M.aplicacion " +
                            "FROM MENU M ";

            if (parametros.ContainsKey("IdPerfil") || parametros.ContainsKey("IdUsuario"))
                strSql += "LEFT JOIN PERFIL_MENU PM ON PM.menu_id = M.menu_id ";
            if (parametros.ContainsKey("IdUsuario")){ 
                strSql += "LEFT JOIN PERFIL P ON P.perfil_id = PM.perfil_id " +
                          "LEFT JOIN USUARIO_PERFIL UP ON UP.perfil_id = P.perfil_id ";
            }
            strSql += "LEFT JOIN MENU MP ON MP.menu_id = M.padre_menu_id " +
                        "WHERE 1 = 1 ";

            if (parametros.ContainsKey("IdPerfil"))
                strSql += " AND (PM.perfil_id = @IdPerfil) ";
            if (parametros.ContainsKey("IdUsuario"))
                strSql += " AND (UP.usuario_id = @IdUsuario) ";

            DataTable dt = DBHelperSql.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(MappingMenu(row));
            }

            return resultado;
        }

        /// <summary>
        /// Le paso una DataRow con los datos de un objeto Menu y Me devuelve El objeto menu
        /// Arma el arbol de padres mediante recursividad llamando al metodo GetMenuId que lo llama a este mismo metodo
        /// </summary>
        /// <param name="row">el objeto DataRow que tiene los datos del menu en cuestion</param>
        /// <returns></returns>
        private MenuDTO MappingMenu(DataRow row)
        {
            MenuDTO oMenu = new MenuDTO();

            oMenu.IdMenu = Int32.Parse(row["menu_id"].ToString());
            oMenu.NombreMenu = row["nombre_menu"].ToString();
            oMenu.EsFinal = Boolean.Parse(row["es_final"].ToString());

            if (!DBNull.Value.Equals(row["aplicacion"]))
                oMenu.Aplicacion = row["aplicacion"].ToString();

            if (!DBNull.Value.Equals(row["padre_menu_id"]))
            {
                oMenu.IdMenuPadre = Int32.Parse(row["padre_menu_id"].ToString());
                oMenu.MenuPadre = row["padre_menu_nombre"].ToString();
            }

            return oMenu;
        }
    }
}
