using BullyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BullyBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        //ctor + dos tabas crea el contructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        // Conjunto de Datos
        public DbSet<Category> Categories { get; set; }
    }
}
