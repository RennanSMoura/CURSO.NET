// Uma fila segue um sequencia estrita de elementos, onde não há trocas de posicoes, o primeiro a entrar é o primeiro a sair, seguindo esse conceito independente do seu tamanho.

// O 1°Elemento é o FIFO (First in First Out)

Queue<int> fila = new Queue<int>();

//Adiciona elemento ao final da fila
fila.Enqueue(1);
fila.Enqueue(27);
fila.Enqueue(21);
fila.Enqueue(7);

foreach(int item in fila)
{
    Console.WriteLine(item);
    // Saída: 1 - 27 - 21 - 7
}

//Remove o primeiro elemento da fila
Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

foreach(int item in fila)
{
    Console.WriteLine(item);
    // Saída: 27 - 21 - 7 
}

