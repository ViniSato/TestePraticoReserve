using Microsoft.AspNetCore.Mvc;
using Voos.Services.Interfaces;

namespace APIVoos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VoosController : ControllerBase
    {
        [HttpGet("disponibilidade")]
        public async Task<IActionResult> GetVoo([FromQuery] string origem, [FromQuery] string destino, [FromQuery] string data, [FromServices] IVoosServices voosServices)
            => Ok(await voosServices.GetVoo(origem, destino, data));
    }
}
