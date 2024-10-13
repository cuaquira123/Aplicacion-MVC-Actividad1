using Microsoft.EntityFrameworkCore;
using mvcProgramacionWebII.Models;

namespace mvcProgramacionWebII.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }


        public DbSet<Producto> Producto { get; set; }
    }
}
