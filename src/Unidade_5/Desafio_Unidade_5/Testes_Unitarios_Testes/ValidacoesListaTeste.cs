using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testes_Unitarios_Console.Services;
using Xunit;

namespace Testes_Unitarios_Testes
{
    public class ValidacoesListaTeste
    {
        private ValidacoesLista _validacaoLista;

        public ValidacoesListaTeste()
        {
            _validacaoLista = new ValidacoesLista();
        }

        [Fact]
        public void DeveRemoverNUmerosNegativosDeUmaLista()
        {
            // Arrange
            var lista = new List<int> { 10, 20, -3, 4, 3 };
            var resultadoEsperado = new List<int> { 10, 20, 4, 3 };

            // Act
            var resultado = _validacaoLista.RemoverNumerosNegativos(lista);

            // Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Fact]
        public void DeveConterONumero9NaLista()
        {
            //Arrange
            var lista = new List<int> { 3, 4, 5, 6, 7, 8, 9 };

            //Act
            var resultado = _validacaoLista.ListaContemDeterminadoNumero(lista, 9);

            //Assert
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista()
        {
            //Arrange
            var lista = new List<int> { 1, 2, 3, 4, 5, 6 };

            // When
            var resultado = _validacaoLista.ListaContemDeterminadoNumero(lista, 10);

            // Then
            Assert.True(resultado);
        }

        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2()
        {
            // Arrage
            var lista = new List<int> { 1, 2, 3, 4 };
            var resultadoEsperado = new List<int> { 2, 4, 6, 8 };

            // Act
            var resultado = _validacaoLista.MultiplicarNumerosLista(lista, 2);

            // Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista()
        {
            // Arrange
            var lista = new List<int> { 1, 2, 3, 4, 9 };
            var resultadoEsperado = 9;
            // Act
            var resultado = _validacaoLista.RetornarMaiorNumeroLista(lista);

            // Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaList()
        {
            // Arrange
            var lista = new List<int> {0,1,3,4,5,-7,-8};
            int resultadoEsperado = -8;

            // Act
            var resultado = _validacaoLista.RetornaMenorNumeroLista(lista);

            // Assert
            Assert.Equal(resultado,resultadoEsperado);
        }
    }
}