﻿using System.ComponentModel.DataAnnotations;

namespace Challenge_5_.NET.Models {
    public class Video {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Url { get; set; }
    }
}