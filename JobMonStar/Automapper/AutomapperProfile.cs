using AutoMapper;
using JobMonStar.Data;
using JobMonStar.Models;

namespace JobMonStar.Automapper
{
    public class AutomapperProfile:Profile
    {
        public AutomapperProfile() {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>();
        }
    }
}
