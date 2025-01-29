using Calculadora.Services;

CalculadoraImplementacao calculadora = new CalculadoraImplementacao();

int numero1 = 5;
int numero2 = 10;

Console.WriteLine($"{numero1} + {numero2} = {calculadora.Somar(numero1,numero2)}");