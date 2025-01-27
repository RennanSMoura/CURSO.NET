using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtor_Heranca.Models
{
    public class Pessoa
    {
        // Ao criar um construtor na classe pessoa, estou definindo qué obrigatorio para todas as classes ao instanciarem um objeto implementarem um nome
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Utilizando o nome "Virtual" estou definindo que este método pode ser sobrescrita
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }

    }
}