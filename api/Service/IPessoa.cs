using api.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Services
{
    public interface IPessoa
    {
        Task<IEnumerable<Pessoa>> ListaPessoas();

        Task<Pessoa> Pessoa(int Id);

        Task<Pessoa> Create(Pessoa pessoa);

        Task Update(Pessoa pessoa);

        Task Delete(int Id);
    }
}
