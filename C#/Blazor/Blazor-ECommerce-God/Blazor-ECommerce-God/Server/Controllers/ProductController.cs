using Blazor_ECommerce_God.Server.Data;
using Blazor_ECommerce_God.Server.Services.ProductServices;
using Blazor_ECommerce_God.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blazor_ECommerce_God.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) 
        {            
           _productService = productService;
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var result = await _productService.GetProductsAsync();           
            return  Ok(result);
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetSingleProductsWithId(int productId)
        {
            var result = await _productService.GetSingleProductAsync(productId);
            return Ok(result);
        }





    }
}






