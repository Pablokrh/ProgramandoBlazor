using Ecommerce.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repositorio.Contrato
{
    public interface IGenericoRepositorio<TModelo> where TModelo : class
    {
        IQueryable<TModelo> Consultar(Expression<Func<TModelo,bool>>?filtro=null);
        //Func es una función genérica. Recibe un TModelo y devuelve un booleano. 
        //Por defecto será nulo. 
        //El filtro se puede poner si se desea o no.

        Task <TModelo> Crear(TModelo modelo);
        //Que se entienda, sería como poner: Task<Usuario> CrearUsuario(Usuario usuario);
        //Para cada modelo.

        Task<bool> Editar(TModelo modelo);

        Task<bool> Eliminar(TModelo modelo);
    }
}
