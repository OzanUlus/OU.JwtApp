using AutoMapper;
using OU.JwtApp.Back.Core.Application.Dto;
using OU.JwtApp.Back.Core.Domain;

namespace OU.JwtApp.Back.Core.Application.Mapping
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryListDto>().ReverseMap();
        }
    }
}
