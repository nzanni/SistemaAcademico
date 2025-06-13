using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;

namespace SistemaAcademico.Pages
{
    public class EliminarAlumnoModel : PageModel
    {
        [BindProperty]

        public Alumno oAlumno { get; set; }
        public void OnGet(int id)
        {
            foreach (var alumno in DatosCompartidos.ListAlumnos)
            {
                if (alumno.Id == id)
                {
                    oAlumno = alumno;
                    break;
                }

            }
        }

        public IActionResult OnPost()
        {
            Alumno eliminarAlumno = null;

            foreach (var alumno in DatosCompartidos.ListAlumnos)
            {
                if (alumno.Id == oAlumno.Id)
                {
                    eliminarAlumno = alumno;
                    break;
                }
            }

            if (eliminarAlumno != null)
            {
                DatosCompartidos.ListAlumnos.Remove(eliminarAlumno);
            }

            return RedirectToPage("TablaAlumnos");

        }

    }
}
