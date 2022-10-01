using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PersonaRepository: IPersonaRepository
    {
        private readonly appContext _appContext;
        public PersonaRepository(appContext AppContext)
        {      
            _appContext=AppContext;
        }
    }
}