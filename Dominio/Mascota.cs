using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mascota
    {
        public int Id {get;set;}
        public ulong docDueño {get;set;}
        public string nombreMascota {get;set;}
        public int edadMascota {get;set;}
        public string tipoMascota {get;set;}
        public string raza {get;set;}
    }
}