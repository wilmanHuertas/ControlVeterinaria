using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public interface IVeterinarioRepository
    {
        Tasks<IEnumerable<Veterinario>> GetVeterinarios();
        Tasks<Veterinario> GetVeterinario(int Id);
        Tasks<Veterinario> AddVeterinario(Veterinario Veterinario);
        Tasks<Veterinario> UpdateVeterinario(Veterinario Veterinario);
        void DeleteVeterinario(int Id);
    }
}