using Inmobiliaria.Repositorio.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Repositorio.Implementacion
{
    public class GenericoRepositorio<Tmodel> : IGenericoRepositorio<Tmodel> where Tmodel : class
    {
        private readonly InmobiliariaContext _dbContexto;

        public GenericoRepositorio(InmobiliariaContext dbContexto)
        {
            _dbContexto = dbContexto;
        }        

        public IQueryable<Tmodel> Consultar(Expression<Func<Tmodel, bool>>? filtro = null)
        {
            IQueryable<Tmodel> consulta=(filtro==null)? _dbContexto.Set<Tmodel>() : _dbContexto.Set<Tmodel>().Where(filtro); 
            return consulta;
        }

        public async Task<Tmodel> Crear(Tmodel model)
        {
            try
            {
                _dbContexto.Set<Tmodel>().Add(model);
                await _dbContexto.SaveChangesAsync();
                return model;
            }

            catch
            {
                throw;
            }    
        }

        public async Task<bool> Editar(Tmodel model)
        {
            try
            {
                _dbContexto.Set<Tmodel>().Update(model);
                await _dbContexto.SaveChangesAsync();
                return true;
            }

            catch
            {
                throw;
            }
        }

        public async Task<bool> Eliminar(Tmodel model)
        {
            try
            {
                _dbContexto.Set<Tmodel>().Remove(model);
                await _dbContexto.SaveChangesAsync();
                return true;
            }

            catch
            {
                throw;
            }
        }
    }
}
