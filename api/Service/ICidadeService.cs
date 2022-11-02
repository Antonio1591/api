using api.Model.Domain;
using api.Model.Input;
using api.Model.Mapping;
using api.Model.View;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Service
{
    public interface ICidadeService
    {
        IEnumerable<CidadeViewModel> ListaCidade();

        Task<CidadeViewModel> ObterPorId(int Id);
        Task<CidadeViewModel> ObterPorNome(string Nome);
        Task<CidadeViewModel> Create(CidadeInputModel input);
        Task Update(Cidade cidade);
        Task Delete(int Id);
    }
}
