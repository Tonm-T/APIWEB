using CatalogoGM.AccesoADatos;
using CatalogoGM.EntidadesDeNegocio;
using CatalogoGM.LogicaDeNegocio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CatalogoGM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaracteristicasGameController : ControllerBase
    {
        private CaracteristicasGameBL caracteristicasGameBL = new CaracteristicasGameBL();

        [HttpGet]
        [AllowAnonymous]
        public async Task<IEnumerable<CaracteristicasGame>> Get()
        {
            return await caracteristicasGameBL.ObtenerTodosAsync();
        }

        [HttpGet("{id}")]
        public async Task<CaracteristicasGame> Get(int id)
        {
            CaracteristicasGame caracteristicasGame = new CaracteristicasGame();
            caracteristicasGame.Id = id;
            return await caracteristicasGameBL.ObtenerPorIdAsync(caracteristicasGame);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CaracteristicasGame caracteristicasGame)
        {
            try
            {
                await caracteristicasGameBL.CrearAsync(caracteristicasGame);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public async Task<ActionResult> Put(int id, [FromBody] CaracteristicasGame caracteristicasGame)
        {
            if (caracteristicasGame.Id == id)
            {
                await caracteristicasGameBL.ModificarAsync(caracteristicasGame);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                CaracteristicasGame caracteristicasGame = new CaracteristicasGame();
                caracteristicasGame.Id = id;
                await caracteristicasGameBL.EliminarAsync(caracteristicasGame);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("Buscar")]
        public async Task<List<CaracteristicasGame>> Buscar([FromBody] object pCaracteristica)
        {
            var option = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string strCaracteristicaGame = JsonSerializer.Serialize(pCaracteristica);
            CaracteristicasGame caracteristicasGame = JsonSerializer.Deserialize<CaracteristicasGame>(strCaracteristicaGame);
            return await caracteristicasGameBL.BuscarAsync(caracteristicasGame);
        }
    }
}
