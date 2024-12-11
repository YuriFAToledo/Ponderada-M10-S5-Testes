# Aplicando Testes

Este repositório contém a implementação de testes de software aplicando as técnicas de **Testes de Unidade**, **Testes com Mocks** e **Testes BDD**. Cada teste está documentado com uma explicação clara e exemplos práticos.


## Testes de Unidade

### O que são Testes de Unidade?
Testes de Unidade verificam se partes individuais (unidades) do código estão funcionando conforme esperado. Eles se concentram em testar partes isoladas, como métodos e funções.

### Exemplos de Testes de Unidade
**Exemplo 1: Verificação de uma operação de soma**
```csharp
[Fact]
public void Teste_Soma_Deve_Retornar_Resultado_Correto()
{
    int resultado = 2 + 3;
    Assert.Equal(5, resultado);
}
```

**Exemplo 2: Verificação de uma operação de subtração**
```csharp
[Fact]
public void Teste_Subtracao_Deve_Retornar_Resultado_Correto()
{
    int resultado = 5 - 3;
    Assert.Equal(2, resultado);
}

```

![""](testes_unitarios.png)

## Testes com Mock

### O que são Testes com Mock?
Os Mocks permitem simular o comportamento de objetos e dependências externas de forma controlada. Isso permite testar classes e métodos que dependem de serviços externos.

### Exemplos de Testes com Mock
**Exemplo 1: Multiplicação simulada com Moq**
```csharp
[Fact]
public void Teste_Mock_Multiplicacao_Deve_Retornar_Valor_Especifico()
{
    var mock = new Moq.Mock<IServico>();
    mock.Setup(x => x.Multiplicar(2, 3)).Returns(6);

    int resultado = mock.Object.Multiplicar(2, 3);
    Assert.Equal(6, resultado);
}
```

**Exemplo 2: Verificação de chamada de método**
```csharp
[Fact]
public void Teste_Mock_Multiplicacao_Nao_Chamada()
{
    var mock = new Moq.Mock<IServico>();
    mock.Verify(x => x.Multiplicar(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
}

```

![](testes_mock.png)

## Testes BDD
<!-- Aqui virá o conteúdo dos testes BDD -->