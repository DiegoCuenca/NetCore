using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoCrudRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CursoCrudRazor.Pages.ListaCurso
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;

        }
        [BindProperty] //Vincular con la clase de Curso (tbl)
        public Curso Curso { get; set; }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();// para retornar a la misma pagina
            }
            _db.Add(Curso);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}