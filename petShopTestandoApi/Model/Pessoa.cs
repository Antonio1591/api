using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petShopTestandoApi.Model
{
    public class Pessoa
    {
       
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
