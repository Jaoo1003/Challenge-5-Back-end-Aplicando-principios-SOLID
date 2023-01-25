using System.ComponentModel.DataAnnotations;

namespace UsuarioVideoAPI.Data.Requests {
    public class AtivaContaRequest {
        [Required]
        public int UsuarioId { get; set; }
        [Required]
        public string ActivationCode { get; set; }
    }
}
