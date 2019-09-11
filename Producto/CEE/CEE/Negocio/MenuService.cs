using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CEE.AccesoDatos.Dao.Sql;
using CEE.AccesoDatos.Dao;
using CEE.Negocio.DTO;

namespace CEE.Negocio
{
    class MenuService
    {
        private IMenuDao oMenuDao;

        public MenuService()
        {
            oMenuDao = new MenuDaoSql();
        }

        public MenuDTO GetMenuById(int idMenu)
        {
            return oMenuDao.GetMenuById(idMenu);
        }

        public IList<MenuDTO> GetMenuByFilters(Dictionary<string, object> parametros)
        {
            return oMenuDao.GetMenuByFilters(parametros);
        }
    }
}
