using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Unidade.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string Imei;
        private string Memoria;

        public void Ligar()
        {
            Console.WriteLine("Ligando...")
        }
        public
    }
}