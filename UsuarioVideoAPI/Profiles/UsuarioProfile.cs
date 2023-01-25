using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuarioVideoAPI.Data.Dtos;
using UsuarioVideoAPI.Model;

namespace UsuarioVideoAPI.Profiles {
    public class UsuarioProfile : Profile{

        public UsuarioProfile() {
            CreateMap<UsuarioDto, Usuario>();
            CreateMap<Usuario, IdentityUser<int>>();
        }
    }
}
