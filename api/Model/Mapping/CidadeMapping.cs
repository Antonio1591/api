using api.Model.Domain;
using api.Model.View;

namespace api.Model.Mapping
{
    public static class CidadeMapping
    {
        public static CidadeViewModel ParaViewModel(this Cidade cidade)
        {
            return new CidadeViewModel()
            {
               
                Id = cidade.Id,
                Nome = cidade.Nome,
                UF=cidade.UF,

            };

        }
    }
}
