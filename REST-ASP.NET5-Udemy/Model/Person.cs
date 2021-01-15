using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace REST_ASP.NET5_Udemy.Model
{
    [Table("pessoa")]
    public class Person
    {   
        [Column("id")]
        public long Id { get; set; }

        [Column("primeiro_nome")]
        public string PrimeiroNome { get; set; }

        [Column("sobrenome")]
        public string Sobrenome { get; set; }

        [Column("endereco")]
        public string Endereco { get; set; }

        [Column("genero")]
        public string Genero { get; set; }
    }
}
