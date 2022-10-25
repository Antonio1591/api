using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Model.Domain
{
    public class Animais
    {
        protected Animais() { }
        public Animais(string raca, string nome, Pessoa responsavel, string situacao)
        {
            Raca = raca;
            Nome = nome;
            Responsavel = responsavel;
            Situacao = situacao;
        }

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
