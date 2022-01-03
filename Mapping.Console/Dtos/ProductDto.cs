namespace Mapping.Console.Dtos;

public class ProductDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public List<ProductVariantDto> Options { get; set; }
    public ProductVariantDto DefaultOption { get; set; }
}