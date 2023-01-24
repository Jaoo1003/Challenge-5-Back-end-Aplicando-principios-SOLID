using AutoMapper;
using Challenge_5_.NET.Data.Dtos.Categoria;
using Challenge_5_.NET.Models;

namespace Challenge_5_.NET.Profiles {
    public class CategoriaProfile : Profile{

        public CategoriaProfile() {
            CreateMap<CategoriaDto, Categoria>();
        }
    }
}
