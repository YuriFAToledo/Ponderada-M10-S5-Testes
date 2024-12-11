using Moq;
using Xunit;

public class MockTests
{
    public interface IServico
    {
        int Multiplicar(int a, int b);
    }

    [Fact]
    public void Teste_Mock_Multiplicacao_Deve_Retornar_Valor_Especifico()
    {
        var mock = new Moq.Mock<IServico>();
        mock.Setup(x => x.Multiplicar(2, 3)).Returns(6);

        int resultado = mock.Object.Multiplicar(2, 3);
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void Teste_Mock_Multiplicacao_Nao_Chamada()
    {
        var mock = new Moq.Mock<IServico>();
        mock.Verify(x => x.Multiplicar(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
    }
}
