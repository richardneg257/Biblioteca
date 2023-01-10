using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Entidades
{
    public class Autor
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(85)]
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
