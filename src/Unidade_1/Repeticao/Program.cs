int soma = 0 , numero = 0;

do 
{
    Console.WriteLine("Digite um numero:(0 Para parar: )");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero ; 
}while(numero != 0);

Console.WriteLine($"Total da soma dos numero digitados é: {soma}");

// int numero = 5;
// int contador = 0 
// while(contador <=10)
// {
//     Console.WriteLine(numero * contador)
//     contador ++

//     if(contador == 6)
//     {
//         break;
//     }
// }


// int numero = 5;

// for(int contador = 0; contador <= 10; contador ++)
// {
//     Console.WriteLine(numero * contador)
// }