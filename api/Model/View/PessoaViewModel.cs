using System.ComponentModel.DataAnnotations;
using System;
using api.Model.Domain;
using System.Collections.Generic;

namespace api.Model.View
{
    public class PessoaViewModel
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public int CidadeId { get; set; }
        public DateTime DataNascimento { get; set; }
      
    }
}
