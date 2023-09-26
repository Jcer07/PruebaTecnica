using ApiPruebaTecnica.Modelo;
using ApiPruebaTecnica.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiPruebaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrabajadorController : ControllerBase
    {
        private readonly ITrabajadorService _trabajadorService;

        public TrabajadorController(ITrabajadorService trabajadorService)
        {
            _trabajadorService = trabajadorService;
        }

        [HttpGet]
        public async Task<List<Trabajador>> Get()
        {
            return await _trabajadorService.ObtenerListadoTrabajadoresAsync();
        }

        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] List<Trabajador> listado)
        {
            if(listado == null || listado.Count == 0)
            {
                return BadRequest("La lista es nula o vacía");
            }
            var result = await _trabajadorService.GuardarListadoTrabajadoresAsync(listado);
            if (result != null)
            {
                return Created("https://localhost:7239/api/Trabajador", result);
            }
            else
            {
                return BadRequest("No se pudo registrar los datos");
            }
        }

    }
}
