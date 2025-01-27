using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_Seladas.Models
{
    //Diretor nao pode herdar de professor porque ela é uma classe selada
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            // Neste o método Apresentar de diretor retornará um erro, pois na classe professor, a qual diretor herda, o método apresentar é um método selado
            Console.WriteLine("Diretor");
        }
         
    }
}