using api.Model.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Model.View
{
    public class AnimaisViewModel
    {

        public int Id { get; set; }
        public string Raca { get; set; }

        public string Nome { get; set; }

        public string NomeResponsavel { get; set; }
        
        public int ResponsavelCidade { get; set; }
        public string Situacao { get; set; }
    }
}
