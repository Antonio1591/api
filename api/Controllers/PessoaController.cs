using api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;
using api.Model.Domain;
using api.Model.Input;
using System.Diagnostics;
using api.Model.View;
using api.Model.Mapping;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _IpessoaService;
        public PessoaController(IPessoaService Ipessoa)
        {
            _IpessoaService = Ipessoa;
        }

        [HttpGet]
        public  IEnumerable<PessoaViewModel> ListaPessoas()
        {
            return  _IpessoaService.ListaPessoas();
        }

        [HttpGet("{Id}")]

        public async Task<ActionResult<PessoaViewModel>> Pessoa(int Id)
        {
            return await _IpessoaService.ObterPorId(Id);
        }

        [HttpPost]

        public async Task<ActionResult<Pessoa>> AdicionarPessoa([FromBody] PessoaInputModel input)
        {
           var pessoa = await _IpessoaService.Create(input);

            return CreatedAtAction(nameof(pessoa), new { pessoa.Id }, pessoa);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Pessoa>> DeletePessoa(int Id)
        {
            var deletePessoa = _IpessoaService.ObterPorId(Id);
            if (deletePessoa == null)
                NotFound();

            await _IpessoaService.Delete(deletePessoa.Id);
            return NoContent();
        }
        [HttpPut]
        public async Task<ActionResult<Pessoa>> AtualizarPessoa(int Id, [FromBody] Pessoa pessoa)
        {
            if (Id != pessoa.Id)
                return BadRequest();

            await _IpessoaService.Update(pessoa);
            return NoContent();
        }
    }


}
