using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Unidade.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public string Numero { get; set; }
        private string Modelo;
        private string Imei;
        private int Memoria;

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
        
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nome);
        
        public virtual void DemonstratConfiguracoesSmartphone()
        {
            Console.WriteLine($"Modelo: {Modelo}, Memória: {Memoria}");
        }
    }
}