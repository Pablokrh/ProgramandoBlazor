using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaDonRemolo.Model;
using PizzeriaDonRemolo.DTO;
using AutoMapper;


namespace PizzeriaDonRemolo.Utilidades
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {      

            CreateMap<Categoria, CategoriaDTO>();
            CreateMap<CategoriaDTO, Categoria>();

            CreateMap<Producto, ProductoDTO>();
            //Acá le dice que ignore navigation ya que es distinta la variable.
            CreateMap<ProductoDTO, Producto>().ForMember(destino =>
            destino.IdCategoriaNavigation, opt => opt.Ignore()
            );
            CreateMap<DetalleVenta, DetalleVentaDTO>();
            CreateMap<DetalleVentaDTO, DetalleVenta>();

            CreateMap<Venta, VentaDTO>();
            CreateMap<VentaDTO, Venta>();
        }

       

    }
}
