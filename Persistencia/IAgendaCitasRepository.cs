using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public interface IAgendaCitasRepository
    {
        Tasks<IEnumerable<AgendaCitas>> GetCitas();
        Tasks<AgendaCitas> AgendaCitas(int idAgendaCita);
        Tasks<AgendaCitas> AddAgendaCitas(AgendaCitas AgendaCitas);
        Tasks<AgendaCitas> UpdateAgendaCitas(AgendaCitas AgendaCitas);
        void DeleteAgendaCitas(int idAgendaCita); 
    }
}