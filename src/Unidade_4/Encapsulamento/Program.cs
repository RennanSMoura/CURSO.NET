using Encapsulamento.Models;

ContaCorrente c1 = new ContaCorrente(123,1000);

c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();