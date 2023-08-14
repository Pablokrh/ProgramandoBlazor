using Blazor_ECommerce_God.Server.Data;
using Blazor_ECommerce_God.Shared;
using Microsoft.EntityFrameworkCore;

namespace Blazor_ECommerce_God.Server.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context) 
        { 
            _context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<Product>> GetSingleProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product=await _context.Products.FindAsync(productId);

            if (product == null) {
                response.Success = false;
                response.Message = "Sorry, this product doesn´t exist";
            }
            else
            {
                response.Data= product;
            }
            return response;
        }
    }
}
