using System.ComponentModel.DataAnnotations;

namespace api.Model.Domain
{
    public class Cidade
    {
        protected Cidade() { }

        public Cidade(string nome, string uF)
        {
            Nome = nome;
            UF = uF;
        }

        [Key]
        public int Id { get; set; }
         [Required]
        public string Nome { get; set; }
        [Required]
        public string UF { get; set; }
    }
}
