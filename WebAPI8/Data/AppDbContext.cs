using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WebAPI8.Data
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
