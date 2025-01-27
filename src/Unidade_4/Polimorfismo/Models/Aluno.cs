using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }     

        public override void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome}, tenho {Idade} anos e minha nota é {Nota}");
        }
    }
}