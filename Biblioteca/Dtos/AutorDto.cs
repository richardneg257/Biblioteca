using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Dtos
{
    public class AutorDto
    {
        [Required]
        [StringLength(80)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(85)]
        public string Apellido { get; set; }
        public string Email { get; set; }
    }
}
