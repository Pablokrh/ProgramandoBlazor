using Inmobiliaria.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Servicios.Contrato
{
    public interface IImagenServicio
    {
        Task<List<ImagenDTO>> Lista(string buscar);

        Task<List<ImagenDTO>> Catalogo(string buscar);

        Task<ImagenDTO> Obtener(int id);

        Task<List<ImagenDTO>> ObtenerLista(int id);

        Task<ImagenDTO> ImagenPrincipal(int id);

        Task<ImagenDTO> Crear(ImagenDTO modelo);

        Task<bool> Editar(ImagenDTO modelo);

        Task<bool> Eliminar(int id);

    }
}
