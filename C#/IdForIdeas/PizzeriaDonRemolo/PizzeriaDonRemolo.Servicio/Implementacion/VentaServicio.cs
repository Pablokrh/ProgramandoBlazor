using AutoMapper;
using PizzeriaDonRemolo.DTO;
using PizzeriaDonRemolo.Model;
using PizzeriaDonRemolo.Repositorio.Contrato;
using PizzeriaDonRemolo.Repositorio.Implementacion;
using PizzeriaDonRemolo.Servicio.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaDonRemolo.Servicio.Implementación
{
    public class VentaServicio:IVentaServicio
    {
        private readonly IVentaRepositorio _modeloRepositorio;
        private readonly IMapper _mapper;
        public VentaServicio(IVentaRepositorio modeloRepositorio, IMapper mapper)
        {
            _modeloRepositorio = modeloRepositorio;
            _mapper = mapper;
        }

        public async Task<VentaDTO> Registrar(VentaDTO modelo)
        {
            try
            {
                var dbModelo = _mapper.Map<Venta>(modelo);
                var ventaGenerada = await _modeloRepositorio.Crear(dbModelo);

                if (ventaGenerada.IdVenta == 0)
                {
                    throw new TaskCanceledException("No se puede registrar");

                }
                else
                {
                    return _mapper.Map<VentaDTO>(ventaGenerada);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
