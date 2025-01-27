using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtor_Heranca.Models
{
    // Ao definir que a classe Professor é do tipo SEALED, a classe diretor nao pode herdar mais de professor
    public sealed class Professor : Pessoa
    {
        public Professor(string nome) : (base nome)
        {
            
        }
        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e recebo um salário de {Salario}");
        }
    }
}