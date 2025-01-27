using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Uma classe abstrata nao serve para ser instanciada, ela é apenas um modelo de classe
namespace Classes_Abstratas.Models
{
    public abstract class Conta
    {
        protected decimal saldo;
        // Este método abstrato fica a cargo da classe que irá herdar a abstracao da classe conta, na qual esta próxima classe irá conceder uma implementação ao método;
        public abstract void Creditar(decimal valor);
        public void ExibirSaldo()
        {
            Console.WriteLine("O Seu saldo é: " + saldo);
        }
    }
}