﻿using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string? Apellido { get; set; }
        [StringLength(8, ErrorMessage ="Máximo 8 caracteres")]
        public int DNI { get; set; }
        [Required(ErrorMessage = "El email es obligatorio")]
        public string? Email { get; set; }

        public DateTime FechaDeNacimiento { get; set; }
    }
}