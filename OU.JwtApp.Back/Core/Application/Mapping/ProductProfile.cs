using AutoMapper;
using OU.JwtApp.Back.Core.Application.Dto;
using OU.JwtApp.Back.Core.Domain;

namespace OU.JwtApp.Back.Core.Application.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product,ProductlistDto>().ReverseMap();
        }
    }
}
