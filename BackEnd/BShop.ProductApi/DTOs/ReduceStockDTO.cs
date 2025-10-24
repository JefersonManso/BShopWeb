using System.ComponentModel.DataAnnotations;

namespace BShop.ProductApi.DTOs;

public class ReduceStockDTO
{
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
    public int Quantity { get; set; }
}
