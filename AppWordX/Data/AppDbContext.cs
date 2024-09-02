using AppWordX.Models;
using Microsoft.EntityFrameworkCore;

namespace AppWordX.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {         
        }

        public DbSet<Documento> Documentos { get; set; }
    }
}
