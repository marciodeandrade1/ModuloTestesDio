using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }


    [Fact]
    public void DeveSomar5Com10ERetornar15()
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
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //Arrange
        int numero = 4;
        //Act
        bool resultado = _calc.EhPar(numero);
        //Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero)
    {
        //Act
        bool resultado = _calc.EhPar(numero);

        //Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] {2, 4} )]
    [InlineData(new int[] {6, 8, 10} )]
    public void DeveVerificarSeOsNumerosDosArraysSaoParesERetornarVerdadeiro(int[] numeros)
    {
        //Assert / Act
       Assert.All(numeros, x => Assert.True(_calc.EhPar(x)));
    }

}