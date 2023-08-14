using Blazor_ECommerce_God.Shared;

namespace Blazor_ECommerce_God.Server.Services.ProductServices
{
    public interface IProductService
{
        Task<ServiceResponse<List<Product>>> GetProductsAsync();

        Task<ServiceResponse<Product>> GetSingleProductAsync(int productId);

}
}
