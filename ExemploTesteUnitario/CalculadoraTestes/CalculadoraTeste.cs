using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTeste
{
    private CalculadoraImp _calc;
    public CalculadoraTeste()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
        //arrange
        int num1 = 5;
        int num2 = 10;

        //act
        int resultado = _calc.Somar(num1, num2);

        //assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveVerificarSeEParRetornarTrue()
    {
        //arrange
        int num = 4;

        //act
        bool resultado = _calc.EPar(num);

        //assert
        // Assert.Equal(true, resultado);
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarTrue(int num)
    {
        //act
        bool resultado = _calc.EPar(num);

        //assert
        // Assert.Equal(true, resultado);
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 4, 2 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosNasListasSaoParesERetornarTrue(int[] numeros)
    {
        //act /assert
        // foreach (var num in numeros)
        // {
        //     Assert.True(_calc.EPar(num));
        // }

        //o mesmo do foreach:
        Assert.All(numeros, num => Assert.True(_calc.EPar(num)));
    }
}