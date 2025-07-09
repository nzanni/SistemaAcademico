using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Models;


namespace SistemaAcademico.Pages
{
    public class IndexModel : PageModel
    {
        public List<Carrera> Carrera { get; set; }

    }
}
