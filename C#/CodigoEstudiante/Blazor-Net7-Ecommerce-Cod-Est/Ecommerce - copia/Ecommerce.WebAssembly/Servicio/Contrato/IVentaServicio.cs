using Ecommerce.DTO;

namespace Ecommerce.WebAssembly.Servicio.Contrato
{
    public interface IVentaServicio
    {
        Task<ResponseDTO<VentaDTO>> Registrar(VentaDTO modelo);


    }
}
