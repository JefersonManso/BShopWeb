using BShop.Web.Models;
using BShop.Web.Services.Contracts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        // private readonly ICartService _cartService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
            // _cartService = cartService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProducts(string.Empty);

            if (products is null)
            {
                return View("Error");
            }

            return View(products);
        }



        [HttpGet]       
        public async Task<ActionResult<ProductViewModel>> ProductDetails(int id)
        {
            var product = await _productService.FindProductById(id, string.Empty);

            if (product is null)
                return View("Error");

            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(string message)
        {

            return View(new ErrorViewModel { ErrorMessage = message});
        }


        [Authorize]
        public async Task<IActionResult> Login()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Logout()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}
