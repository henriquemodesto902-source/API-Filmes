using Microsoft.EntityFrameworkCore;

namespace Api_Filmes.Data
{
    public class AppDBContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDBContext(Microsoft.EntityFrameworkCore.DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Models.DiretorModel> Diretores { get; set; }
        public DbSet<Models.FilmesModel> Filmes { get; set; }
    }
}
