using api.Model.Domain;
using api.Model.Input;
using api.Model.View;


namespace api.Model.Mapping
{
    public static class AnimaisMapping
    {
        public static AnimaisViewModel ParaViewModel(this Animais animais)
        {
            return new AnimaisViewModel()
            {
                Id = animais.Id,
                Raca = animais.Raca,
                Nome = animais.Nome,
                NomeResponsavel= animais.Responsavel.Nome,
                ResponsavelCidade= animais.Responsavel.Cidade.Id,

                Situacao = animais.Situacao,

            };

        }
    }
}
