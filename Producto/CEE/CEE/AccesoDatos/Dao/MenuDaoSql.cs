using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEE.AccesoDatos.DBHelper;
using CEE.Entidad;

namespace CEE.AccesoDatos.Dao
{
    class MenuDaoSql
    {
        /// <summary>
        ///  devuelve un objeto Menu segun el id que le pase
        /// </summary>
        /// <param name="idMenu">El id del objeto menu a buscar</param>
        /// <returns>un objeto Menu</returns>
        public Menu GetMenuById(int idMenu)
        {
            string strSql = "SELECT menu_id," +
                "padre_menu_id, " +
                "nombre_menu, " +
                "es_final, " +
                "aplicacion " +
                "FROM MENU M " +
                "WHERE M.menu_id = " + idMenu.ToString();

            return MappingMenu(DBHelper.DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        /// <summary>
        /// Me devuelve la lista de objetos Menus segun los filtros pasados
        /// </summary>
        /// <param name="parametros">un Dictionary de string-object con los parametros para filtrar la busqueda</param>
        /// <returns>Operacion no soportada</returns>
        public IList<Menu> GetMenuByFilters(Dictionary<string, object> parametros)
        {
            throw new Exception("Operacion no soportada");
        }

        /// <summary>
        /// Le paso una DataRow con los datos de un objeto Menu y Me devuelve El objeto menu
        /// Arma el arbol de padres mediante recursividad llamando al metodo GetMenuId que lo llama a este mismo metodo
        /// </summary>
        /// <param name="row">el objeto DataRow que tiene los datos del menu en cuestion</param>
        /// <returns></returns>
        private Menu MappingMenu(DataRow row)
        {
            Menu oMenu = new Menu();

            oMenu.IdMenu = Int32.Parse(row["menu_id"].ToString());
            oMenu.NombreMenu = row["nombre_menu"].ToString();
            oMenu.EsFinal = Boolean.Parse(row["es_final"].ToString());
            oMenu.Aplicacion = row["aplicacion"].ToString();

            if (!DBNull.Value.Equals(row["padre_menu_id"]))
            {
                oMenu.MenuPadre = GetMenuById(Int32.Parse(row["padre_menu_id"].ToString()));
            }
            
            return oMenu;
        }
    }
}
