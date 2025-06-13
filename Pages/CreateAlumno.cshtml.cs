using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;

namespace SistemaAcademico.Pages
{
    public class CreateAlumnoModel : PageModel
    {
        [BindProperty]
        public Alumno oAlumno { get; set; }
        public void OnGet()
        {
        }
        public static int ultimoIdAlumno = 0;
        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            oAlumno.Id = DatosCompartidos.ObtenerNuevoIdAlumno();
            DatosCompartidos.ListAlumnos.Add(oAlumno);
            return RedirectToPage("TablaAlumnos");
        }
    }
}
