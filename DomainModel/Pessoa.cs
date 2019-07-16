using System;
using System.ComponentModel.DataAnnotations;

namespace DomainModel
{
    public class Pessoa
    {
        [Key]
        public int Pessoa_id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
