using Inmobiliaria.DTO;

namespace Inmobiliaria.WebAssembly.Servicios.Contrato
{
    public interface IImagenServicio
    {
        Task<ResponseDTO<List<ImagenDTO>>> Lista(string buscar);

        //Task<ResponseDTO<List<ImagenDTO>>> Catalogo(string buscar);

        Task<ResponseDTO<ImagenDTO>> Obtener(int id);

        Task<ResponseDTO<ImagenDTO>> ObtenerImagenPrincipal(int idInmueble);


        Task<ResponseDTO<List<ImagenDTO>>> ObtenerLista(int id);

        Task<ResponseDTO<ImagenDTO>> Crear(ImagenDTO modelo);

        Task<ResponseDTO<bool>> Editar(ImagenDTO modelo);

        Task<ResponseDTO<bool>> Eliminar(int id);

    }
}
