using System;
using System.Collections.Generic;
using System.IO;
using Tuplas.Models;

class Program
{
    static void Main()
    {
        // Supondo que o método LerAquivo retorna uma tupla do tipo (bool, List<string>, int)
        LeituraArquivo arquivo = new LeituraArquivo();

        // Chamando o método LerAquivo, que deve retornar uma tupla com três valores
        var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Unidade_3/Tuplas/Models/arquivoTeste.txt");

        // Caso queira fazer o descarte de uma informação basta utilizar o "_"
        // var (sucesso, linhasArquivo, _) = arquivo.LerAquivo("Unidade_3/Tuplas/Models/arquivoTeste.txt");

        // Verificando o sucesso da leitura
        if (sucesso)
        {
            Console.WriteLine($"Arquivo lido com sucesso! Total de {quantidadeLinhas} linhas:");
            foreach (string linha in linhasArquivo)
            {
                Console.WriteLine(linha);
            }
        }
        else
        {
            Console.WriteLine("Não foi possível ler o arquivo");
        }

        // // Exemplo de uso de tupla com tipos nomeados
        // (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Rennan", "Moura", 1.83M);

        // Acessando os valores por nome
        // Console.WriteLine($"ID: {tupla.Id}");
        // Console.WriteLine($"NOME: {tupla.Nome}");
        // Console.WriteLine($"SOBRENOME: {tupla.Sobrenome}");
        // Console.WriteLine($"ALTURA: {tupla.Altura}");

        // // Outras maneiras de representar uma tupla sem nomear os campos diretamente
        // ValueTuple<int, string, string, decimal> tuplaDois = (1, "Rennan", "Moura", 1.83M);
        // Console.WriteLine($"ID: {tuplaDois.Item1}");
        // Console.WriteLine($"NOME: {tuplaDois.Item2}");
        // Console.WriteLine($"SOBRENOME: {tuplaDois.Item3}");
        // Console.WriteLine($"ALTURA: {tuplaDois.Item4}");

        // // Usando o método Create para criar uma tupla (sem a possibilidade de nomear os campos)
        // var tuplaTres = (1, "Rennan", "Moura", 1.83M);
        // Console.WriteLine($"ID: {tuplaTres.Item1}");
        // Console.WriteLine($"NOME: {tuplaTres.Item2}");
        // Console.WriteLine($"SOBRENOME: {tuplaTres.Item3}");
        // Console.WriteLine($"ALTURA: {tuplaTres.Item4}");
    }
}
