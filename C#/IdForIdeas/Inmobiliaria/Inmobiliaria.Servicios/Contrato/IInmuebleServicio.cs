using Inmobiliaria.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Servicios.Contrato
{
    public interface IInmuebleServicio
    {
        Task<List<InmuebleDTO>> Lista(string buscar);

        Task<List<InmuebleDTO>> Catalogo(string buscar);

        Task<InmuebleDTO> Obtener(int id);

        Task<InmuebleDTO> Crear(InmuebleDTO modelo);

        Task<bool> Editar(InmuebleDTO modelo);

        Task<bool> Eliminar(int id);
    }
}
