using MetodoExtensao.Models;

int numero = 10;
bool ehPar = false;

ehPar = numero.EhPar();

Console.WriteLine($"O numero {numero} é" + (ehPar ? "par" : "impar"));