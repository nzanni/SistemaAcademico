using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;

namespace SistemaAcademico.Pages.Alumnos
{
    public class TablaAlumnosModel : PageModel
    {
        public List<Alumno> ListaMostrarAlumnos;
        public void OnGet()
        {
            ListaMostrarAlumnos = DatosCompartidos.ListAlumnos;
        }
    }
}
