using Ecommerce.DTO;

namespace Ecommerce.WebAssembly.Servicio.Contrato
{
    public interface IDashBoardServicio
    {
        Task<ResponseDTO<DashBoardDTO>> Resumen();

    }
}
