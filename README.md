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
<!-- Aqui virá o conteúdo dos testes de mock -->

## Testes BDD
<!-- Aqui virá o conteúdo dos testes BDD -->