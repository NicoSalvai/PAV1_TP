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
    class PerfilDao
    {
        /// <summary>
        /// Me devuelve un objeto Perfil segun el id que le pase
        /// </summary>
        /// <param name="idPerfil"> El id del objeto Perfil buscado</param>
        /// <returns>El objeto perfil con id = idPerfil</returns>
        public Perfil GetPerfilById(int idPerfil)
        {
            var strSql = "SELECT 	P.perfil_id, " +
                        "P.nombre_perfil, " +
                        "P.descripcion, " +
                        "P.fecha_alta, " +
                        "P.fecha_baja " +
                        "FROM PERFIL P " +
                        "WHERE P.perfil_id = " + idPerfil.ToString();

            return MappingPerfil(DBHelper.DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        /// <summary>
        /// Me devuelve una IList de objetos Perfil segun los parametros que yo le envie
        /// </summary>
        /// <param name="parametros">Un Dictionary de string-object con los parametros para filtrar la busqueda</param>
        /// <returns>Operacion no soportada</returns>
        public IList<Perfil> GetPerfilByFilters(Dictionary<string, object> parametros)
        {
            throw new Exception("Operacion no soportada");
        }

        /// <summary>
        /// Le doy un objeto DataRow que contenga los datos de 1 objeto Perfil y me devuelve el Objeto perfil
        /// </summary>
        /// <param name="row"> La DataRow con los datos del perfil</param>
        /// <returns>un Objeto Perfil</returns>
        private Perfil MappingPerfil(DataRow row)
        {
            Perfil oPerfil = new Perfil();

            oPerfil.IdPerfil = Int32.Parse(row["perfil_id"].ToString());
            oPerfil.NombrePerfil = row["nombre_perfil"].ToString();
            oPerfil.FechaAlta = DateTime.Parse(row["fecha_alta"].ToString());

            if(!DBNull.Value.Equals(row["fecha_baja"]))
                oPerfil.FechaBaja = DateTime.Parse(row["fecha_baja"].ToString());
            
            oPerfil.Descripcion = row["descripcion"].ToString();

            oPerfil.Menus = GetPerfilMenus(oPerfil.IdPerfil);

            return oPerfil;
        }

        /// <summary>
        /// Le paso el id de un objeto Perfil y me devuelve el conjunto de Menus que este perfil posee habilitados
        /// </summary>
        /// <param name="idPerfil">El id del perfil que quiero conocer sus menus</param>
        /// <returns>Una Lista de objetos Menu</returns>
        private IList<Menu> GetPerfilMenus(int idPerfil)
        {
            List<Menu> menus = new List<Menu>();        // armo la lista de menus a devolver
            MenuDaoSql menuDao = new MenuDaoSql();            // creo el menuDao para poder buscar los menus del perfil

            string strSql = "SELECT PM.menu_id " +
                        "FROM PERFIL_MENU PM " +
                        "WHERE PM.perfil_id = " + idPerfil.ToString();

            //List<string> list = DBHelper.DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows.OfType<DataRow>().Select(dr => (string)dr["menu_id"]).ToList();

            DataTable dt = DBHelper.DBHelper.GetDBHelper().ConsultaSQL(strSql);             // aca consigo la DataTable con el BDHelper que tenga los menu_id de este perfil 
            List<string> list = dt.Rows.OfType<DataRow>().Select(dr => (string)dr["menu_id"].ToString()).ToList(); // convierto la dt de 1 columna en una lista de strings

            foreach (string idMenu in list)     // por cada uno de los string de la lista mando al menuDao un pedido de que me traiga el menu q le corresponde y lo meto a mi lista
            {
                menus.Add(menuDao.GetMenuById(Int32.Parse(idMenu)));
            }

            return menus;
        }
    }
}
