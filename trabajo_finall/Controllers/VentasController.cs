using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using trabajo_finall.Models;
using System.Threading.Tasks;
using trabajo_finall.Dtos;
using trabajo_finall.Data;

namespace trabajo_finall.Controllers
{
    [ApiController]
    [Route("ventas")]
    public class VentasController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public VentasController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost("añadir")]
        public async Task<IActionResult> Añadir([FromBody] VentaCreateDto dto)
        {
            var venta = new Venta
            {
              fecha = dto.fecha,
              total = dto.total,
            };

            dbContext.Ventas.Add(venta);
            await dbContext.SaveChangesAsync();

            return Ok(venta);
        }

        [HttpGet("detalles")]
        public async Task<IActionResult> Detalles(int id)
        {
            var venta = await dbContext.Ventas.FindAsync(id);
            if (venta == null)
                return NotFound($"venta {id} no existe");

            return Ok(venta);
        }

        [HttpPut("editar")]
        public async Task<IActionResult> Editar(int id, [FromBody] VentaUpdateDto dto)
        {
            var venta = await dbContext.Ventas.FindAsync(id);

            if (venta == null)
                return NotFound($"venta {id} no existe");

            venta.fecha = dto.fecha;
            venta.total = dto.total;

            await dbContext.SaveChangesAsync();

            return Ok(venta);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var venta = await dbContext.Ventas.FindAsync(id);

            if (venta == null)
                return NotFound($"venta {id} no existe");

            dbContext.Ventas.Remove(venta);
            await dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
