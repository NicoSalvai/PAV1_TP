using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao
{
    interface IPersonaDao
    {
        PersonaDTO GetPersonaById(int idPersona);
        IList<PersonaDTO> GetPersonaByFilters(Dictionary<string, object> parametros);
        bool DeletePersonaById(int idPersona);
        bool UpdatePersonaById(PersonaDTO oPersona);
        bool InsertPersona(PersonaDTO oPersona);
        
    }
}
