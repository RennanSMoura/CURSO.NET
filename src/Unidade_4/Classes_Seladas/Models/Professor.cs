using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe_Selada.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e recebo um salário de {Salario}");
        }
    }
}