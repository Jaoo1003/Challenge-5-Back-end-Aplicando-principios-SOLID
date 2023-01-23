using System.ComponentModel.DataAnnotations;

namespace Challenge_5_.NET.Data.Dtos.Categoria {
    public class CategoriaDto {
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Cor { get; set; }
    }
}
