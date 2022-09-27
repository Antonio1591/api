using api.Data;
using api.Model;
using api.Service;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
        public async Task<Animais> CreateAnimal(Animais animal)
        {
            _context.animais.Add(animal);
            await _context.SaveChangesAsync();

            return animal;
        }

        public async Task Delete(int id)
        {
            var animaisToDelete = await _context.animais.FindAsync(id);
            _context.animais.Remove(animaisToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Animais>> ListaAnimais()
        {
            return await _context.animais.ToListAsync();
        }

        public async Task<Animais> animal(int id)
        {
            return await _context.animais.FindAsync(id);
        }

        public async Task Update(Animais animal)
        {
            //_context.Entry(pessoa).State = EntityState.Modified;
            _context.Update(animal);
            await _context.SaveChangesAsync();
        }
    }
}
