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
    [Authorize]
    public class TipoGeneroController : ControllerBase
    {
        private TipoGeneroBL tipoGeneroBL = new TipoGeneroBL();

        [HttpGet]
        [AllowAnonymous]
        public async Task<IEnumerable<TipoGenero>> Get()
        {
            return await tipoGeneroBL.ObtenerTodosAsync();
        }
        [HttpGet("{id}")]
        public async Task<TipoGenero> Get(int id)
        {
            TipoGenero tipoGenero = new TipoGenero();
            tipoGenero.Id = id;
            return await tipoGeneroBL.ObtenerPorIdAsync(tipoGenero);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TipoGenero tipoGenero)
        {
            try
            {
                await tipoGeneroBL.CrearAsync(tipoGenero);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] TipoGenero tipoGenero)
        {
            if (tipoGenero.Id == id)
            {
                await tipoGeneroBL.ModificarAsync(tipoGenero);
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
                TipoGenero tipogenero = new TipoGenero();
                tipogenero.Id = id;
                await tipoGeneroBL.EliminarAsync(tipogenero);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPost("Buscar")]
        public async Task<List<TipoGenero>> Buscar([FromBody] object pTipoGenero)
        {
            var option = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string strTipoGenero = JsonSerializer.Serialize(pTipoGenero);
            TipoGenero tipoGenero = JsonSerializer.Deserialize<TipoGenero>(strTipoGenero, option);
            return await tipoGeneroBL.BuscarAsync(tipoGenero);
        }
    }
}
