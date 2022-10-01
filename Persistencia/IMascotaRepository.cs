using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public interface IMascotaRepository
    {
        Tasks<IEnumerable<Mascota>> GetMascotas();
        Tasks<Persona> GetMascota(int Id);
        Tasks<Persona> AddMascota(Mascota Mascota);
        Tasks<Persona> UpdateMascota(Mascota Mascota);
        void DeleteMascota(int Id);
    }
}