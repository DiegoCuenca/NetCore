using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCrudRazor.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre de Curso")] //permite identificar en las cabeceras
        public string NombreCurso { get; set; }        
        [Display(Name = "Cantidad de Clases")]
        public int CantidadClases { get; set; }
        [Display(Name = "Precio")]
        public int Precio { get; set; }
    }
}
