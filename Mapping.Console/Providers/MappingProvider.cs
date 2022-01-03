using Mapping.Console.Dtos;
using Mapping.Console.Entities;
using Mapping.Console.Profiles;
using Mapster;

namespace Mapping.Console.Providers;

public static class MappingProvider
{
    private static readonly AutoMapper.IMapper _autoMapper =
        new AutoMapper.Mapper(new AutoMapper.MapperConfiguration(x => x.AddProfile(new AutoMapperProfile())));

    private static readonly MapsterMapper.IMapper _mapsterMapper =
        new MapsterMapper.Mapper(MapsterProfile.GetTypeAdapterConfig());

    static MappingProvider()
    {
        ExpressMapper.Mapper.Register<Product, ProductDto>();
    }

    public static ProductDto AutoMapperMap()
    {
        return _autoMapper.Map<ProductDto>(DataProvider.ProductInstance);
    }

    public static ProductDto ExpressMapperMap()
    {
        return ExpressMapper.Mapper.Map<Product, ProductDto>(DataProvider.ProductInstance);
    }

    public static ProductDto MapsterAdaptWithoutConfigMap()
    {
        var product = DataProvider.ProductInstance;
        return product.Adapt<ProductDto>();
    }

    public static ProductDto MapsterAdaptWithConfigMap()
    {
        var product = DataProvider.ProductInstance;
        var config = MapsterProfile.GetTypeAdapterConfig();
        return product.Adapt<ProductDto>(config);
    }

    public static ProductDto MapsterAdaptToTypeMap()
    {
        return _mapsterMapper.From(DataProvider.ProductInstance).AdaptToType<ProductDto>();
    }

    public static ProductDto ManuelMap()
    {
        var product = DataProvider.ProductInstance;
        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            UnitPrice = product.UnitPrice,
            DefaultOption = new ProductVariantDto
            {
                Id = product.DefaultOption.Id,
                Color = product.DefaultOption.Color
            },
            Options = product.Options.Select(x => new ProductVariantDto
            {
                Id = x.Id,
                Color = x.Color
            }).ToList()
        };
    }
}