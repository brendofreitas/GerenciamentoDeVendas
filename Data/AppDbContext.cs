using GerenciamentoDeVendas.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoDeVendas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

       public DbSet<Usuario> Usuarios { get; set; }
    }
}
