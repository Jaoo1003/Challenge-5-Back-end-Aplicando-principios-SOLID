using AutoMapper;
using Challenge_5_.NET.Data.Dtos.Video;
using Challenge_5_.NET.Models;

namespace Challenge_5_.NET.Profiles {
    public class VideoProfile : Profile{

        public VideoProfile() {
            CreateMap<VideoDto, Video>();
        }
    }
}
