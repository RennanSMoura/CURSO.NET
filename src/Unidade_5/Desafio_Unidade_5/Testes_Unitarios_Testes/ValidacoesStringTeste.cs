using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testes_Unitarios_Console.Services;

namespace Testes_Unitarios_Testes
{
    public class ValidacoesStringTeste
    {
        private ValidacoesString _validacoesString;

        public ValidacoesStringTeste()
        {
            _validacoesString = new ValidacoesString();
        }

        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            // Arrange
            string palavra = "Matrix";
            int resultadoEsperado = 6;
                    
            // When
            int resultado = _validacoesString.RetornaQuantidadeCaracteresPalavra(palavra);
        
            // Then
            Assert.Equal(resultado,resultadoEsperado);
        }

        [Fact]
        public void DeveConterAPalavraQualquerNoTexto()
        {
            // Arrange
            string texto = "Esse é um texto qualquer";
            string palavraASerEncontrada = "qualquer";
        
            // Act
            var resultado = _validacoesString.PalavraContemDeterminadoCaractere(texto, palavraASerEncontrada);
        
            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            // Arrange
            string textoParaComparacao = "Esse é um texto qualquer";
            string palavraASerEncontrada = "Teste";

            // Act
            var resultado = _validacoesString.PalavraContemDeterminadoCaractere(
                textoParaComparacao, palavraASerEncontrada);
        
            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado()
        {
            // Arrange
            string textoParaComparacao = "Começo, meio e fim do texto procurado";
            string palavraASerEncontradaNoFinal = "procurado";

            // Act
            var resultado = _validacoesString.TextoTerminaCom(textoParaComparacao,palavraASerEncontradaNoFinal);

            // Assert
            Assert.True(resultado);
        }
    }
}