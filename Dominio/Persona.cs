using System;

namespace Dominio
{
    public class Persona
    {
        public int Id {get;set;}
        public ulong documento { get; set; }
        public string nombreCompleto { get; set; }
        public uint telefono { get; set; }
        public string contraseña { get; set; }
        public string perfil { get; set; }
        public string correo {get;set;}
    }
}
