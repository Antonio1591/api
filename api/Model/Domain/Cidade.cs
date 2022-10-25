using System.ComponentModel.DataAnnotations;

namespace api.Model.Domain
{
    public class Cidade
    {
        [Key]
        public int Id { get; set; }
         [Required]
        public string Nome { get; set; }
        [Required]
        public string UF { get; set; }
    }
}
