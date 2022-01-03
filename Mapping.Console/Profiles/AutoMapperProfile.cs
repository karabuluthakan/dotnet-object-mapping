using AutoMapper;
using Mapping.Console.Dtos;
using Mapping.Console.Entities;

namespace Mapping.Console.Profiles;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ProductVariant, ProductVariantDto>().ReverseMap();
        CreateMap<Product, ProductDto>()
            .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
            .ReverseMap();
    }
}