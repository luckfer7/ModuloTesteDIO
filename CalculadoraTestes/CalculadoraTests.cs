using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSubtrair10De50()
    {
        //Arrange
        int num3 = 50;
        int num4 = 10;

        //Act
        int result = _calc.Subtrair(num3, num4);

        //Assert
        Assert.Equal(40, result);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        int numero = 4;
        bool result = _calc.EhPar(numero);
        Assert.True(result);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(20)]
    [InlineData(58)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero)
    {
        bool resultado = _calc.EhPar(numero);
        Assert.True(resultado);
    }
}
