using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class AgendaCitas
    {
        [Key]
        public int idAgendaCita {get;set;}
        public int idMascota {get;set;}
        public int idVeterinario {get;set;}
        [DataType(DataType.Date)]
        public DateTime fechaHora {get;set;}
    }
}