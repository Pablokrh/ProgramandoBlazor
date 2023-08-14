using AutoMapper;
using Ecommerce.DTO;
using Ecommerce.Modelo;
using Ecommerce.Repositorio.Contrato;
using Ecommerce.Servicio.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Servicio.Implementación
{
    public class DashboardServicio:IDashboardServicio
    {
        private readonly IVentaRepositorio _ventaRepositorio;
        private readonly IGenericoRepositorio<Usuario> _usuarioRepositorio;
        private readonly IGenericoRepositorio<Producto> _productoRepositorio;
        
        public DashboardServicio(
            IVentaRepositorio ventaRepositorio,
            IGenericoRepositorio<Usuario> usuarioRepositorio,
            IGenericoRepositorio<Producto> productoRepositorio)
        {
            _ventaRepositorio = ventaRepositorio;
            _usuarioRepositorio = usuarioRepositorio;
            _productoRepositorio = productoRepositorio;   
        }

        private string Ingresos()
        {
            var consulta = _ventaRepositorio.Consultar();
            //Va a obtener los ingresos que tiene la suma de toda la tabla.
            decimal? ingresos=consulta.Sum(x=> x.Total);
            return Convert.ToString(ingresos);
        }

        private int Ventas()
        {
            var consulta = _ventaRepositorio.Consultar();
            int total = consulta.Count();
            return total;
        }
        private int Clientes()
        {
            var consulta = _usuarioRepositorio.Consultar(u=>u.Rol.ToLower()=="cliente");
            int total = consulta.Count();
            return total;
        }

        private int Productos()
        {
            var consulta = _productoRepositorio.Consultar();
            int total = consulta.Count();
            return total;
        }
        public DashBoardDTO Resumen()
        {
            try
            {
                DashBoardDTO dto = new DashBoardDTO()
                {
                    TotalIngresos = Ingresos(),
                    TotalVentas = Ventas(),
                    TotalCientes = Clientes(),
                    TotalProductos = Productos(),
                };

                return dto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }
    }
}
