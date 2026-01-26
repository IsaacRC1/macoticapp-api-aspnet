using Microsoft.AspNetCore.Mvc;

namespace trabajo_finall.Controllers
{
    [ApiController]
    [Route("reportes")]
    public class ReportesController : ControllerBase
    {
        [HttpGet("generar")]
        public IActionResult Generar()
        {
            return Ok("Reporte generado");
        }
    }
}
