using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YieldReturn.Model
{
    public class Pessoa
    {
        public Guid Guid { get; set; }
        public string? Nome { get; set; }
        public int Cpf { get; set; }
    }
}