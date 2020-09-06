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
        [BindProperty] //Vincular con la clase de Curso (tbl)
        public Curso Curso { get; set; }
        public void OnGet()
        {

        }
    }
}