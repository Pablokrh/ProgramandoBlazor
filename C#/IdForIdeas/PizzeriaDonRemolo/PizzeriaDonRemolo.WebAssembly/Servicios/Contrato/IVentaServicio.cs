using PizzeriaDonRemolo.DTO;

namespace PizzeriaDonRemolo.WebAssembly.Servicio.Contrato
{
    public interface IVentaServicio
    {
        Task<ResponseDTO<VentaDTO>> Registrar(VentaDTO modelo);
    }
}
