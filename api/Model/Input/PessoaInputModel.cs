using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using api.Model.Domain;

namespace api.Model.Input
{
    [NotMapped]
    public class PessoaInputModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public Cidade Cidade { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
    }
}
