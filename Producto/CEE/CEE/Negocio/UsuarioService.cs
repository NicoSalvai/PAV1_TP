using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.AccesoDatos.Dao.Sql;
using CEE.AccesoDatos.Dao;
using CEE.Entidad;

namespace CEE.Negocio
{
    class UsuarioService
    {
        private IUsuarioDao oUsuarioDao;

        public UsuarioService()
        {
            oUsuarioDao = new UsuarioDaoSql();
        }

        public Usuario GetUsuarioById(int idUsuario)
        {
            return oUsuarioDao.GetUsuarioById(idUsuario);
        }

        public IList<Usuario> GetUsuarioByFilters(Dictionary<string, object> parametros)
        {
            return oUsuarioDao.GetUsuarioByFilters(parametros);
        }
    }
}
