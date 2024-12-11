using TechTalk.SpecFlow;
using Xunit; // Certifique-se de que está importando o xUnit
using System;

namespace Testes.BDD
{
    [Binding]
    public class FeatureTestsSteps
    {
        private int _numero1;
        private int _numero2;
        private int _resultado;

        [Given(@"que eu tenho o número (.*)")]
        public void DadoQueEuTenhoONumero(int numero)
        {
            if (_numero1 == 0)
                _numero1 = numero;
            else
                _numero2 = numero;
        }

        [When(@"eu somo os dois números")]
        public void QuandoEuSomoOsDoisNumeros()
        {
            _resultado = _numero1 + _numero2;
        }

        [Then(@"o resultado deve ser (.*)")]
        public void EntaoOResultadoDeveSer(int resultadoEsperado)
        {
            Assert.Equal(resultadoEsperado, _resultado);
        }
    }
}
