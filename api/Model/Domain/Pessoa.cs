using api.Model.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace api.Model.Domain
{
    public class Pessoa
    {
        protected Pessoa()
        {

        }
        public Pessoa(string nome, DateTime dataNascimento, Cidade cidade)
        {
            Nome = nome;
            Cidade = cidade;
            DataNascimento = dataNascimento;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public Cidade Cidade { get; set; }
        [Required]
        [TypeConverter("DATE")]
        public DateTime DataNascimento { get; set; }

    }
}
