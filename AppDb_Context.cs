using Evaluacion_Practica.Entity;
using Microsoft.EntityFrameworkCore;

namespace Evaluacion_Practica
{
    public class AppDb_Context : DbContext
    {
        public AppDb_Context(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set;}
    }
}
