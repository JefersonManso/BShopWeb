namespace BShop.ProductApi.Models;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public long Stock { get; set; }

    public string? ImageURL { get; set; }

    // Relação com Category
    public int CategoryId { get; set; }      // Chave estrangeira
    public Category? Category { get; set; }  // Navegação
}
