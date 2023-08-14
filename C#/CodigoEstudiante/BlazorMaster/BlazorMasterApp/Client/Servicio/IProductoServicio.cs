using BlazorMasterApp.Shared;

namespace BlazorMasterApp.Client.Servicio
{
    public interface IProductoServicio
    {
        Task<List<ProductoDTO>> lista();

    }
}
