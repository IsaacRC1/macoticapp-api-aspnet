using Microsoft.AspNetCore.Mvc;

namespace trabajo_finall.Controllers
{
    [ApiController]
    [Route("ventas")]
    public class VentasController : ControllerBase
    {
        // POST /ventas/añadir
        [HttpPost("añadir")]
        public IActionResult Añadir()
        {
            return Ok("Venta añadida");
        }

        // PUT /ventas/editar?id=4
        [HttpPut("editar")]
        public IActionResult Editar([FromQuery] int id)
        {
            return Ok($"Venta {id} editada");
        }

        // DELETE /ventas/eliminar?id=4
        [HttpDelete("eliminar")]
        public IActionResult Eliminar([FromQuery] int id)
        {
            return Ok($"Venta {id} eliminada");
        }

        // GET /ventas/detalles?id=4
        [HttpGet("detalles")]
        public IActionResult Detalles([FromQuery] int id)
        {
            return Ok($"Detalles de la venta {id}");
        }
    }
}
