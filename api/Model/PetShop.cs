using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Model
{
    public class PetShop
    {
        public int Id { get; set; }
        [Required]
        public string NomeResponsavel { get; set; }
        [Required]
        public string NomeAnimal { get; set; }
        [Required]
        public string SituacaoAnimal { get; set; }
        [Required]
        public DateTime DataEntrada { get; set; }
        [Required]
        public decimal Valor { get; set; }
    }
}
