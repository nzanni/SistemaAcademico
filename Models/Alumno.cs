using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
    public class Alumno
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }


        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string? Apellido { get; set; }


        [Range(10000000, 99999999)]
        public int DNI { get; set; }


        [Required(ErrorMessage = "El email es obligatorio")]
        public string? Email { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaDeNacimiento { get; set; }
    }
}