using AppWeb_601_juanjoseortegagarcia;
using AppWeb_601_juanjoseortegagarcia.Models;
using Microsoft.EntityFrameworkCore;
namespace AppWeb_601_juanjoseortegagarcia.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Producto> Productos { get; set; }
    }
}
