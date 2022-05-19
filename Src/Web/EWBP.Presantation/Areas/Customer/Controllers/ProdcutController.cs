using EWBP.Application.Services.ProductService;
using Microsoft.AspNetCore.Mvc;

namespace EWBP.Presantation.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProdcutController : Controller
    {

        private readonly IProductService _productService;

        public ProdcutController(IProductService productService)
        {

            _productService = productService;
        }

        public async Task<IActionResult> List()
        {
            return View(await _productService.GetProducts());
        }
    }
}
