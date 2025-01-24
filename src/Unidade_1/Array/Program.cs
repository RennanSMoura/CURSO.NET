int [] arrayInicial = new int [4];
int[] array = new int [] {10,20,30,40};
string[] nomes = {"Jan","Fev"};
int[] arrayInteiros = new int[3];

arrayInteiros[0] = 10;
arrayInteiros[1] = 20;
arrayInteiros[2] = 30;

// for
for(int contador = 0; contador < arrayInteiros.Length; contador ++ )
{
    Console.WriteLine($"Posicao Numero {contador} - {arrayInteiros[contador]}");
}


// foreach
foreach(int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}


// Redimensionamento de um array 

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Copiando um array

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);