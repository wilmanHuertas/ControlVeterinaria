using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class AsistenteVeterinaria
    {
        public int Id {get;set;}
        public ulong docVeterinaria {get;set;}
        public ulong docResponsable {get;set;}
        public string nombreResponsable {get;set;}
        public uint telefono {get;set;}
    }
}