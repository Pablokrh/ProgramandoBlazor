using CEApCRUDMVCADO.Models;
using CEApCRUDMVCADO.Repositorios.Contrato;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace CEApCRUDMVCADO.Repositorios.Implementación
{
    public class EmpleadoRepository : IGenericRepository<Empleado>
    {
        private readonly string _cadenaSql = "";

        public EmpleadoRepository(IConfiguration configuracion)
        {
            _cadenaSql = configuracion.GetConnectionString("CadenaDeConexion");
        }

        public async Task<List<Empleado>> GetLista()
        {
            List<Empleado> _lista = new List<Empleado>();
            using (var conexion = new SqlConnection(_cadenaSql))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_ListaEmpleados", conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        _lista.Add(new Empleado
                        {
                            idEmpleado = Convert.ToInt32(dr["idEmpleado"]),
                            nombreCompleto = dr["nombreCompleto"].ToString(),
                            refDepartamento = new Departamento()
                            {
                                idDepartamento = Convert.ToInt32(dr["idDepartamento"]),
                                nombre = dr["nombre"].ToString()
                            },
                            sueldo = Convert.ToInt32(dr["Sueldo"]),
                            fechaContrato = dr["fechaContrato"].ToString(),
                        });                 
                    }
                }
            }
            return _lista;
        }

        public async Task<bool> Editar(Empleado modelo)
        {
            using (var conexion = new SqlConnection(_cadenaSql))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_EditarEmpleado", conexion);
                cmd.Parameters.AddWithValue("@nombreCompleto", modelo.nombreCompleto);
                cmd.Parameters.AddWithValue("@idEmpleado", modelo.idEmpleado);
                cmd.Parameters.AddWithValue("@idDepartamento", modelo.refDepartamento.idDepartamento);
                cmd.Parameters.AddWithValue("@sueldo", modelo.sueldo);
                cmd.Parameters.AddWithValue("@fechaContrato", modelo.fechaContrato);
                cmd.CommandType = CommandType.StoredProcedure;

                int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                //Lo que sigue se relaciona a lo que retorna SQL Server:
                //Si elimina, edita o crea, retorna 1. Por eso si es mayor que 0, es exitoso.
                if (filasAfectadas > 0)
                {
                    return true;
                }
                else { return false; }
            }
        }

        public async Task<bool> Guardar(Empleado modelo)
        {
            using (var conexion = new SqlConnection(_cadenaSql))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_GuardarEmpleado", conexion);
                cmd.Parameters.AddWithValue("@nombreCompleto", modelo.nombreCompleto);
                cmd.Parameters.AddWithValue("@idDepartamento", modelo.refDepartamento.idDepartamento);
                cmd.Parameters.AddWithValue("@sueldo", modelo.sueldo);
                cmd.Parameters.AddWithValue("@fechaContrato", modelo.fechaContrato);
                cmd.CommandType = CommandType.StoredProcedure;

                int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                if (filasAfectadas > 0)
                {
                    return true;
                }
                else { return false; }
            }
        }
        public async Task<bool> Eliminar(int id)
        {
            using (var conexion = new SqlConnection(_cadenaSql))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_EliminarEmpleado", conexion);
                cmd.Parameters.AddWithValue("@idEmpleado", id);
                cmd.CommandType =CommandType.StoredProcedure;

                int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                if (filasAfectadas > 0)
                {
                    return true;
                }
                else { return false; }
            }
        }
    }
}
