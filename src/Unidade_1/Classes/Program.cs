// É um conceito representado do mundo real, como uma pessoa.
// TODA CLASSE CRIADA COM LETRA MAIUSCULA

using System;

// namespace é uma organização das classes, representam o caminho lógico para representar classes de um mesmo domínio

// O arquivo Program.cs é o arquivo que sempre será executado ao iniciar o projeto em dotnet


// No arquivo program.cs:


using Classes.Models;

 // isso é utilizado para "Buscar" a classe pessoa de outro arquivo (Models/Pessoa.cs)

// É necessário fazer isso, pois eu posso ter outra(as) classes pessoas em contextos diferentes, em outros arquivos, por isso é necessário referenciar corretamente de onde quero utilizar a classe, com o namespace correto

// Agora vamos instanciar a pessoa

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Rennan";
pessoa1.Idade = 20;
pessoa1.Apresentar();


// BOAS PRÁTICAS

// CLASSES = PascalCase
// Propriedade = PascalCase
// Métodos = PascalCase
// Nome de váriavel = camelCase