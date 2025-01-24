// Exercício 1: Crie uma pilha (Stack) para armazenar livros. Adicione pelo menos 5 livros à pilha e exiba o título do livro no topo da pilha.

Stack<string> Livros = new Stack<string>();

Livros.Push("Livro 1");
Livros.Push("Livro 2");
Livros.Push("Livro 3");
Livros.Push("Livro 4");
Livros.Push("Livro 5");

while(Livros.Count > 0)
{
    Console.WriteLine("Atual Livro no topo da lista: "+Livros.Pop());
}