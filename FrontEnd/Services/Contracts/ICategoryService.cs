using BShop.Web.Models;

namespace BShop.Web.Services.Contracts;


public interface ICategoryService
{
    Task<IEnumerable<CategoryViewModel>> GetAllCategories(string token);
}
