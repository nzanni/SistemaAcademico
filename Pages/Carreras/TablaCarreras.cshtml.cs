using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;
using SistemaAcademico.Servicios;
using System.Text.Json;

namespace SistemaAcademico.Pages
{
    public class TablaCarrerasModel : PageModel
    {
        public List<Carrera> ListaMostrarCarrera { get; set; }

        public void OnGet()
        {
            ListaMostrarCarrera = ServicioCarrera.ObtenerCarreras();
        }
    }
}

