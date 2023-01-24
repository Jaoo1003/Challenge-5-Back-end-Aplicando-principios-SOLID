using System.ComponentModel.DataAnnotations;

namespace Challenge_5_.NET.Data.Dtos.Categoria {
    public class CategoriaDto {
        [Required(ErrorMessage = "O Campo Titulo é obrigatório!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Campo Cor é obrigatório!")]
        public string Cor { get; set; }
    }
}
