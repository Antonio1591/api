using api.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Services
{
    public interface IPessoa
    {
        Task<IEnumerable<Pessoa>> ListaPessoas();

        Task<Pessoa> Pessoa(int Id);

        Task<Pessoa> Create(Pessoa book);

        Task Update(Pessoa book);

        Task Delete(int Id);
    }
}
