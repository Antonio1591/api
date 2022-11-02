using api.Model.Domain;
using api.Model.Input;
using api.Model.View;
using api.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeService _ICidadeService;
        public CidadeController(ICidadeService ICidadeSerice)
        {
            _ICidadeService = ICidadeSerice;
        }

        [HttpGet]
        public IEnumerable<CidadeViewModel> ListaCidade()
        {
            return _ICidadeService.ListaCidade();
        }

        [HttpGet("{Id}")]

        public async Task<ActionResult<CidadeViewModel>> oberPorId(int Id)
        {
            return await _ICidadeService.ObterPorId(Id);
        }
        [HttpGet("Nome/{Nome}")]

        public async Task<ActionResult<CidadeViewModel>> ObterPOrNome(string Nome)
        {
            return await _ICidadeService.ObterPorNome(Nome);
        }

        [HttpPost("Resultado")]

        public async Task<ActionResult<Cidade>> AdicionarCidade([FromBody] CidadeInputModel input)
        {
            var cidade = await _ICidadeService.Create(input);

            return CreatedAtAction(nameof(Cidade), new { cidade.Id }, cidade);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Cidade>> DeletaCidade(int Id)
        {
            var deleteToCidade = _ICidadeService.ObterPorId(Id);
            if (deleteToCidade == null)
                NotFound();

            await _ICidadeService.Delete(deleteToCidade.Id);
            return NoContent();
        }
        [HttpPut]
        public async Task<ActionResult<Cidade>> AtuaizarCidade(int Id, [FromBody] Cidade cidade)
        {
            if (Id != cidade.Id)
                return BadRequest();

            await _ICidadeService.Update(cidade);
            return NoContent();
        }
    }
}