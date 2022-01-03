using Mapping.Console.Entities;

namespace Mapping.Console.Providers;

public static class DataProvider
{
    public static readonly Product ProductInstance = new()
    {
        Id = Guid.Parse("2c59b8c7-3bc1-434d-b17c-05297d3068b4"),
        Name = "Merina Koltuk Takımı Gri",
        UnitPrice = 8690,
        Description =
            "Fırınlanmış 1.sınıf gürgen ağacından üretilmiştir. Ağaçların nemi 10 dereceye kadar düşürülmüştür.",
        DefaultOption = new ProductVariant
        {
            Id = Guid.Parse("65c04e6b-df43-4052-8253-eeb67f42f193"),
            Color = "Gri"
        },
        Options = new List<ProductVariant>
        {
            new()
            {
                Id = Guid.Parse("1dfdcd48-c60d-4ca0-9695-72263715e14b"),
                Color = "Miami Serisi Terra Gri"
            },
            new()
            {
                Id = Guid.Parse("e28e2683-3692-4cad-bc1b-cc03d460f2bd"),
                Color = "Miami Serisi Aqua Koyu Gri"
            }
        }
    };
}