using api.Model.Domain;
using api.Model.Input;
using api.Model.Mapping;
using api.Model.View;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Service
{
    public interface IAnimaisServices
    {
        IEnumerable<AnimaisViewModel> ListaAnimais();

        Task<AnimaisViewModel> Animal(int Id);

        Task<AnimaisViewModel> Create(AnimaisInputModel imput);

        Task Update(Animais animais);

        Task Delete(int Id);
    }
}
