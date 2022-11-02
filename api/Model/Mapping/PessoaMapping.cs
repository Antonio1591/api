using api.Model.Domain;
using api.Model.Input;
using api.Model.View;

namespace api.Model.Mapping
{
    public static class PessoaMapping
    {
        public static PessoaViewModel ParaViewModel(this Pessoa pessoa)
        {
            return new PessoaViewModel()
            {
                Id = pessoa.Id,
                Cidade = pessoa.Cidade.Nome,
                CidadeId = pessoa.Cidade.Id,
                DataNascimento = pessoa.DataNascimento,
                Nome = pessoa.Nome,

            };
        }

    }
}



