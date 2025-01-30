using Calculadora.Services;
namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImplementacao _calculadora;
    public CalculadoraTests()
    {
        _calculadora = new CalculadoraImplementacao();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // ARRANGE - MONTAR UM CENÁRIO
        int numero1 = 5;
        int numero2 = 10;

        // ACT - AÇÃO APÓS MONTAGEM DO CENÁRIO
        int resultado = _calculadora.Somar(numero1, numero2);

        // ASSERT - VALIDAR SE O CENÁRIO FUNCIONOU CORRETAMENTE
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // ARRANGE - MONTAR UM CENÁRIO
        int numero1 = 10;
        int numero2 = 10;

        // ACT - AÇÃO APÓS MONTAGEM DO CENÁRIO
        int resultado = _calculadora.Somar(numero1, numero2);

        // ASSERT - VALIDAR SE O CENÁRIO FUNCIONOU CORRETAMENTE
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        // Arrange
        int numero = 4;
        
        // Act
        bool resultado = _calculadora.EhPar(numero);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] {2,4})]
    [InlineData(new int[] {6,8,10})]
    // [InlineData(2)]
    // [InlineData(4)]
    // [InlineData(6)]
    // [InlineData(8)]
    // [InlineData(10)]
    public void DeveVerificarSeNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        // foreach(var item in numeros)
        // {
        //     Assert.True(_calculadora.EhPar(item));
        // }
        Assert.All(numeros, numero => Assert.True(_calculadora.EhPar(numero)));
    }
}

