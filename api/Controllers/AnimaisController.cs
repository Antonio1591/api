using api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;
using api.Service;
using Microsoft.EntityFrameworkCore.Migrations.Internal;
using api.Model.Domain;
using api.Model.View;
using api.Model.Input;

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
        public IEnumerable<AnimaisViewModel> ListaAnimais()
        {
            return  _IAnimaisServices.ListaAnimais();
        }

        [HttpGet("{Id}")]

        public async Task<ActionResult<AnimaisViewModel>> Pessoa(int Id)
        {
            return await _IAnimaisServices.Animal(Id);
        }

        [HttpPost("Resultado")]

        public async Task<ActionResult<Animais>> AdicionarAnimais([FromBody] AnimaisInputModel animal)
        {
            var newAnimais = await _IAnimaisServices.Create(animal);
            return CreatedAtAction(nameof(Animais), new { newAnimais.Id }, newAnimais);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Animais>> DeletaAnimal(int Id)
        {
            var deletePessoa = _IAnimaisServices.Animal(Id);
            if (deletePessoa == null)
                NotFound();

            await _IAnimaisServices.Delete(deletePessoa.Id);
            return NoContent();
        }
        [HttpPut]
        public async Task<ActionResult<Animais>> AtualizarAnimal(int Id, [FromBody] Animais animais)
        {
            if (Id != animais.Id)
                return BadRequest();

            await _IAnimaisServices.Update(animais);
            return NoContent();
        }

    }
}
