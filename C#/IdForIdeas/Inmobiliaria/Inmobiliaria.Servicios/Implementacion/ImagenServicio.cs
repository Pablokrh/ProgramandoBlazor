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
    public class ImagenServicio : IImagenServicio
    {
        private readonly IMapper _mapper;
        private readonly IGenericoRepositorio<Imagen> _modeloRepositorio;


        public ImagenServicio(IMapper mapper, IGenericoRepositorio<Imagen> modeloRepositorio)
        {
            _mapper = mapper;
            _modeloRepositorio = modeloRepositorio;
        }

        public Task<List<ImagenDTO>> Catalogo(string buscar)
        {
            throw new NotImplementedException();

        }

        public async Task<ImagenDTO> Crear(ImagenDTO modelo)
        {
            Imagen dbModelo = _mapper.Map<Imagen>(modelo);
            //Se agrega a la BBDD y se lo guarda en la variable.
            Imagen rspModelo = await _modeloRepositorio.Crear(dbModelo);

            try
            {
                if (rspModelo.IdInmueble != 0)
                {
                    return _mapper.Map<ImagenDTO>(rspModelo);
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

        public async Task<bool> Editar(ImagenDTO modelo)
        {
            //Acá el mapper queda de lado, con el Id del InmuebleDTO se busca el Inmueble
            Imagen fromdbimagen = await(_modeloRepositorio.Consultar(X => X.IdImagen == modelo.IdImagen)).FirstOrDefaultAsync();

            try
            {
                if (fromdbimagen != null)
                {
                    fromdbimagen.ImagenData=modelo.ImagenData;
                    fromdbimagen.IdInmueble=modelo.IdInmueble;         

                    bool respuesta = await _modeloRepositorio.Editar(fromdbimagen);

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
                var consulta = _modeloRepositorio.Consultar(p => p.IdImagen == id);
                Imagen fromDbImagen = await consulta.FirstOrDefaultAsync();

                if (fromDbImagen != null)
                {
                    var respuesta = await _modeloRepositorio.Eliminar(fromDbImagen);
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

        public async Task<List<ImagenDTO>> Lista(string buscar)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(x => (x.ImagenData).ToLower().Contains(buscar.ToLower()));

                //consulta = consulta.Include(c => c.ListaImagenes);


                List<ImagenDTO> lista = _mapper.Map<List<ImagenDTO>>(await consulta.ToListAsync());
                return lista;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ImagenDTO> Obtener(int id)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(p => p.IdImagen == id);
               // consulta = consulta.Include(c => c.IdCategoriaNavigation);
                var fromDbModelo = await consulta.FirstOrDefaultAsync();

                if (fromDbModelo != null)
                {
                    return _mapper.Map<ImagenDTO>(fromDbModelo);
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

        public async Task<ImagenDTO> ImagenPrincipal(int id)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(p => p.IdInmueble == id && p.EsImagenPrincipal==true);
                var fromDbModelo = await consulta.FirstOrDefaultAsync();

                if (fromDbModelo != null)
                {
                    return _mapper.Map<ImagenDTO>(fromDbModelo);
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

        public async Task<List<ImagenDTO>> ObtenerLista(int id)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(p => p.IdInmueble == id);
                // consulta = consulta.Include(c => c.IdCategoriaNavigation);
                var fromDbModelo = await consulta.ToListAsync();

                if (fromDbModelo != null)
                {
                    return _mapper.Map<List<ImagenDTO>>(fromDbModelo);
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
