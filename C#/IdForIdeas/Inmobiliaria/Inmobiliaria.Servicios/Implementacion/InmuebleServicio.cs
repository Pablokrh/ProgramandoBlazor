using AutoMapper;
using Inmobiliaria.DTO;
using Inmobiliaria.Modelo;
using Inmobiliaria.Repositorio.Contrato;
using Inmobiliaria.Servicios.Contrato;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Servicios.Implementacion
{
    public class InmuebleServicio : IInmuebleServicio
    {
        private readonly IMapper _mapper;
        private readonly IGenericoRepositorio<Inmueble> _modeloRepositorio;


        public InmuebleServicio(IMapper mapper, IGenericoRepositorio<Inmueble> modeloRepositorio)
        {
            _mapper = mapper;
            _modeloRepositorio = modeloRepositorio;
        }

        public async Task<List<InmuebleDTO>> Catalogo(string buscar)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(i => i.Titulo.ToLower().Contains(buscar.ToLower()));

                List<InmuebleDTO> lista = _mapper.Map<List<InmuebleDTO>>(await consulta.ToListAsync());
                return lista;
            }

            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public async Task<InmuebleDTO> Crear(InmuebleDTO modelo)
        {
            //Se transforma de InmuebleDTO a Inmueble
            Inmueble dbModelo = _mapper.Map<Inmueble>(modelo);
            //Se agrega a la BBDD y se lo guarda en la variable.
            Inmueble rspModelo = await _modeloRepositorio.Crear(dbModelo);

            try
            {
                if (rspModelo.IdInmueble != 0)
                {
                    return _mapper.Map<InmuebleDTO>(rspModelo);
                }
                else
                {
                    throw new TaskCanceledException("No se pudo crear el inmueble");
                }           
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<bool> Editar(InmuebleDTO modelo)
        {
            //Acá el mapper queda de lado, con el Id del InmuebleDTO se busca el Inmueble
            Inmueble fromdbInmueble = await (_modeloRepositorio.Consultar(X => X.IdInmueble == modelo.IdInmueble)).FirstOrDefaultAsync();

            try
            {
                if (fromdbInmueble != null)
                {
                    fromdbInmueble.Titulo = modelo.Titulo;
                    fromdbInmueble.TipoInmueble = modelo.TipoInmueble;
                    fromdbInmueble.Detalles = modelo.Detalles;
                    fromdbInmueble.Pais = modelo.Pais;
                    fromdbInmueble.Ciudad = modelo.Ciudad;
                    fromdbInmueble.Ambientes = modelo.Ambientes;
                    fromdbInmueble.Metros = modelo.Metros;
                    fromdbInmueble.Antigüedad = modelo.Antigüedad;
                    fromdbInmueble.Precio = modelo.Precio;
                    fromdbInmueble.Expensas = modelo.Expensas;
                    fromdbInmueble.Estado = modelo.Estado;
                    fromdbInmueble.PublicadoPara = modelo.PublicadoPara;
                    fromdbInmueble.Destacado = modelo.Destacado;
                   

                    bool respuesta = await _modeloRepositorio.Editar(fromdbInmueble);

                    // EN EL ORIGINAL: if (!respuesta) 
                    if (respuesta != null)
                    {
                        throw new TaskCanceledException("No se pudo editar");
                    }
                    return respuesta;
                }
                else
                {
                    throw new TaskCanceledException("No se encontraron resultados");

                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }



        public async Task<bool> Eliminar(int id)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(p => p.IdInmueble == id);
                Inmueble fromDbInmueble = await consulta.FirstOrDefaultAsync();

                if (fromDbInmueble != null)
                {
                    var respuesta = await _modeloRepositorio.Eliminar(fromDbInmueble);
                    //EN EL ORIGINAL (!respuesta)
                    if (respuesta == false)
                    {
                        throw new TaskCanceledException("No se pudo eliminar");
                    }
                    return respuesta;
                }
                else
                {
                    throw new TaskCanceledException("No se encontraron resultados");
                }
            }
            catch (Exception ex) { throw ex; }      
        }


        
        public async Task<List<InmuebleDTO>> Lista(string buscar)
        {
            //SE HACE UNA BUSQUEDA SEGÚN EL "NOMBRE". QUIZAS ESTE NO ME SIRVA

            try
            {
                var consulta = _modeloRepositorio.Consultar(x => (x.Titulo).ToLower().Contains(buscar.ToLower()));

                List<InmuebleDTO> lista = _mapper.Map<List<InmuebleDTO>>(await consulta.ToListAsync());
                return lista;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        


        public async Task<InmuebleDTO> Obtener(int id)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(p => p.IdInmueble == id);               
                var fromDbModelo = await consulta.FirstOrDefaultAsync();

                if (fromDbModelo != null)
                {
                    return _mapper.Map<InmuebleDTO>(fromDbModelo);
                }

                else
                {
                    throw new TaskCanceledException("No se encontraron coincidencias");
                }

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
