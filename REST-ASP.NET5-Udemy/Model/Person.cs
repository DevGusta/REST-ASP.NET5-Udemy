﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_ASP.NET5_Udemy.Model
{
    public class Person
    {
        public long Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Endereco { get; set; }
        public string Genero { get; set; }
    }
}
