using System.ComponentModel.DataAnnotations;

namespace BShop.Web.Models;

public class CategoryViewModel
{
    public int CategoryId { get; set; }
    
    public string? Name { get; set; }
}
