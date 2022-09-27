using api.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Service
{
    public interface IAnimaisServices
    {
        Task<IEnumerable<Animais>> ListaAnimais();

        Task<Animais> animal(int Id);

        Task<Animais> CreateAnimal(Animais animais);

        Task Update(Animais animais);

        Task Delete(int Id);
    }
}
