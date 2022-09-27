using api.Model;
using api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;
using api.Service;
using Microsoft.EntityFrameworkCore.Migrations.Internal;

namespace api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AnimaisController : ControllerBase
    {
        private readonly IAnimaisServices _IAnimaisServices;
        public AnimaisController(IAnimaisServices animaisServices)
        {
            _IAnimaisServices = animaisServices;
        }

        [HttpGet]
        public async Task<IEnumerable<Animais>> ListaAnimais()
        {
            return await _IAnimaisServices.ListaAnimais();
        }

        [HttpGet("{Id}")]

        public async Task<ActionResult<Animais>> Pessoa(int Id)
        {
            return await _IAnimaisServices.animal(Id);
        }

        [HttpPost]

        public async Task<ActionResult<Animais>> AdicionarAnimais([FromBody] Animais animal)
        {
            var newAnimais = await _IAnimaisServices.CreateAnimal(animal);
            return CreatedAtAction(nameof(animal), new { newAnimais.Id }, newAnimais);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Animais>> DeletaAnimal(int Id)
        {
            var deletePessoa = _IAnimaisServices.animal(Id);
            if (deletePessoa == null)
                NotFound();

            await _IAnimaisServices.Delete(deletePessoa.Id);
            return NoContent();
        }
        [HttpPut]
        public async Task<ActionResult<Animais>> AtualizarAnimal(int Id, [FromBody] Animais pessoa)
        {
            if (Id != pessoa.Id)
                return BadRequest();

            await _IAnimaisServices.Update(pessoa);
            return NoContent();
        }

    }
}
