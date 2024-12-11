using Xunit;

public class UnitTests
{
    [Fact]
    public void Teste_Soma_Deve_Retornar_Resultado_Correto()
    {
        int resultado = 2 + 3;
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Teste_Subtracao_Deve_Retornar_Resultado_Correto()
    {
        int resultado = 5 - 3;
        Assert.Equal(2, resultado);
    }
}
