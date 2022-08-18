using GerenciamentoDeVendas.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GerenciamentoDeVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OportunidadeController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        // GET: api/<OportunidadeController>
        [HttpGet]
        public IActionResult RecuperandoOportunidades()
        {
            return Ok( _appDbContext.Oportunidades.ToList());
        }

      
        [HttpGet("{id}")]
        public IActionResult RecuperandoFilmesPorId(int id)
        {
            var oportunidade =  _appDbContext.Oportunidades.FirstOrDefault(opt => opt.Id == id);
            if (oportunidade == null)
            {
                return NotFound();
            }
            return Ok();
        }

        
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<OportunidadeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OportunidadeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
