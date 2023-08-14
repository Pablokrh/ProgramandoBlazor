using CEApCRUDMVCADO.Models;
using CEApCRUDMVCADO.Repositorios.Contrato;
using System.Data.SqlClient;

namespace CEApCRUDMVCADO.Repositorios.Implementación
{
    public class DepartamentoRepository:IGenericRepository<Departamento>
    {
        private readonly string _cadenaSql = "";
        string pipeta = "";
        //Como parámetro recibe la configuración, para poder recibir la cadena de conexión.
        public DepartamentoRepository(IConfiguration configuracion)
        {
            _cadenaSql = configuracion.GetConnectionString("CadenaDeConexion");
            pipeta = "Carlos";
        }


        public async Task<List<Departamento>> GetLista()
        {
            List<Departamento> _lista=new List<Departamento>();
            using (var conexion = new SqlConnection(_cadenaSql))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_ListaDepartamentos", conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        _lista.Add(new Departamento
                        {
                            idDepartamento = Convert.ToInt32(dr["idDepartamento"]),
                            nombre = dr["nombre"].ToString()
                        });
                    }
                }
            }
            return _lista;
        }







//Los de abajo no los va a implementar.
        public Task<bool> Editar(Departamento modelo)
        {
            throw new NotImplementedException();
        }
        
        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

     
        public Task<bool> Guardar(Departamento modelo)
        {
            throw new NotImplementedException();
        }
        
    }
}
