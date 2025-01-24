// Exercício 1: Crie um dicionário para armazenar nomes de alunos e suas respectivas notas. Adicione pelo menos 5 alunos e exiba a média das notas no console.

Dictionary<string, int> alunosENotas = new Dictionary<string, int>();

alunosENotas.Add("Rennan", 10);
alunosENotas.Add("Leticia", 8);
alunosENotas.Add("João", 7);
alunosENotas.Add("Ana", 6); 
alunosENotas.Add("Carlos", 9);

int somatoriaNotas = 0;
foreach (KeyValuePair<string, int> item in alunosENotas)
{
    somatoriaNotas += item.Value;
}

double mediaNotaAluno = somatoriaNotas / alunosENotas.Count;

Console.WriteLine($"A média total dos alunos é: {mediaNotaAluno}");