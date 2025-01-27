using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            // Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e recebo um salário de {Salario}");
            base.Apresentar();
            Console.WriteLine($"Sou professor e recebo um salário de: {Salario}");
        }
    }
}