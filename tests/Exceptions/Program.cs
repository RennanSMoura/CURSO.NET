// Exercício 2: Crie uma função que converta uma string em um número inteiro e trate a exceção FormatException. Exiba uma mensagem apropriada no console quando a exceção for capturada.

    try
    {
    string numeroParaConversao = '5';

    int numeroConvertido = int.Parse(numeroParaConversao);
    Console.WriteLine($"Número convertido: {numeroConvertido}");
    }
    catch(FormatException)
    {
    Console.WriteLine("Não é possível converter de String para Inteiro");
    }catch (Exception ex) 
    {
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    }
