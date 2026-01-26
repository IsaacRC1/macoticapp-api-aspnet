using Microsoft.AspNetCore.Mvc;

namespace trabajo_finall.Controllers
{
    [ApiController]
    [Route("productos")]
    public class ProductosController : ControllerBase
    {
        [HttpPost("añadir")]
        public IActionResult Añadir()
        {
            return Ok("Producto añadido");
        }

        [HttpDelete("eliminar")]
        public IActionResult Eliminar(int id)
        {
            return Ok($"Producto {id} eliminado");
        }

        [HttpPut("editar")]
        public IActionResult Editar(int id)
        {
            return Ok($"Producto {id} editado");
        }

        [HttpGet("detalles")]
        public IActionResult Detalles(int id)
        {
            return Ok($"Detalles del producto {id}");
        }
    }
}
