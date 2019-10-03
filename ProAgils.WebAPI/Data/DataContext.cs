using Microsoft.EntityFrameworkCore;
using ProAgils.WebAPI.Model;

namespace ProAgils.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Evento> Eventos { get; set; }
    }
}