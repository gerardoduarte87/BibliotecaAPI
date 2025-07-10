using System.ComponentModel.DataAnnotations;

namespace BibliotecaAPI.Models
{
    public class Biblioteca
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nombre { get; set; }

        [StringLength(200)]
        public string? Direccion { get; set; }

        [StringLength(20)]
        public string? Telefono { get; set; }
    }
}
