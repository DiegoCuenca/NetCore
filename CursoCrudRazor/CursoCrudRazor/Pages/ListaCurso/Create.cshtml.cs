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
        private readonly ApplicationDbContext _db; //para usar el constructor
        public CreateModel(ApplicationDbContext db) //constructor para el contexto
        {
            _db = db;

        }

        [BindProperty] //Vincular con la clase de Curso (tbl)
        public Curso Curso { get; set; }

        [TempData]
        public string Mensaje { get; set; }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();// para retornar a la misma pagina
            }
            _db.Add(Curso);// para guardar en la bdd
            await _db.SaveChangesAsync(); // xq usamos un metodo asincrono
            Mensaje = "Curso creado correctamente";
            return RedirectToPage("Index"); //redirige a la pagina de inicio
        }
    }
}