using Blazored.LocalStorage;
using Blazored.Toast.Services;
using Ecommerce.DTO;
using Ecommerce.WebAssembly.Servicio.Contrato;

namespace Ecommerce.WebAssembly.Servicio.Implementacion
{
    public class CarritoServicio : ICarritoServicio
    {
        private ILocalStorageService _localStorageService;
        private ISyncLocalStorageService _syncLocalStorageService;
        private IToastService _toastService;

        public CarritoServicio(
         ILocalStorageService localStorageService,
         ISyncLocalStorageService syncLocalStorageService,
         IToastService toastService            
            )
        {
            _localStorageService = localStorageService;
            _syncLocalStorageService = syncLocalStorageService;
            _toastService = toastService;
        }

        public event Action MostrarItems;

        public async Task AgregarCarrito(CarritoDTO modelo)
        {
            try
            {
                //Acá se intenta obtener toda la lista del carrito que se haya guardado.
                var carrito = await _localStorageService.GetItemAsync<List<CarritoDTO>>("carrito");
                if (carrito == null)
                {
                    carrito = new List<CarritoDTO>();
                }
                //encontrado busca si ya hay algún producto igual al que se acaba de seleccionar, a través de su id.
                var encontrado = carrito.FirstOrDefault(c => c.Producto.IdProducto == modelo.Producto.IdProducto);

                if (encontrado != null)
                {
                    //se elimina, así no hay duplicidad de productos dentro del carrito.
                    carrito.Remove(encontrado);
                }
                //acá se agrega, si no, solo se borraría de haber existido.
                carrito.Add(modelo);
                await _localStorageService.SetItemAsync("carrito", carrito);

                if (encontrado != null)
                {
                    _toastService.ShowSuccess("El producto fue actualizado");
                }
                else
                {
                    _toastService.ShowSuccess("El producto fue agregado al carrito");
                }
                //actualizar la vista:
                MostrarItems.Invoke();
            }

            catch (Exception ex)
            {
                _toastService.ShowError("No se pudo agregar al carrito");
            }
        }

        public int CantidadProductos()
        {
                var carrito = _syncLocalStorageService.GetItem<List<CarritoDTO>>("carrito");
                //Si el carrito es null se devuelve 0, si no, se devuelve el .Count();
                return carrito==null? 0 : carrito.Count();
         }

        public async Task<List<CarritoDTO>> DevolverCarrito()
        {
            var carrito = await _localStorageService.GetItemAsync<List<CarritoDTO>>("carrito");
            if (carrito == null)
            {
                //Si es nulo se crea un carrito. No se para qué corno sirve esto.
                //Se crea, pero queda vacío.
                carrito = new List<CarritoDTO>();
            }
            return carrito;
        }

        public async Task EliminarCarrito(int idProducto)
        {
            try
            {
                var carrito = await _localStorageService.GetItemAsync<List<CarritoDTO>>("carrito");
                if (carrito != null)
                {
                    var elemento = carrito.FirstOrDefault(c => c.Producto.IdProducto == idProducto);
                    if (elemento != null)
                    {
                        carrito.Remove(elemento);
                        await _localStorageService.SetItemAsync("carrito", carrito);
                        MostrarItems.Invoke();
                    }
                }
            }
            catch (Exception ex)
            {            }
        }

        public async Task LimpiarCarrito()
        {
            await _localStorageService.RemoveItemAsync("carrito");
            MostrarItems.Invoke();
        }
    }
}
