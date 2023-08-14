using BlazorCrudShared;

namespace BlazorCrud.Cliente.Service
{
    public interface IDepartamentoService
    {
        Task<List<DepartamentoDTO>> Lista();
    }
}
