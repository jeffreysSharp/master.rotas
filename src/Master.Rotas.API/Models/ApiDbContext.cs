using Microsoft.EntityFrameworkCore;

namespace Master.Rotas.API.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Rota> Rotas { get; set; }
    }
}
