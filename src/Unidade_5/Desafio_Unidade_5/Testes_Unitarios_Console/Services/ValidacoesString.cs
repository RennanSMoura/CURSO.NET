using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testes_Unitarios_Console.Services
{
    public class ValidacoesString
    {
        public int RetornaQuantidadeCaracteresPalavra(string texto)
        {
            int quantidadeCaracteresTexto = texto.Length;

            return quantidadeCaracteresTexto;
        }

        public bool PalavraContemDeterminadoCaractere(string texto, string caracterProcurado)
        {
            bool palavraContemOCaratere = texto.Contains(caracterProcurado);
            return palavraContemOCaratere;
        }

        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            bool terminaComTextoProcurado = texto.EndsWith(textoProcurado);
            return terminaComTextoProcurado;
        }
    }
}