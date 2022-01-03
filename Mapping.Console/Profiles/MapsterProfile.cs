using Mapping.Console.Dtos;
using Mapping.Console.Entities;
using Mapster;

namespace Mapping.Console.Profiles;

public static class MapsterProfile
{
    public static TypeAdapterConfig GetTypeAdapterConfig()
    {
        var config = new TypeAdapterConfig();
        config.NewConfig<Product, ProductDto>();
        return config;
    }
}