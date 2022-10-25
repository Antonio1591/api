using api.Model.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Model.Input
{
    [NotMapped]
    public class AnimaisInputModel
    {

        public int Id { get; set; }
        [Required]
        public string Raca { get; set; }
        [Required]

        public string Nome { get; set; }
        [Required]
        public Pessoa Responsavel { get; set; }

        [Required]
        public string Situacao { get; set; }
    }
}
