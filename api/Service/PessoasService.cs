using api.Data;
using api.Model.Domain;
using api.Model.Input;
using api.Model.Mapping;
using api.Model.View;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class PessoasService : IPessoaService
    {
        public readonly DataContext _context;

        public PessoasService(DataContext context)
        {
            _context = context;
        }
        public async Task<PessoaViewModel> Create(PessoaInputModel input)
        {
            var cidade = await _context.cidades.FindAsync(input.Cidade.Id);

            if (cidade == null) return null;

            var pessoa = new Pessoa(input.Nome, input.DataNascimento, cidade);


            _context.pessoa.Add(pessoa);

            await _context.SaveChangesAsync();

            return pessoa.ParaViewModel();
        }

        public async Task Delete(int id)
        {
            var pessoaToDelete = await _context.pessoa.FindAsync(id);
            _context.pessoa.Remove(pessoaToDelete);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<PessoaViewModel> ListaPessoas()
        {
            IEnumerable<PessoaViewModel> pessoas = _context.pessoa
                .Include(p => p.Cidade).ToList()
                .Select(p => p.ParaViewModel());
            return pessoas;

        }
        public IEnumerable<Pessoa> RetornaPessoa()
        {
            IEnumerable<Pessoa> pessoas = _context.pessoa
                .Include(p => p.Cidade).ToList();
            return pessoas;
        }
        public async Task<PessoaViewModel> ObterPorId(int id)
        {
            var dados = await _context.pessoa.FindAsync(id);
            var cidade = await _context.cidades.FindAsync(dados.Cidade.Id);
            if (cidade == null) return null;
            dados.Cidade = cidade;
            return dados.ParaViewModel();
        }

        public async Task Update(Pessoa pessoa)
        {
            //_context.Entry(pessoa).State = EntityState.Modified;
            _context.Update(pessoa);
            await _context.SaveChangesAsync();
        }
    }
}
