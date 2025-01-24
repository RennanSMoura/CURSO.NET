using Calculos.Models;

Calculadora calc = new Calculadora();

calc.Somar(10,30);
calc.Subtrair(10,30);
calc.Multiplicacao(10,30);
calc.Divisao(10,30);
calc.Potencia(2,2);
calc.Sen(30);
calc.Cos(30);
calc.Tang(30);
calc.RaizQuadrada(30);

int numero = 10;
Console.WriteLine("Incrementando o 10");
numero = numero + 1;
Console.WriteLine("Incrementado: " + numero);