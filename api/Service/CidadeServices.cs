using api.Data;
using api.Model.Domain;
using api.Model.Input;
using api.Model.Mapping;
using api.Model.View;
using api.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace api.Service
{
    public class CidadeServices : ICidadeService
    {
        public readonly DataContext _context;

        public CidadeServices(DataContext context)
        {
            _context = context;
        }
        public async Task<CidadeViewModel> Create(CidadeInputModel imput)
        {
            //Cidade cidade = await _context.cidades
            //                   .FirstOrDefaultAsync(p => p.Id == imput.Id);
            //if (cidade == null) return null;
            var cidades = new Cidade(imput.Nome, imput.UF);
            _context.Add(cidades);
            await _context.SaveChangesAsync();
            return cidades.ParaViewModel();
        }

        public async Task Delete(int id)
        {
            var cidadeTodelete = await _context.cidades.FindAsync(id);
            _context.cidades.Remove(cidadeTodelete);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<CidadeViewModel> ListaCidade()
        {
            IEnumerable<CidadeViewModel> cidade = _context.cidades.ToList()
                                                  .Select(p => p.ParaViewModel());
            return cidade;
        }

        public async Task<CidadeViewModel> ObterPorId(int id)
        {
            var cidade = await _context.cidades.FindAsync(id);
            if (cidade == null) return null;
            return cidade.ParaViewModel();
        }
        public async Task<CidadeViewModel> ObterPorNome(string Nome)
        {
            var cidade = await _context.cidades.FirstOrDefaultAsync(C => C.Nome == Nome);
            if (cidade == null) return null;
            if (cidade.Nome == "" || cidade.UF == "") return null; 
            return cidade.ParaViewModel();
        }
        public async Task Update(Cidade cidade)
        {
            _context.Update(cidade);
            await _context.SaveChangesAsync();
        }

    }
}
