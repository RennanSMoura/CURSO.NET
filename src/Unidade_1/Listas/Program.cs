List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for(int contador = 0; contador < listaString.Count; contador ++)
{
    Console.WriteLine($"Posição N°{contador} - {listaString[contador]}");
}

// int contador = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição N°{contador} - {item}");
//     contador ++;
// }

Console.WriteLine($"Capacidade da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

// Ao fazer o uso de uma lista e adicionar mais um elemento, ela se auto-redimensiona automaticamente, não sendo necessário fazer o uso do .Resize()

