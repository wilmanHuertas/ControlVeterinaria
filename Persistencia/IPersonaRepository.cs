using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public interface IPersonaRepository
    {
        Tasks<IEnumerable<Persona>> GetPersonas();
        Tasks<Persona> GetPersona(int documento);
        Tasks<Persona> AddPersona(Persona Pesona);
        Tasks<Persona> UpdatePersona(Persona Persona);
        void DeletePersona(int documento);
    }
}