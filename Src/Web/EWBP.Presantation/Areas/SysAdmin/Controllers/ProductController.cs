using EWBP.Application.Services.ProductService;
using Microsoft.AspNetCore.Mvc;

namespace EWBP.Presantation.Areas.SysAdmin.Controllers
{
    [Area("SysAdmin")]
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
