using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCrudRazor.Models
{
    public class ApplicationDbContext : DbContext
    {
        // para crear los metodo up/down en el add-migration
        public DbSet<Curso> Cursos { get; set; }
        // para poder invocar tablas  de la bdd como contextos y con todas las relaciones
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        
    }

    


}
