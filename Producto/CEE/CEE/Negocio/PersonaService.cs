using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.AccesoDatos.Dao;
using CEE.AccesoDatos.Dao.Sql;
using CEE.Negocio.DTO;

namespace CEE.Negocio
{
    class PersonaService
    {
        private IPersonaDao oPersonaDao;

        public PersonaService()
        {
            oPersonaDao = new PersonaDaoSql();
        }

        public PersonaDTO GetPersonaoById(int idPersona)
        {
            return oPersonaDao.GetPersonaoById(idPersona);
        }

        public IList<PersonaDTO> GetPersonaByFilters(Dictionary<string, object> parametros)
        {
            return oPersonaDao.GetPersonaByFilters(parametros);
        }
    }
}
