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
    class PerfilDaoSql : IPerfilDao
    {
        /// <summary>
        /// Me devuelve un objeto Perfil segun el id que le pase
        /// </summary>
        /// <param name="idPerfil"> El id del objeto Perfil buscado</param>
        /// <returns>El objeto perfil con id = idPerfil</returns>
        public PerfilDTO GetPerfilById(int idPerfil)
        {
            var strSql = "SELECT 	P.perfil_id, " +
                        "P.nombre_perfil, " +
                        "P.descripcion " +
                        "FROM PERFIL P " +
                        "WHERE P.perfil_id = " + idPerfil.ToString();

            return MappingPerfil(DBHelperSql.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        /// <summary>
        /// Me devuelve una IList de objetos Perfil segun los parametros que yo le envie
        /// </summary>
        /// <param name="parametros">NombrePerfil</param>
        /// <returns>Operacion no soportada</returns>
        public IList<PerfilDTO> GetPerfilByFilters(Dictionary<string, object> parametros)
        {
            List<PerfilDTO> resultado = new List<PerfilDTO>();

            var strSql = "SELECT P.perfil_id, " +
                        "P.nombre_perfil, " +
                        "P.descripcion " +
                        "FROM PERFIL P " +
                        "WHERE 1 = 1 ";

            if (parametros.ContainsKey("NombrePerfil"))
                strSql += " AND (U.nombre_perfil = @NombrePerfil) ";

            DataTable dt = DBHelperSql.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(MappingPerfil(row));
            }

            return resultado;
        }

        /// <summary>
        /// Le doy un objeto DataRow que contenga los datos de 1 objeto Perfil y me devuelve el Objeto perfil
        /// </summary>
        /// <param name="row"> La DataRow con los datos del perfil</param>
        /// <returns>un Objeto Perfil</returns>
        private PerfilDTO MappingPerfil(DataRow row)
        {
            PerfilDTO oPerfil = new PerfilDTO();

            oPerfil.IdPerfil = Int32.Parse(row["perfil_id"].ToString());
            oPerfil.NombrePerfil = row["nombre_perfil"].ToString();

            if (!DBNull.Value.Equals(row["descripcion"]))
                oPerfil.Descripcion = row["descripcion"].ToString();

            return oPerfil;
        }

        /// <summary>
        /// Le paso el id de un objeto Perfil y me devuelve el conjunto de Menus que este perfil posee habilitados
        /// </summary>
        /// <param name="idPerfil">El id del perfil que quiero conocer sus menus</param>
        /// <returns>Una Lista de objetos Menu</returns>
        private IList<MenuDTO> GetPerfilMenus(int idPerfil)
        {
            List<MenuDTO> menus = new List<MenuDTO>();        // armo la lista de menus a devolver
            IMenuDao menuDao = new MenuDaoSql();            // creo el menuDao para poder buscar los menus del perfil

            string strSql = "SELECT PM.menu_id " +
                        "FROM PERFIL_MENU PM " +
                        "WHERE PM.perfil_id = " + idPerfil.ToString();

            //List<string> list = DBHelper.DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows.OfType<DataRow>().Select(dr => (string)dr["menu_id"]).ToList();

            DataTable dt = DBHelper.DBHelperSql.GetDBHelper().ConsultaSQL(strSql);             // aca consigo la DataTable con el BDHelper que tenga los menu_id de este perfil 
            List<string> list = dt.Rows.OfType<DataRow>().Select(dr => (string)dr["menu_id"].ToString()).ToList(); // convierto la dt de 1 columna en una lista de strings

            foreach (string idMenu in list)     // por cada uno de los string de la lista mando al menuDao un pedido de que me traiga el menu q le corresponde y lo meto a mi lista
            {
                menus.Add(menuDao.GetMenuById(Int32.Parse(idMenu)));
            }

            return menus;
        }
    }
}
