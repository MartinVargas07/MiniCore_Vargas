using Microsoft.EntityFrameworkCore;
using VideoExplicativoAspNet.Models; // si tus Models están en ese namespace

namespace VideoExplicativoAspNet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Empleado> Empleados { get; set; } = null!;
        public DbSet<Departamento> Departamentos { get; set; } = null!;
        public DbSet<Gasto> Gastos { get; set; } = null!;
    }
}
