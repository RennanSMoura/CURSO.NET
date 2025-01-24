using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtor.Models
{
    public class Carro
    {
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public int Ano {get; set;}
        public Carro(string marca, string modelo, int ano)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
        }
    }
}