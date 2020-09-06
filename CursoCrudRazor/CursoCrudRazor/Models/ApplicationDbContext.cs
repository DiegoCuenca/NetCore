using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCrudRazor.Models
{
    public class ApplicationDbContext : DbContext
    {
        // para poder invocar tablas  de la bdd como contextos y con todas las relaciones
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //public DbSet<Curso> Curso { get; set };
    }

    


}
