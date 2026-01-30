using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using trabajo_finall.Models;
using System.Threading.Tasks;
using trabajo_finall.Dtos;
using trabajo_finall.Data;

namespace trabajo_finall.Controllers
{
    [ApiController]
    [Route("productos")]
    public class ProductosController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public ProductosController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost("añadir")]
        public async Task<IActionResult> Añadir([FromBody] ProductoCreateDto dto)
        {
            var producto = new Producto
            {
              nombre = dto.nombre,
              precio = dto.precio,
              stock = dto.stock,
            };

            dbContext.Productos.Add(producto);
            await dbContext.SaveChangesAsync();

            return Ok(producto);
        }

        [HttpGet("detalles")]
        public async Task<IActionResult> Detalles(int id)
        {
            var producto = await dbContext.Productos.FindAsync(id);
            if (producto == null)
                return NotFound($"Producto {id} no existe");

            return Ok(producto);
        }

        [HttpPut("editar")]
        public async Task<IActionResult> Editar(int id, [FromBody] ProductoUpdateDto dto)
        {
            var producto = await dbContext.Productos.FindAsync(id);

            if (producto == null)
                return NotFound($"Producto {id} no existe");

            producto.nombre = dto.nombre;
            producto.precio = dto.precio;
            producto.stock = dto.stock;

            await dbContext.SaveChangesAsync();

            return Ok(producto);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var producto = await dbContext.Productos.FindAsync(id);

            if (producto == null)
                return NotFound($"Producto {id} no existe");

            dbContext.Productos.Remove(producto);
            await dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
