using api.Data;
using api.Model.Domain;
using api.Model.Input;
using api.Model.Mapping;
using api.Model.View;
using api.Service;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace api.Services
{
    public class AnimaisService:IAnimaisServices
    {
        public readonly DataContext _context;

        public AnimaisService(DataContext context)
        {
            _context = context;
        }
        public async Task<AnimaisViewModel> Create(AnimaisInputModel imput)
        {
            Pessoa Responsavel = await _context.pessoa.FindAsync(imput.Responsavel.Id);
            if (Responsavel == null) return null;
            Responsavel.Cidade = await _context.cidades.FindAsync(Responsavel.Cidade.Id);
            if(Responsavel.Cidade == null) return null;

            var animais = new Animais(imput.Raca,imput.Nome,Responsavel,imput.Situacao);
            _context.Add(animais);
            await _context.SaveChangesAsync();

            return animais.ParaViewModel();
        }

        public async Task Delete(int id)
        {
            var animaisToDelete = await _context.animais.FindAsync(id);
            _context.animais.Remove(animaisToDelete);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<AnimaisViewModel> ListaAnimais()
        {
            IEnumerable<AnimaisViewModel> animais = _context.animais
                .Include(p => p.Responsavel).ToList()
                .Select(p => p.ParaViewModel());
            return animais;
        }

        public async Task<AnimaisViewModel> Animal(int id)
        {
            var animal= await _context.animais.FindAsync(id);
            if (animal == null) return null;
            return animal.ParaViewModel();
        }

        public async Task Update(Animais animal)
        {
            //_context.Entry(pessoa).State = EntityState.Modified;
            _context.Update(animal);
            await _context.SaveChangesAsync();
        }
    }
}
