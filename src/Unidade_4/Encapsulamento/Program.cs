using Encapsulamento.Models;

ContaCorrente contaCorrente = new ContaCorrente(123,1000);

contaCorrente.ExibirSaldo();
contaCorrente.Sacar(500);
contaCorrente.ExibirSaldo();