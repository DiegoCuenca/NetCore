using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoCrudRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CursoCrudRazor.Pages.ListaCurso
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
         public IEnumerable<Curso> Cursos { get; set; } // para las lista de los valores

        public async Task OnGet() // se cambia el metodo void por async para mejorar el metodo
        {
            Cursos =await _db.Cursos.ToListAsync();

        }
    }
}