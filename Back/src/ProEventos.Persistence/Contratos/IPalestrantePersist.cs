using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
        //PALESTRANTES

        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos);

        Task<Palestrante[]> GetAllPalestrantesByAsync(bool IncludeEventos);

        Task<Palestrante> GetPalestranteByIdAsync(int palestrantesId, bool includeEventos);
    }
}