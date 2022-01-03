namespace Mapping.Console.Entities;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal UnitPrice { get; set; }
    public List<ProductVariant> Options { get; set; }
    public ProductVariant DefaultOption { get; set; }
}