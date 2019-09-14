using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao.Sql
{
    class PersonaDaoSql : IPersonaDao
    {
        public PersonaDTO GetPersonaoById(int idPersona)
        {
            throw new NotImplementedException();
        }

        public IList<PersonaDTO> GetPersonaByFilters(Dictionary<string, object> parametros)
        {
            throw new NotImplementedException();
        }

        private PersonaDTO MappingPersona(DataRow row)
        {
            throw new NotImplementedException();
        }

        public bool DeletePersonaById(int idPersona)
        {
            throw new NotImplementedException();
        }

        public bool InsertPersona(PersonaDTO oPersona)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePersonaById(PersonaDTO oPersona)
        {
            throw new NotImplementedException();
        }
    }
}
