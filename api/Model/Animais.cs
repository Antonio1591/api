using System.ComponentModel.DataAnnotations;

namespace api.Model
{
    public class Animais
    {
        public int Id { get; set; }
        [Required]
        public string Raca { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Idade { get; set; }
        [Required]
        public string Situacao { get; set; }
    }
}
