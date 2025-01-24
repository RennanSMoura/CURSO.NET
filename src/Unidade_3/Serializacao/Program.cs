//SERIALIZACAO
//Serialização é o processo que consiste em transformar objetos em um fluxo de bytes para seu armazenamento ou transmissão
// Ao instanciar um objeto ele só funcionará dentro do projeto atual, mas caso queira utilizar esse mesmo objeto em outro projeto é necessário fazer a chamada serialização
// Objeto do tipo pessoa - posso serializar ele para um BD, Memória ou Arquivo, para isso ele é transformado em um fluxo de Bytes;
// O processo de deserialização é o processo inverso, transformando um arquivo por exemplo em algum objeto

//JSON

// FORMATO

// {
//     "Id" : 1,
//     "Produto": "P1",
//     "Peco": 10.50
// }

// O JSON é utilizado para serializar objetos para o compartilhamento entre diferentes linguagens ou dentro do seu próprio sistema

using Serializacao.Models;

// Quem ira fazer a serialização será a biblioteca Newtonsoft.Json;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Serializacao.Models;

class Program
{
    static void Main()
    {
        DateTime dataAtual = DateTime.Now;

        // Criação da lista de vendas
        List<Venda> listaVendas = new List<Venda>();

        // Instanciando objetos do tipo Venda
        Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual, 0.00M);
        Venda v2 = new Venda(2, "Licença de software", 110.00M, dataAtual, 10.00M);

        // Adicionando os objetos na lista
        listaVendas.Add(v1);
        listaVendas.Add(v2);

        // Serializa apenas um objeto (v1)
        string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

        // Serializa a lista de objetos
        string listaSerializada = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

        // Exibe o objeto serializado no console
        Console.WriteLine(serializado);
        // A saída esperada será um string no formato JSON:
        // {
        //     "Id": 1,
        //     "Produto": "Material de escritório",
        //     "Preco": 25.00,
        //     "DataVenda": "2025-01-24T00:00:00",
        //     "Desconto": 0.00
        // }

        // Cria o diretório caso não exista
        string directoryPath = "Serializacao";
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        // Escreve o arquivo JSON com o objeto v1
        File.WriteAllText(Path.Combine(directoryPath, "venda1.json"), serializado);

        // Escreve o arquivo JSON com a lista de vendas
        File.WriteAllText(Path.Combine(directoryPath, "vendas.json"), listaSerializada);

        // Saída esperada para o arquivo vendas.json:
        // [
        //   {
        //     "Id": 1,
        //     "Produto": "Material de escritório",
        //     "Preco": 25.00,
        //     "DataVenda": "2025-01-24T00:00:00",
        //     "Desconto": 0.00
        //   },
        //   {
        //     "Id": 2,
        //     "Produto": "Licença de software",
        //     "Preco": 110.00,
        //     "DataVenda": "2025-01-24T00:00:00",
        //     "Desconto": 10.00
        //   }
        // ]
    }
}
