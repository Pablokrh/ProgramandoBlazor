using Inmobiliaria.DTO;
using Inmobiliaria.Repositorio.Contrato;
using Inmobiliaria.Servicios.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Inmobiliaria.Modelo;
using Inmobiliaria.Repositorio.Implementacion;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Servicios.Implementacion
{
    public class UsuarioServicio : IUsuarioServicio
    {
        private readonly IGenericoRepositorio<Usuario> _modeloRepositorio;
        private readonly IMapper _mapper;
        public UsuarioServicio(IGenericoRepositorio<Usuario> modeloRepositorio, IMapper mapper)
        {
            _modeloRepositorio = modeloRepositorio;
            _mapper = mapper;
            
        }

        public async Task<SesionDTO> Autorizacion(LoginDTO modelo)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(p => p.Correo==modelo.Correo && p.Clave == modelo.Clave);
                var fromDbModelo = await consulta.FirstOrDefaultAsync();

                if (fromDbModelo != null) {
                    //Si hay un usuario con ese correo y clave, retorna como respuesta la sesión
                    //SesiónDTO lo llena con fromDbModelo
                    return _mapper.Map<SesionDTO>(fromDbModelo);
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

        public async Task<UsuarioDTO> Crear(UsuarioDTO modelo)
        {
            try
            {
                //Llega por parámetro un usuarioDTO y se lo convierte a Usuario.
                Usuario dbModelo = _mapper.Map<Usuario>(modelo);
                await _modeloRepositorio.Crear(dbModelo);

                if (dbModelo.IdUsuario != 0)
                {
                    return _mapper.Map<UsuarioDTO>(dbModelo);
                }
                else
                {
                    throw new TaskCanceledException("No se puede crear");
                }

                /* ASÍ ESTABA EN EL ORIGINAL, CON UNA VARIABLE AL PEDO.
                var dbModelo=_mapper.Map<Usuario>(modelo);
                var rspModelo = await _modeloRepositorio.Crear(dbModelo);

                if (rspModelo.IdUsuario != 0)
                {
                    return _mapper.Map<UsuarioDTO>(rspModelo);
                }
                else
                {
                    throw new TaskCanceledException("No se puede crear");
                }
                */
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Editar(UsuarioDTO modelo)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(p => p.IdUsuario == modelo.IdUsuario);
                var fromDbModelo = await consulta.FirstOrDefaultAsync();

                if (fromDbModelo != null)
                {
                    fromDbModelo.NombreCompleto = modelo.NombreCompleto;
                    fromDbModelo.Correo = modelo.Correo;
                    fromDbModelo.Clave = modelo.Clave;

                    var respuesta = await _modeloRepositorio.Editar(fromDbModelo);
                
                    if (!respuesta)
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
                var consulta = _modeloRepositorio.Consultar(p => p.IdUsuario == id);
                var fromDbModelo = await consulta.FirstOrDefaultAsync();

                if (fromDbModelo != null)
                {
                    var respuesta = await _modeloRepositorio.Eliminar(fromDbModelo);
                   
                    // acá solo entra en caso de ser falso
                    if (!respuesta)
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

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<UsuarioDTO>> Lista(string rol, string buscar)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(p =>
                p.Rol == rol &&
                string.Concat(p.NombreCompleto.ToLower(), p.Correo.ToLower()).Contains(buscar.ToLower()));
            //Junta nombre y mail, lo pasa a minuscula y ahí busca si está el texto que
            //se le pasa por parámetro.

                List<UsuarioDTO > lista=_mapper.Map<List<UsuarioDTO>>(await  consulta.ToListAsync());
                return lista;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<UsuarioDTO> Obtener(int id)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(p => p.IdUsuario == id);
                var fromDbModelo = await consulta.FirstOrDefaultAsync();           
            
                if (fromDbModelo != null)
                {
                    return _mapper.Map<UsuarioDTO>(fromDbModelo);
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
