using System.Linq;
using AutoMapper;
using CityGuide.Models;
using CityGuide.Models.Dtos;

namespace CityGuide.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<City, CityForListDto>()
                     .ForMember(dest => dest.PhotoUrl, opt =>
                     {
                         opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain == true).Url);
                     });
            CreateMap<City, CityForDetailDto>();
        }
    }
}