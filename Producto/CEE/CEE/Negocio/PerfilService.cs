using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEE.AccesoDatos.Dao;
using CEE.Entidad;

namespace CEE.Negocio
{
    class PerfilService
    {
        private PerfilDao oPerfilDao;

        public PerfilService()
        {
            oPerfilDao = new PerfilDao();
        }

        public Perfil GetPerfilById(int idUsuario)
        {
            return oPerfilDao.GetPerfilById(idUsuario);
        }

        public IList<Perfil> GetPerfilByFilters(Dictionary<string, object> parametros)
        {
            return oPerfilDao.GetPerfilByFilters(parametros);
        }
    }
}
