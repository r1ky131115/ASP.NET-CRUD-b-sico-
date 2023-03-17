using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProducto _iProducto;

        public ProductoController(IProducto iProducto)
        {
            _iProducto = iProducto;
        }

        public IActionResult Index () 
        {
            var productos = _iProducto.ObtenerProductos();

            return View(productos);
        }

        public IActionResult Detalle(int id)
        {
            var producto = _iProducto.ObtenerProductoPorId(id);
            return View(producto);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Producto producto)
        {
            _iProducto.InsertarProducto(producto);

            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var producto = _iProducto.ObtenerProductoPorId(id);
            return View(producto);
        }

        [HttpPost]
        public IActionResult Editar(Producto producto)
        {
            _iProducto.ActualizarProducto(producto);

            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(int id)
        {
            var producto = _iProducto.ObtenerProductoPorId(id);

            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        [HttpPost]
        public IActionResult EliminarConfirmado(int id)
        {
            _iProducto.EliminarProducto(id);

            return RedirectToAction("Index");
        }
    }
}
