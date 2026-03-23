using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WebAPI8.Data
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        public DbSet<Models.DiretorModel> Diretores { get; set; }
            public DbSet<Models.FilmeModel> Filmes { get; set; }
  
    }
}
