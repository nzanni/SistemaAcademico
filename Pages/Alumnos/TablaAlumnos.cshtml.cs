using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;
using SistemaAcademico.Servicios;

namespace SistemaAcademico.Pages.Alumnos
{
    public class TablaAlumnosModel : PageModel
{
    public List<Alumno> ListaMostrarAlumnos { get; set; }

    public void OnGet()
    {
        ListaMostrarAlumnos = ServicioAlumno.ObtenerAlumnos();
    }
}
}

