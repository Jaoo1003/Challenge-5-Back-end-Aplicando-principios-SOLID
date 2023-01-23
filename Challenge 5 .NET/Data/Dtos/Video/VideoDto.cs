using System.ComponentModel.DataAnnotations;

namespace Challenge_5_.NET.Data.Dtos.Video {
    public class VideoDto {
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Url { get; set; }
    }
}
