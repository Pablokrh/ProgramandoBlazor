using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Ecommerce.Modelo;
using Ecommerce.Repositorio.Contrato;
using Ecommerce.Repositorio.DBContext;

namespace Ecommerce.Repositorio.Implementación
{
    public class VentaRepositorio : GenericoRepositorio<Venta>, IVentaRepositorio
    {
        private readonly DbecommerceContext _context;


        public VentaRepositorio(DbecommerceContext context): base(context) 
        {
            _context = context;
        }

        public async Task<Venta> Registrar(Venta venta)
        {
            Venta ventaGenerada = new Venta();

            using (var transaction=_context.Database.BeginTransaction())
            {
                try
                {
                    //*** Resta a la BBDD los productos comprados ***

                    //DetalleVenta es una lista dentro de la clase venta
                    foreach (DetalleVenta item in venta.DetalleVenta)
                    {
                        Producto productoEncontrado = _context.Productos.Where(p => p.IdProducto == item.IdProducto).First();

                        productoEncontrado.Cantidad -= item.Cantidad;

                        _context.Productos.Update(productoEncontrado);

                        await _context.SaveChangesAsync();
                    }

                    //***Crear info en tabla de ventas

                    await _context.Venta.AddAsync(venta);
                    await _context.SaveChangesAsync();

                    //Llena de contenido a ventaGenerada
                    ventaGenerada = venta;

                    transaction.Commit();
                }
                catch 
                {
                    //Esto es para reestablecer si hubo algún error.
                    transaction.Rollback();
                    throw;
                }
                return ventaGenerada;
            }

        }
    }
}
