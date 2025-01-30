using Testes_Unitarios_Console.Services;

List<int> listaNumeros = new List<int>{2,3,4,-5,-7,8};

ValidacoesLista validacao = new ValidacoesLista();

List<int> listaNumerosSemNegativos = validacao.RemoverNumerosNegativos(listaNumeros);

Console.WriteLine("Lista sem negativos");
foreach(var num in listaNumerosSemNegativos)
{
    Console.WriteLine(num);
}