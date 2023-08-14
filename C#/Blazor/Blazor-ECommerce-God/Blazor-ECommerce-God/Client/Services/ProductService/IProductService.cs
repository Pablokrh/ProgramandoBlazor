namespace Blazor_ECommerce_God.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        Task GetProducts();

        Task<ServiceResponse<Product>> GetSingleProductWithId(int productId);
    }   
}
