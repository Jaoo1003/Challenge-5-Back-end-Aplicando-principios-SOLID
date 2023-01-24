using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text.Json.Serialization;

namespace Challenge_5_.NET.Models {
    public class Video {
        public int Id { get; set; }
        public int? CategoriaId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Url { get; set; }
        [JsonIgnore]
        public Categoria Categoria { get; set; }        
    }
}