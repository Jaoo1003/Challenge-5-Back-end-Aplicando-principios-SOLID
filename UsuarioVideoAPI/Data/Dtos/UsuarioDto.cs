using System.ComponentModel.DataAnnotations;

namespace UsuarioVideoAPI.Data.Dtos {
    public class UsuarioDto {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}