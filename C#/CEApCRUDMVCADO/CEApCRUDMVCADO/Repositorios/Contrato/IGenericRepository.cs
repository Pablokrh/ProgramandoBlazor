namespace CEApCRUDMVCADO.Repositorios.Contrato
{
    public interface IGenericRepository<T> where T:class
    {
       Task<List<T>> GetLista();
       Task<bool> Guardar(T modelo);
       Task<bool> Editar(T modelo);
       Task<bool> Eliminar(int id);
    }
}
