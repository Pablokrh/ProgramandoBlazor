using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Repositorio.Contrato;
using Ecommerce.Repositorio.DBContext;

namespace Ecommerce.Repositorio.Implementación
{
    public class GenericoRepositorio<TModelo> : IGenericoRepositorio<TModelo> where TModelo : class
    {
        private readonly DbecommerceContext _context;
        public GenericoRepositorio(DbecommerceContext context)
        {
            _context = context;
        }
        
        public IQueryable<TModelo> Consultar(Expression<Func<TModelo, bool>>? filtro = null)
        {
            //Si filtro es igual a nulo muestra todo. Select * from Modelo
            //Si no, hace Select * from Modelo where talCosa??filtro
            IQueryable<TModelo> consulta = (filtro == null) ? _context.Set<TModelo>() : _context.Set<TModelo>().Where(filtro);
            return consulta;
        }

        public async Task<TModelo> Crear(TModelo modelo)
        {
            try
            {
                _context.Set<TModelo>().Add(modelo);
                await _context.SaveChangesAsync();
                return modelo;
            }

            catch 
            {
                throw;
            }
        }

        public async Task<bool> Editar(TModelo modelo)
        {
            try
            {
                _context.Set<TModelo>().Update(modelo);
                await _context.SaveChangesAsync();
                return true;
            }

            catch
            {
                throw;
            }
        }

        public async Task<bool> Eliminar(TModelo modelo)
        { 
            try
            {
                _context.Set<TModelo>().Remove(modelo);
                await _context.SaveChangesAsync();
                return true;
            }

            catch
            {
                throw;
            }
        }
    }
}
