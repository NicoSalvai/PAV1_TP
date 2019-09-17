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
    public class PersonaService
    {
        private IPersonaDao oPersonaDao;
        public int IdPersonaSeleccionada { get; set; }
        public PersonaService()
        {
            oPersonaDao = new PersonaDaoSql();
        }

        public PersonaDTO GetPersonaById(int idPersona)
        {
            return oPersonaDao.GetPersonaById(idPersona);
        }

        public IList<PersonaDTO> GetPersonaByFilters(Dictionary<string, object> parametros)
        {
            return oPersonaDao.GetPersonaByFilters(parametros);
        }

        public bool UpdatePersonaById(PersonaDTO oPersona)
        {
            return oPersonaDao.UpdatePersonaById(oPersona);
        }

        public bool InsertPersona(PersonaDTO oPersona)
        {
            return oPersonaDao.InsertPersona(oPersona);
        }

        public bool DeletePersonaById(int idPersona)
        {
            return oPersonaDao.DeletePersonaById(idPersona);
        }
    }
}
