using System.ComponentModel.DataAnnotations;

namespace EstiloyBellezaMvc.Models
{
    public class Cita
    {
        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public string Telefono { get; set; } = string.Empty;

        [Required]
        public string Servicio { get; set; } = string.Empty;

        [Required]
        public string Fecha { get; set; } = string.Empty;

        [Required]
        public string Hora { get; set; } = string.Empty;
    }
}
