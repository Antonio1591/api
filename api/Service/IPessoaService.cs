using api.Model.Domain;
using api.Model.Input;
using api.Model.View;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Services
{
    public interface IPessoaService
    {
        IEnumerable<PessoaViewModel> ListaPessoas();

        Task<PessoaViewModel> ObterPorId(int Id);
        IEnumerable<Pessoa> RetornaPessoa();

        Task<PessoaViewModel> Create(PessoaInputModel input);

        Task Update(Pessoa pessoa);

        Task Delete(int Id);
    }
}
