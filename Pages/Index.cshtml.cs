using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Models;
using SistemaAcademico.Servicios;

namespace SistemaAcademico.Pages
{
    public class IndexModel : PageModel
    {
        public List<Carrera> Carrera { get; set; }

        public void OnGet()
        {
            Carrera = ServicioCarrera.ObtenerCarreras();
        }
    }
}
