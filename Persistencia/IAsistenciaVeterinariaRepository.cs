using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public interface IAsistenciaVeterinariaRepository
    {
        Tasks<IEnumerable<AsistenteVeterinaria>> GetAsistentes();
        Tasks<AsistenteVeterinaria> GetAsistenteVeterinaria(int Id);
        Tasks<AsistenteVeterinaria> AddAsistenteVeterinaria(AsistenteVeterinaria AsistenteVeterinaria);
        Tasks<AsistenteVeterinaria> UpdateAsistenteVeterinaria(AsistenteVeterinaria AsistenteVeterinaria);
        void DeleteAsistenteVeterinaria(int Id);
    }
}