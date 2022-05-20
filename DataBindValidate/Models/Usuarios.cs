using System.ComponentModel.DataAnnotations;

namespace DataBindValidate.Models
{
    public class Usuarios
    {
        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "{0} {2} min {1} max and not empty")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        public string Edad { get; set; }
        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        public string Password { get; set; }
        [Required]
        public string CPassword { get; set; }
    }
}