//Stack - Obedece a ordem LIFO (LAST IN FIRST OUT), o último a entrar vai ser o primeiro a sair. Como empilhar um bloco em cima do outro, ao tentar remover o primeiro bloco empilhado é necessário remover todos os elementos anteriores, começando do último até o primeiro 

Stack<int> pilha = new Stack<int>();

pilha.Push(50);
pilha.Push(5);
pilha.Push(900);
pilha.Push(2);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

// Saída  =  2 - 900 - 5 - 50

Console.WriteLine("Removendo o elemento do topo: " + pilha.Pop());

foreach(int item in pilha)
{
    Console.WriteLine(item);
    //Saída: 900 - 5 - 50
}


