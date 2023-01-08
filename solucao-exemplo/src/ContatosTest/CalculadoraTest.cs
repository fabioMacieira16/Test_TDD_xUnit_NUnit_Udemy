using Moq;
using Xunit;

namespace AgendaTest;

public interface ICalculadora
{
    int soma(int a, int b);
}

public class Calculadora : ICalculadora
{
    public int Somar(int a, int b) => a + b;
}

public class CalculadoraTest
{
    [Theory]
    [InlineData]
    public void Somar_DoisNumeros_RetornarsomaDosNumeros(int primeiroNumero, int segundoNumero, int resultEsperado)
    {
        //Arrange
        var MockCalculadora = new Mock<ICalculadora>();
        MockCalculadora.Setup(o => o.Somar(primeiroNumero, segundoNumero)).Returns(resultEsperado);

        //Act
        var result = MockCalculadora.Object.Soma(primeiroNumero, segundoNumero);

        //Assert
        Assert.Equal(result, resultEsperado);
    }
}
