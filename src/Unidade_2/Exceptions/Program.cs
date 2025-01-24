// O try executa um comando com "Cautela", pois pode ocorrer um erro a qualquer momento


// try{

// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt";)

// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }
// // Ele é quem recebe a exceção
// } catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// } catch(FileNotFoundExecption ex)
// {
//     Console.WriteLine($"O arquivo não foi encontrado. {ex.Message}")
// } catch(directoryNotFoundExecption ex)
// {
//     Console.WriteLine($"O diretório não foi encontrado. {ex.Message}")
// }

// // É executado em qualquer situação, independente de erro ou funcionamento correto
// finally
// {
//     Console.WriteLine("Chegou até aqui")
// }

//EXEMPLO EXCEÇÃO
using Exceptions.Models;

new ExemploExcecao().Metodo1();
