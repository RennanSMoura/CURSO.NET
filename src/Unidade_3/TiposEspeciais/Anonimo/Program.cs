// Tipo anônimo - É apenas get, ou seja, não possível alterar o valor, é feito pra criação de tipos de objetos sem necessidade da criação de uma classe para eles
var tipoAnonimo = new { Nome = "Rennan", Sobrenome = "Moura", Altura = 1.80};

Console.WriteLine("Nome: " + tipoAnonimo.Nome);
Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
Console.WriteLine("Altura  : " + tipoAnonimo.Altura);

// No exemplo abaixo vou apenas resgatar os valores do nome do produto e o preço do arquivo json feito anteriormente

var listaAnonimo = listaVenda.Select(x => new {x.Produto, x.Preco});

foreach(var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preco: {venda.Preco}");
}