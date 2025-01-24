int numero = 10;
bool ehPar = false;

ehPar = numero % 2 == 0;
Console.WriteLine($"O numero {numero} é" + (ehPar ? "par" : "impar"));