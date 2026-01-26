using Microsoft.AspNetCore.Mvc;

namespace trabajo_finall.Controllers
{
    [ApiController]
    [Route("añadir/[controller]")]
    public class UsuariosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var usuarios = new[]
            {
                new { Id = 1, Nombre = "Carlos" },
                new { Id = 2, Nombre = "María" },
                new { Id = 3, Nombre = "Carolina" },
                new { Id = 4, Nombre = "Jose" },
                new { Id = 5, Nombre = "Pedro" },
                new { Id = 6, Nombre = "Laura" }
            };

            return Ok(usuarios);
        }
    }
}
