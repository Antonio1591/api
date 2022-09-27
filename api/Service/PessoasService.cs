using api.Data;
using api.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Services
{
    public class PessoasService:IPessoa
    {
        public readonly DataContext _context;
             
        public PessoasService(DataContext context)
        {
            _context = context;
        }
        public async Task<Pessoa> Create(Pessoa pessoa)
        {
            _context.pessoa.Add(pessoa);
            await _context.SaveChangesAsync();

            return pessoa;
        }

        public async Task Delete(int id)
        {
            var pessoaToDelete = await _context.pessoa.FindAsync(id);
            _context.pessoa.Remove(pessoaToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Pessoa>> ListaPessoas()
        {
            return await _context.pessoa.ToListAsync();
        }

        public async Task<Pessoa> Pessoa(int id)
        {
            return await _context.pessoa.FindAsync(id);
        }

        public async Task Update(Pessoa pessoa)
        {
            //_context.Entry(pessoa).State = EntityState.Modified;
            _context.Update(pessoa);
            await _context.SaveChangesAsync();
        }
    }
}
