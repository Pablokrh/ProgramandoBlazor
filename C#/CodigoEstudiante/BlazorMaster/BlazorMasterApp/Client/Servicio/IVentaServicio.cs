using BlazorMasterApp.Shared;

namespace BlazorMasterApp.Client.Servicio
{
    public interface IVentaServicio
    {
        Task<bool> Guardar(VentaDTO ventaDTO);

    }
}
