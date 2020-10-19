using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoCrudRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CursoCrudRazor.Pages.ListaCurso
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db; //para usar el constructor
        public EditModel(ApplicationDbContext db) //constructor para el contexto
        {
            _db = db;

        }
        [BindProperty] //Vincular con la clase de Curso (tbl)
        public Curso Curso { get; set; }
        public async Task OnGet(int id)
        {
            Curso = await _db.Cursos.FindAsync(id);
        }
        [TempData]
        public string Mensaje { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var CursoDesdeDb = await _db.Cursos.FindAsync(Curso.Id);
                CursoDesdeDb.NombreCurso = Curso.NombreCurso;
                CursoDesdeDb.CantidadClases = Curso.CantidadClases;
                CursoDesdeDb.Precio = Curso.Precio;
                await _db.SaveChangesAsync();
                Mensaje = "Editado correctamente";
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}