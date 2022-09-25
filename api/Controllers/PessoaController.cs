using api.Migrations;
using api.Model;
using api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController:ControllerBase
    {
        private readonly IPessoa _Ipessoa;
        public PessoaController(IPessoa Ipessoa)
        {
            _Ipessoa = Ipessoa;
        }

        [HttpGet]
        public async Task<IEnumerable<Pessoa>> ListaPessoas()
        {
            return await _Ipessoa.ListaPessoas();
        }

        [HttpGet("{Id}")]

        public async Task<ActionResult<Pessoa>> Pessoa(int Id)
        {
            return await _Ipessoa.Pessoa(Id);
        }

        [HttpPost]

        public async Task<ActionResult<Pessoa>> AdicionarPessoa([FromBody] Pessoa pessoa)
        {
            var newPessoa = await _Ipessoa.Create(pessoa);
            return CreatedAtAction(nameof(pessoa),new {newPessoa.Id},newPessoa);
        }
        
        [HttpDelete("{Id}")]
        public async Task<ActionResult<Pessoa>>DeletePessoa(int Id)
        {
           var deletePessoa= _Ipessoa.Pessoa(Id);
            if (deletePessoa == null)
                NotFound();

                await _Ipessoa.Delete(deletePessoa.Id);
            return NoContent();
        }
        [HttpPut]
        public async Task<ActionResult<Pessoa>> AtualizarPessoa(int Id,[FromBody] Pessoa pessoa)
        {
            if (Id != pessoa.Id)
                return BadRequest();

              await  _Ipessoa.Update(pessoa);
            return NoContent();
        }
    }


}
