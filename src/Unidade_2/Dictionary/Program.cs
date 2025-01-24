// Um dictionary é uma coleção de chave-valor para armazenar valores únicos sem uma ordem específica.

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP","São Paulo");
estados.Add("BA","Bahia");
estados.Add("MG","Minas Gerais");

foreach(KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Add("BA", "Bahia");
//Saída: An item with the same key has already been added
// Cada item possui sua única chave, não sendo possível adicionar mais de uma chave para diferentes itens

// Remoção de itens de um dictionary
estados.Remove("SP"); // Sempre é necessário passar a chave do item para a remoção de um elemento

// Alteração de um VALOR de um dictionary, lembrando que só é possível alterar o valor, mas não a chave.
estados["MG"] = "Minas Gerais - Alterada";

foreach(KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// Verificação de existência de chave:
string chave = "MG";
Console.WriteLine("Verificando existência da chave: " + chave);

if(estados.ConstainsKey(chave)){
    Console.WriteLine("Já existe uma chave com esse valor: " + chave);
}else{
    Console.WriteLine("Não existe nenhuma chave com esse valor: " + chave);
}

// Verificando o valor de uma chave
Console.WriteLine(estados["MG"]);