using Calculadora.Services;
using Xunit;

namespace CalculadoraTests
{
    public class CalculadoraTests
    {
        private readonly CalculadoraService _calc;
        public CalculadoraTests()
        {
            _calc = new CalculadoraService();
        }

        [Theory]
        [InlineData(2, 5)]
        [InlineData(1, 7)]
        public void DeveSomarOsNumerosPassadoERetornarOValorCorreto(int num1, int num2)
        {
            int resultadoEsperado = num1 + num2;

            var resultado = _calc.Somar(num1, num2, DateTime.Now.ToString());

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(5, 2)]
        [InlineData(10, 3)]
        public void DeveSubtrairOsNumerosPassadoERetornarOValorCorreto(int num1, int num2)
        {
            int resultadoEsperado = num1 - num2;

            var resultado = _calc.Subtrair(num1, num2, DateTime.Now.ToString());

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(3, 5)]
        [InlineData(9, 9)]
        public void DeveMutiplicarOsNumerosPassadoERetornarOValorCorreto(int num1, int num2)
        {
            int resultadoEsperado = num1 * num2;

            var resultado = _calc.Mutiplicar(num1, num2, DateTime.Now.ToString());

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(10, 2)]
        [InlineData(30, 3)]
        public void DeveDividirOsNumerosPassadoERetornarOValorCorreto(int num1, int num2)
        {
            int resultadoEsperado = num1 / num2;

            var resultado = _calc.Dividir(num1, num2, DateTime.Now.ToString());

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveDividirUmNumeroPorZeroERetornarUmaExcecao()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Dividir(5, 0, DateTime.Now.ToString()) );
        }

        [Fact]
        public void DeveConsultarHistoricoDeOperacoesERetornarValorCorreto()
        {
            var historico = _calc.HistoricoOperacoes();

            _calc.Somar(4, 7, DateTime.Now.ToString());
            _calc.Somar(3, 1, DateTime.Now.ToString());
            _calc.Somar(9, 6, DateTime.Now.ToString());

            Assert.NotEmpty(historico);
            Assert.Equal(3, historico.Count);
        }
    }
}