using System.ComponentModel.DataAnnotations;
using System;
using api.Model.Domain;
using System.Collections.Generic;

namespace api.Model.View
{
    public class CidadeViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
    }
}
