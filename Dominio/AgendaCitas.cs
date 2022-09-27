using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class AgendaCitas
    {
        public int idMascota {get;set;}
        public int idVeterinario {get;set;}
        public DateTime fecha {get;set;}
        public DateTime hora {get;set;}
    }
}