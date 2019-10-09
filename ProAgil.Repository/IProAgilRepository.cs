using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public interface IProAgilRepository
    {
        // GERAL
        void Add<T> (T entity) where T : class;
        void Update<T> (T entity) where T : class;
        void Delete<T> (T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //EVENTOS
        Task<Evento[]> GetAllEventosAsyncByTema(string tema, bool includePalestrante);
        Task<Evento[]> GetAllEventosAsync(bool includePalestrante);
        Task<Evento> GetEventoAsyncById(int EventoId, bool includePalestrante);

        //PALESTRANTE
        Task<Palestrante[]> GetAllPalestrantesAsynByName(string name, bool includeEventos);
        Task<Palestrante> GetAllPalestranteAsyn(int PalestranteId, bool includeEventos);
    }
}