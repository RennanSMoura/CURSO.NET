using System;
using System.Collections.Generic;
using System.IO;  // Necessário para usar o File.ReadAllLines
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas.Models
{
    public class LeituraArquivo
    {
        // Método para ler o arquivo e retornar uma tupla com o sucesso, as linhas e a quantidade de linhas
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                // Lê todas as linhas do arquivo especificado
                string[] linhas = File.ReadAllLines(caminho);

                // Retorna uma tupla com sucesso, as linhas lidas e a quantidade de linhas
                return (true, linhas, linhas.Count());
            }
            catch(Exception)
            {
                // Caso ocorra algum erro, retorna uma tupla indicando falha na leitura
                return (false, new string[0], 0);
            }
        }
    }
}
