using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Range(1, 10, ErrorMessage =  "Duración entre 1 y 10 años")]
        public int DuracionAnios { get; set; }
        [Required(ErrorMessage = "El titulo otorgado es obligatorio")]
        public string? TituloOtorgado { get; set; }
        public string? Modalidad { get; set; }
    }
}
