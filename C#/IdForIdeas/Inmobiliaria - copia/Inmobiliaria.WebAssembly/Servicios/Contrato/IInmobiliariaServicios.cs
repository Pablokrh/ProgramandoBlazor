using Inmobiliaria.DTO;

namespace Inmobiliaria.WebAssembly.Servicios.Contrato


{
    public interface IInmobiliariaServicios
    {
        Task<ResponseDTO<List<InmuebleDTO>>> Lista(string buscar);

        Task<ResponseDTO<List<InmuebleDTO>>> Catalogo(string buscar);

        Task<ResponseDTO<InmuebleDTO>> Obtener(int id);

        Task<ResponseDTO<InmuebleDTO>> Crear(InmuebleDTO modelo);

        Task<ResponseDTO<bool>> Editar(InmuebleDTO modelo);

        Task<ResponseDTO<bool>> Eliminar(int id);

    }
}
